//HintName: G.Models.SimulationRunTransportConfigurationProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Transport provider for the simulation run
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimulationRunTransportConfigurationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi.webchat")]
        VapiWebchat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi.websocket")]
        VapiWebsocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunTransportConfigurationProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunTransportConfigurationProvider value)
        {
            return value switch
            {
                SimulationRunTransportConfigurationProvider.VapiWebchat => "vapi.webchat",
                SimulationRunTransportConfigurationProvider.VapiWebsocket => "vapi.websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunTransportConfigurationProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi.webchat" => SimulationRunTransportConfigurationProvider.VapiWebchat,
                "vapi.websocket" => SimulationRunTransportConfigurationProvider.VapiWebsocket,
                _ => null,
            };
        }
    }
}