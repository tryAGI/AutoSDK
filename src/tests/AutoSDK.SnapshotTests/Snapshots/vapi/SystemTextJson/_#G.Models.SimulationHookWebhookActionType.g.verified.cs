//HintName: G.Models.SimulationHookWebhookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationHookWebhookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationHookWebhookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationHookWebhookActionType value)
        {
            return value switch
            {
                SimulationHookWebhookActionType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationHookWebhookActionType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => SimulationHookWebhookActionType.Webhook,
                _ => null,
            };
        }
    }
}