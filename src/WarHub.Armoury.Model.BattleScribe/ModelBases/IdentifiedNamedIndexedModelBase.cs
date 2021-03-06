﻿// WarHub licenses this file to you under the MIT license.
// See LICENSE file in the project root for more information.

namespace WarHub.Armoury.Model.BattleScribe.ModelBases
{
    using BattleScribeXml;

    public class IdentifiedNamedIndexedModelBase<TXml>
        : NamedIndexedModelBase<TXml>, IIdentifiable
        where TXml : IIdentified, INamed, IBookIndexed
    {
        public IdentifiedNamedIndexedModelBase(TXml xml)
            : base(xml)
        {
            Id = new Identifier(xml);
        }

        public IIdentifier Id { get; }
    }
}
