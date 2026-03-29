//HintName: G.Models.VapiSmartEndpointingPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider for the smart endpointing plan.<br/>
    /// Example: vapi
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VapiSmartEndpointingPlanProvider
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
    public static class VapiSmartEndpointingPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiSmartEndpointingPlanProvider value)
        {
            return value switch
            {
                VapiSmartEndpointingPlanProvider.CustomEndpointingModel => "custom-endpointing-model",
                VapiSmartEndpointingPlanProvider.Livekit => "livekit",
                VapiSmartEndpointingPlanProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiSmartEndpointingPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-endpointing-model" => VapiSmartEndpointingPlanProvider.CustomEndpointingModel,
                "livekit" => VapiSmartEndpointingPlanProvider.Livekit,
                "vapi" => VapiSmartEndpointingPlanProvider.Vapi,
                _ => null,
            };
        }
    }
}