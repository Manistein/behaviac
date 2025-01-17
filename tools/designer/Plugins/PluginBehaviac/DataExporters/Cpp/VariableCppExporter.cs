﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Behaviac.Design.Attributes;

namespace PluginBehaviac.DataExporters
{
    public class VariableCppExporter
    {
        public static void GenerateClassConstructor(Behaviac.Design.VariableDef variable, StreamWriter stream, string indent, string var)
        {
            if (variable.ValueClass == Behaviac.Design.VariableDef.kConst)
            {
                Type type = variable.Value.GetType();
                if (Plugin.IsArrayType(type) || Plugin.IsCustomClassType(type) || Plugin.IsStringType(type))
                {
                    if (Plugin.IsArrayType(type))
                    {
                        string nativeType = DataCppExporter.GetGeneratedNativeType(variable.NativeType);
                        int startIndex = nativeType.IndexOf('<');
                        int endIndex = nativeType.LastIndexOf('>');
                        string itemType = nativeType.Substring(startIndex + 1, endIndex - startIndex - 1);

                        ArrayCppExporter.GenerateCode(variable.Value, stream, indent + "\t\t\t", itemType, var);
                    }
                    else if (Plugin.IsCustomClassType(type))
                    {
                        StructCppExporter.GenerateCode(variable.Value, stream, indent + "\t\t\t", var, null, "");
                    }
                    else if (Plugin.IsStringType(type))
                    {
                        string nativeType = DataCppExporter.GetBasicGeneratedNativeType(variable.NativeType);
                        string retStr = DataCppExporter.GenerateCode(variable.Value, stream, indent + "\t\t\t", nativeType, string.Empty, string.Empty);
                        stream.WriteLine("{0}\t\t\t{1} = {2};", indent, var, retStr);
                    }
                }
            }
        }

        public static void GenerateClassMember(Behaviac.Design.VariableDef variable, StreamWriter stream, string indent, string var)
        {
            if (variable.ValueClass == Behaviac.Design.VariableDef.kConst)
            {
                Type type = variable.Value.GetType();
                if (Plugin.IsArrayType(type) || Plugin.IsCustomClassType(type) || Plugin.IsStringType(type))
                {
                    string nativeType = DataCppExporter.GetBasicGeneratedNativeType(variable.NativeType);
                    stream.WriteLine("{0}\t\t{1} {2};", indent, nativeType, var);
                }
            }
        }

        public static string GenerateCode(Behaviac.Design.VariableDef variable, StreamWriter stream, string indent, string typename, string var, string caller)
        {
            string retStr = string.Empty;

            if (variable.ValueClass == Behaviac.Design.VariableDef.kConst || variable.ValueClass == Behaviac.Design.VariableDef.kPar)
            {
                bool shouldGenerate = true;
                if (variable.ValueClass == Behaviac.Design.VariableDef.kConst)
                {
                    Type type = variable.Value.GetType();
                    if (Plugin.IsArrayType(type) || Plugin.IsCustomClassType(type) || Plugin.IsStringType(type))
                    {
                        shouldGenerate = false;
                    }
                }

                if (shouldGenerate)
                {
                    retStr = DataCppExporter.GenerateCode(variable.Value, stream, indent, typename, var, caller);
                }
            }
            else if (variable.Property != null)
            {
                retStr = PropertyCppExporter.GenerateCode(variable.Property, stream, indent, typename, var, caller);
            }

            return retStr;
        }

        public static void PostGenerateCode(Behaviac.Design.VariableDef variable, StreamWriter stream, string indent, string typename, string var, string caller, object parent = null, string paramName = "", string setValue = null)
        {
            if (variable.ValueClass == Behaviac.Design.VariableDef.kConst)
            {
                Type type = variable.Value.GetType();
                if (Plugin.IsCustomClassType(type) && !DesignerStruct.IsPureConstDatum(variable.Value, parent, paramName))
                {
                    StructCppExporter.PostGenerateCode(variable.Value, stream, indent, var, parent, paramName);
                }
            }
            else if (variable.ValueClass == Behaviac.Design.VariableDef.kPar)
            {
                Behaviac.Design.ParInfo par = variable.Value as Behaviac.Design.ParInfo;
                if (par != null)
                {
                    ParInfoCppExporter.PostGenerateCode(par, stream, indent, typename, var, caller);
                }
            }
            else if (variable.Property != null)
            {
                PropertyCppExporter.PostGenerateCode(variable.Property, stream, indent, typename, var, caller, setValue);
            }
        }
    }
}
