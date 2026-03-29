//HintName: G.Models.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider
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
    public static class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider value)
        {
            return value switch
            {
                PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider.DIdAgents,
                _ => null,
            };
        }
    }
}