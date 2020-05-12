// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    internal static class CjkBigramTokenFilterScriptsExtensions
    {
        public static string ToSerialString(this CjkBigramTokenFilterScripts value) => value switch
        {
            CjkBigramTokenFilterScripts.Han => "han",
            CjkBigramTokenFilterScripts.Hiragana => "hiragana",
            CjkBigramTokenFilterScripts.Katakana => "katakana",
            CjkBigramTokenFilterScripts.Hangul => "hangul",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CjkBigramTokenFilterScripts value.")
        };

        public static CjkBigramTokenFilterScripts ToCjkBigramTokenFilterScripts(this string value)
        {
            if (string.Equals(value, "han", StringComparison.InvariantCultureIgnoreCase)) return CjkBigramTokenFilterScripts.Han;
            if (string.Equals(value, "hiragana", StringComparison.InvariantCultureIgnoreCase)) return CjkBigramTokenFilterScripts.Hiragana;
            if (string.Equals(value, "katakana", StringComparison.InvariantCultureIgnoreCase)) return CjkBigramTokenFilterScripts.Katakana;
            if (string.Equals(value, "hangul", StringComparison.InvariantCultureIgnoreCase)) return CjkBigramTokenFilterScripts.Hangul;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CjkBigramTokenFilterScripts value.");
        }
    }
}
