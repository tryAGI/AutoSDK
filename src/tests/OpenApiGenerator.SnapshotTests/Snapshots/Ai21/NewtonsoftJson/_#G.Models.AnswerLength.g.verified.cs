//HintName: G.Models.AnswerLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnswerLength
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="short")]
        Short,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="long")]
        Long,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerLength value)
        {
            return value switch
            {
                AnswerLength.Short => "short",
                AnswerLength.Medium => "medium",
                AnswerLength.Long => "long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerLength? ToEnum(string value)
        {
            return value switch
            {
                "short" => AnswerLength.Short,
                "medium" => AnswerLength.Medium,
                "long" => AnswerLength.Long,
                _ => null,
            };
        }
    }
}