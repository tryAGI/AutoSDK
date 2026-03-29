//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="d-id-agents")]
        DIdAgents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider.DIdAgents,
                _ => null,
            };
        }
    }
}