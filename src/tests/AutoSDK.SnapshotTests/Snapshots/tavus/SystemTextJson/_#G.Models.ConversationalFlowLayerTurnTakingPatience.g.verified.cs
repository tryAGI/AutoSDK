//HintName: G.Models.ConversationalFlowLayerTurnTakingPatience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationalFlowLayerTurnTakingPatience
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationalFlowLayerTurnTakingPatienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationalFlowLayerTurnTakingPatience value)
        {
            return value switch
            {
                ConversationalFlowLayerTurnTakingPatience.High => "high",
                ConversationalFlowLayerTurnTakingPatience.Low => "low",
                ConversationalFlowLayerTurnTakingPatience.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationalFlowLayerTurnTakingPatience? ToEnum(string value)
        {
            return value switch
            {
                "high" => ConversationalFlowLayerTurnTakingPatience.High,
                "low" => ConversationalFlowLayerTurnTakingPatience.Low,
                "medium" => ConversationalFlowLayerTurnTakingPatience.Medium,
                _ => null,
            };
        }
    }
}