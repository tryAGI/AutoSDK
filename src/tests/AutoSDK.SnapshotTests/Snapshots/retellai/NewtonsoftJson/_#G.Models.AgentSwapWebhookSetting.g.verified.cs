//HintName: G.Models.AgentSwapWebhookSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentSwapWebhookSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="both_agents")]
        BothAgents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="only_destination_agent")]
        OnlyDestinationAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="only_source_agent")]
        OnlySourceAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSwapWebhookSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSwapWebhookSetting value)
        {
            return value switch
            {
                AgentSwapWebhookSetting.BothAgents => "both_agents",
                AgentSwapWebhookSetting.OnlyDestinationAgent => "only_destination_agent",
                AgentSwapWebhookSetting.OnlySourceAgent => "only_source_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSwapWebhookSetting? ToEnum(string value)
        {
            return value switch
            {
                "both_agents" => AgentSwapWebhookSetting.BothAgents,
                "only_destination_agent" => AgentSwapWebhookSetting.OnlyDestinationAgent,
                "only_source_agent" => AgentSwapWebhookSetting.OnlySourceAgent,
                _ => null,
            };
        }
    }
}