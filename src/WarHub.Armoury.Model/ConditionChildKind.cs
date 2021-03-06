﻿// WarHub licenses this file to you under the MIT license.
// See LICENSE file in the project root for more information.

namespace WarHub.Armoury.Model
{
    using System.Xml.Serialization;

    public enum ConditionChildKind
    {
        [XmlEnum(ReservedIdentifiers.NoChildName)] NoChild,
        [XmlEnum(ReservedIdentifiers.ReferenceName)] Reference
    }
}
