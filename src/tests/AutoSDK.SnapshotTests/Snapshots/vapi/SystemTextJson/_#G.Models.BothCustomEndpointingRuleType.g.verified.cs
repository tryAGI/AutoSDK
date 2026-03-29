//HintName: G.Models.BothCustomEndpointingRuleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This endpointing rule is based on both the last assistant message and the current customer message as they are speaking.<br/>
    /// Flow:<br/>
    /// - Assistant speaks<br/>
    /// - Customer starts speaking<br/>
    /// - Customer transcription comes in<br/>
    /// - This rule is evaluated on the last assistant message and the current customer transcription<br/>
    /// - If assistant message matches `assistantRegex` AND customer message matches `customerRegex`, the endpointing timeout is set to `timeoutSeconds`<br/>
    /// Usage:<br/>
    /// - If you want to wait longer while customer is speaking numbers, you can set a longer timeout.
    /// </summary>
    public enum BothCustomEndpointingRuleType
    {
        /// <summary>
        /// 
        /// </summary>
        Both,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BothCustomEndpointingRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BothCustomEndpointingRuleType value)
        {
            return value switch
            {
                BothCustomEndpointingRuleType.Both => "both",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BothCustomEndpointingRuleType? ToEnum(string value)
        {
            return value switch
            {
                "both" => BothCustomEndpointingRuleType.Both,
                _ => null,
            };
        }
    }
}