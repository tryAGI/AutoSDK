//HintName: G.Models.AssistantCustomEndpointingRuleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This endpointing rule is based on the last assistant message before customer started speaking.<br/>
    /// Flow:<br/>
    /// - Assistant speaks<br/>
    /// - Customer starts speaking<br/>
    /// - Customer transcription comes in<br/>
    /// - This rule is evaluated on the last assistant message<br/>
    /// - If a match is found based on `regex`, the endpointing timeout is set to `timeoutSeconds`<br/>
    /// Usage:<br/>
    /// - If you have yes/no questions in your use case like "are you interested in a loan?", you can set a shorter timeout.<br/>
    /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantCustomEndpointingRuleType
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
    public static class AssistantCustomEndpointingRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantCustomEndpointingRuleType value)
        {
            return value switch
            {
                AssistantCustomEndpointingRuleType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantCustomEndpointingRuleType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantCustomEndpointingRuleType.Assistant,
                _ => null,
            };
        }
    }
}