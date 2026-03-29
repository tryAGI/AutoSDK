//HintName: G.Models.LivekitSmartEndpointingPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider for the smart endpointing plan.<br/>
    /// Example: livekit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LivekitSmartEndpointingPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-endpointing-model")]
        CustomEndpointingModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="livekit")]
        Livekit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi")]
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LivekitSmartEndpointingPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LivekitSmartEndpointingPlanProvider value)
        {
            return value switch
            {
                LivekitSmartEndpointingPlanProvider.CustomEndpointingModel => "custom-endpointing-model",
                LivekitSmartEndpointingPlanProvider.Livekit => "livekit",
                LivekitSmartEndpointingPlanProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LivekitSmartEndpointingPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-endpointing-model" => LivekitSmartEndpointingPlanProvider.CustomEndpointingModel,
                "livekit" => LivekitSmartEndpointingPlanProvider.Livekit,
                "vapi" => LivekitSmartEndpointingPlanProvider.Vapi,
                _ => null,
            };
        }
    }
}