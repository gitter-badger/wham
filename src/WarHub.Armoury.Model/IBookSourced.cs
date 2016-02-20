﻿// WarHub licenses this file to you under the MIT license.
// See LICENSE file in the project root for more information.

namespace WarHub.Armoury.Model
{
    using System.ComponentModel;

    public interface IBookSourced : INotifyPropertyChanged
    {
        string BookSources { get; set; }
    }
}
