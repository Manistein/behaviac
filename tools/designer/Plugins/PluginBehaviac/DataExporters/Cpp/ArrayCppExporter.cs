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

namespace PluginBehaviac.DataExporters
{
    public class ArrayCppExporter
    {
        public static void GenerateCode(object obj, StreamWriter stream, string indent, string itemTypename, string var)
        {
            if (obj != null)
            {
                Type type = obj.GetType();

                if (Plugin.IsArrayType(type))
                {
                    System.Collections.IList list = (System.Collections.IList)obj;

                    if (list.Count > 0)
                    {
                        stream.WriteLine("{0}{1}.reserve({2});", indent, var, list.Count);

                        for (int i = 0; i < list.Count; ++i)
                        {
                            string itemName = string.Format("{0}_item{1}", var, i);

                            DataCppExporter.GenerateCode(list[i], stream, indent, itemTypename, itemName, string.Empty);

                            stream.WriteLine("{0}{1}.push_back({2});", indent, var, itemName);
                        }
                    }
                }
            }
        }
    }
}
