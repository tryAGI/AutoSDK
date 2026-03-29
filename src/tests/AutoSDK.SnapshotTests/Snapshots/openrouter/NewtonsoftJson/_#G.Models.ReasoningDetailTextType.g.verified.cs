//HintName: G.Models.ReasoningDetailTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningDetailTextType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning.text")]
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailTextType value)
        {
            return value switch
            {
                ReasoningDetailTextType.ReasoningText => "reasoning.text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailTextType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.text" => ReasoningDetailTextType.ReasoningText,
                _ => null,
            };
        }
    }
}