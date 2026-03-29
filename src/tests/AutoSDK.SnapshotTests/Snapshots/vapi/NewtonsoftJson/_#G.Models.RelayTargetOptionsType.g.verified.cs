//HintName: G.Models.RelayTargetOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RelayTargetOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squad")]
        Squad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayTargetOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayTargetOptionsType value)
        {
            return value switch
            {
                RelayTargetOptionsType.Assistant => "assistant",
                RelayTargetOptionsType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayTargetOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => RelayTargetOptionsType.Assistant,
                "squad" => RelayTargetOptionsType.Squad,
                _ => null,
            };
        }
    }
}