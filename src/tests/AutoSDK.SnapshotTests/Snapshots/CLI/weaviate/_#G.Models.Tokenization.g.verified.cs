﻿//HintName: G.Models.Tokenization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set tokenization of the property as separate words or whole field. Applies to text and text[] data types.<br/>
    /// Default Value: word
    /// </summary>
    public enum Tokenization
    {
        /// <summary>
        /// 
        /// </summary>
        Word,
        /// <summary>
        /// 
        /// </summary>
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        Whitespace,
        /// <summary>
        /// 
        /// </summary>
        Field,
        /// <summary>
        /// 
        /// </summary>
        Trigram,
        /// <summary>
        /// 
        /// </summary>
        Gse,
        /// <summary>
        /// 
        /// </summary>
        KagomeKr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Tokenization value)
        {
            return value switch
            {
                Tokenization.Word => "word",
                Tokenization.Lowercase => "lowercase",
                Tokenization.Whitespace => "whitespace",
                Tokenization.Field => "field",
                Tokenization.Trigram => "trigram",
                Tokenization.Gse => "gse",
                Tokenization.KagomeKr => "kagome_kr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Tokenization? ToEnum(string value)
        {
            return value switch
            {
                "word" => Tokenization.Word,
                "lowercase" => Tokenization.Lowercase,
                "whitespace" => Tokenization.Whitespace,
                "field" => Tokenization.Field,
                "trigram" => Tokenization.Trigram,
                "gse" => Tokenization.Gse,
                "kagome_kr" => Tokenization.KagomeKr,
                _ => null,
            };
        }
    }
}