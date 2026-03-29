//HintName: G.Models.CustomEndpointingModelSmartEndpointingPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider for the smart endpointing plan. Use `custom-endpointing-model` for custom endpointing providers that are not natively supported.<br/>
    /// Example: custom-endpointing-model
    /// </summary>
    public enum CustomEndpointingModelSmartEndpointingPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomEndpointingModel,
        /// <summary>
        /// 
        /// </summary>
        Livekit,
        /// <summary>
        /// 
        /// </summary>
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomEndpointingModelSmartEndpointingPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomEndpointingModelSmartEndpointingPlanProvider value)
        {
            return value switch
            {
                CustomEndpointingModelSmartEndpointingPlanProvider.CustomEndpointingModel => "custom-endpointing-model",
                CustomEndpointingModelSmartEndpointingPlanProvider.Livekit => "livekit",
                CustomEndpointingModelSmartEndpointingPlanProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomEndpointingModelSmartEndpointingPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-endpointing-model" => CustomEndpointingModelSmartEndpointingPlanProvider.CustomEndpointingModel,
                "livekit" => CustomEndpointingModelSmartEndpointingPlanProvider.Livekit,
                "vapi" => CustomEndpointingModelSmartEndpointingPlanProvider.Vapi,
                _ => null,
            };
        }
    }
}