//HintName: G.Models.StartSpeakingPlanSmartEndpointingEnabled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StartSpeakingPlanSmartEndpointingEnabled
    {
        /// <summary>
        /// 
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartSpeakingPlanSmartEndpointingEnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartSpeakingPlanSmartEndpointingEnabled value)
        {
            return value switch
            {
                StartSpeakingPlanSmartEndpointingEnabled.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartSpeakingPlanSmartEndpointingEnabled? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => StartSpeakingPlanSmartEndpointingEnabled.Livekit,
                _ => null,
            };
        }
    }
}