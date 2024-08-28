//HintName: G.Models.CorrectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CorrectionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Grammar")]
        Grammar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Missing Word")]
        MissingWord,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Punctuation")]
        Punctuation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Spelling")]
        Spelling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Word Repetition")]
        WordRepetition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Wrong Word")]
        WrongWord,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CorrectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CorrectionType value)
        {
            return value switch
            {
                CorrectionType.Grammar => "Grammar",
                CorrectionType.MissingWord => "Missing Word",
                CorrectionType.Punctuation => "Punctuation",
                CorrectionType.Spelling => "Spelling",
                CorrectionType.WordRepetition => "Word Repetition",
                CorrectionType.WrongWord => "Wrong Word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CorrectionType? ToEnum(string value)
        {
            return value switch
            {
                "Grammar" => CorrectionType.Grammar,
                "Missing Word" => CorrectionType.MissingWord,
                "Punctuation" => CorrectionType.Punctuation,
                "Spelling" => CorrectionType.Spelling,
                "Word Repetition" => CorrectionType.WordRepetition,
                "Wrong Word" => CorrectionType.WrongWord,
                _ => null,
            };
        }
    }
}