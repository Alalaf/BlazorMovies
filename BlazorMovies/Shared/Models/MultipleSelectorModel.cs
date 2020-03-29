using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Models
{
    public struct MultipleSelectorModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public MultipleSelectorModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
