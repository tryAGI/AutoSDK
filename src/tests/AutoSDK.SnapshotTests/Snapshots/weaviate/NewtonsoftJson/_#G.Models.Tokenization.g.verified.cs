//HintName: G.Models.Tokenization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set tokenization of the property as separate words or whole field. Applies to text and text[] data types.<br/>
    /// Default Value: word
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Tokenization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="field")]
        Field,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gse")]
        Gse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kagome_kr")]
        KagomeKr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lowercase")]
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trigram")]
        Trigram,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whitespace")]
        Whitespace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
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
                Tokenization.Field => "field",
                Tokenization.Gse => "gse",
                Tokenization.KagomeKr => "kagome_kr",
                Tokenization.Lowercase => "lowercase",
                Tokenization.Trigram => "trigram",
                Tokenization.Whitespace => "whitespace",
                Tokenization.Word => "word",
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
                "field" => Tokenization.Field,
                "gse" => Tokenization.Gse,
                "kagome_kr" => Tokenization.KagomeKr,
                "lowercase" => Tokenization.Lowercase,
                "trigram" => Tokenization.Trigram,
                "whitespace" => Tokenization.Whitespace,
                "word" => Tokenization.Word,
                _ => null,
            };
        }
    }
}