﻿// WarHub licenses this file to you under the MIT license.
// See LICENSE file in the project root for more information.

namespace WarHub.Armoury.Model.BattleScribe.ModelBases
{
    public class XmlBackedModelBase<TXml> : ModelBase, IXmlBackedObject<TXml>
    {
        public XmlBackedModelBase(TXml xmlBackend)
        {
            XmlBackend = xmlBackend;
        }

        public TXml XmlBackend { get; }
    }
}
