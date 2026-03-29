//HintName: G.Models.HandoffDestinationAssistantType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HandoffDestinationAssistantType
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
    public static class HandoffDestinationAssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HandoffDestinationAssistantType value)
        {
            return value switch
            {
                HandoffDestinationAssistantType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HandoffDestinationAssistantType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => HandoffDestinationAssistantType.Assistant,
                _ => null,
            };
        }
    }
}