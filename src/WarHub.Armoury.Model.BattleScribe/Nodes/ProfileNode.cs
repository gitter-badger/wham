﻿// WarHub licenses this file to you under the MIT license.
// See LICENSE file in the project root for more information.

namespace WarHub.Armoury.Model.BattleScribe.Nodes
{
    using System;
    using System.Collections.Generic;
    using BattleScribeXml;
    using Profile = BattleScribe.Profile;

    internal class ProfileNode
        : XmlBackedNodeSimple<IProfile, Profile, BattleScribeXml.Profile, ICatalogueContextProvider>
    {
        public ProfileNode(Func<IList<BattleScribeXml.Profile>> listGet, ICatalogueContextProvider parent)
            : base(parent, listGet, Transformation, Factory)
        {
        }

        protected override void ProcessItemAddition(IProfile item)
        {
            item.Context = Parent.Context;
        }

        protected override void ProcessItemRemoval(IProfile item)
        {
            item.Context = null;
        }

        private static Profile Factory()
        {
            var xml = new BattleScribeXml.Profile();
            xml.SetNewGuid();
            return Transformation(xml);
        }

        private static Profile Transformation(BattleScribeXml.Profile arg)
        {
            return new Profile(arg);
        }
    }
}
