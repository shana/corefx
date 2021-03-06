﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;
using OLEDB.Test.ModuleCore;

namespace XmlReaderTest.Common
{
    public partial class TCMoveToElement : TCXMLReaderBaseGeneral
    {
        // Type is XmlReaderTest.Common.TCMoveToElement
        // Test Case
        public override void AddChildren()
        {
            // for function v1
            {
                this.AddChild(new CVariation(v1) { Attribute = new Variation("Attribute node") });
            }


            // for function v2
            {
                this.AddChild(new CVariation(v2) { Attribute = new Variation("Element node") });
            }


            // for function v3
            {
                this.AddChild(new CVariation(v3) { Attribute = new Variation("XmlDeclaration node") });
            }


            // for function v5
            {
                this.AddChild(new CVariation(v5) { Attribute = new Variation("Comment node") });
            }
        }
    }
}
