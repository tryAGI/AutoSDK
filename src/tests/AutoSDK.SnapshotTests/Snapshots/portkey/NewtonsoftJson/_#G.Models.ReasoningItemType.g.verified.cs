//HintName: G.Models.ReasoningItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object. Always `reasoning`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning")]
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemType value)
        {
            return value switch
            {
                ReasoningItemType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => ReasoningItemType.Reasoning,
                _ => null,
            };
        }
    }
}