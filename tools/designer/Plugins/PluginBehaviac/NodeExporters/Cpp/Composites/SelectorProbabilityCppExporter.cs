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
using Behaviac.Design;
using Behaviac.Design.Nodes;
using Behaviac.Design.Attributes;
using PluginBehaviac.Nodes;

namespace PluginBehaviac.NodeExporters
{
    public class SelectorProbabilityCppExporter : NodeCppExporter
    {
        protected override bool ShouldGenerateClass(Node node)
        {
            return true;
        }

        protected override void GenerateMethod(Node node, StreamWriter stream, string indent)
        {
            SelectorProbability selectorProbability = node as SelectorProbability;
            Debug.Check(selectorProbability != null);

            stream.WriteLine("{0}\tpublic:", indent);

            stream.WriteLine("{0}\t\tvoid Initialize(const char* method)", indent);
            stream.WriteLine("{0}\t\t{{", indent);
            stream.WriteLine("{0}\t\t\tthis->m_method = LoadMethod(method);", indent);
            stream.WriteLine("{0}\t\t}}", indent);
        }

        public override void GenerateInstance(Node node, StreamWriter stream, string indent, string nodeName, string agentType, string btClassName)
        {
            base.GenerateInstance(node, stream, indent, nodeName, agentType, btClassName);

            SelectorProbability selectorProbability = node as SelectorProbability;
            Debug.Check(selectorProbability != null);

            if (selectorProbability.RandomGenerator != null)
            {
                string method = selectorProbability.RandomGenerator.GetExportValue().Replace("\"", "\\\"");

                stream.WriteLine("{0}\t{1}->Initialize(\"{2}\");", indent, nodeName, method);
            }
        }
    }
}
