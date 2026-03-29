//HintName: G.Models.RelayTargetAssistantType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of relay target
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RelayTargetAssistantType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayTargetAssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayTargetAssistantType value)
        {
            return value switch
            {
                RelayTargetAssistantType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayTargetAssistantType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => RelayTargetAssistantType.Assistant,
                _ => null,
            };
        }
    }
}