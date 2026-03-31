//HintName: G.Models.AgentUseCase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentUseCase
    {
        /// <summary>
        /// 
        /// </summary>
        DIdAgents,
        /// <summary>
        /// 
        /// </summary>
        DIdCampaigns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUseCase value)
        {
            return value switch
            {
                AgentUseCase.DIdAgents => "d-id-agents",
                AgentUseCase.DIdCampaigns => "d-id-campaigns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUseCase? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => AgentUseCase.DIdAgents,
                "d-id-campaigns" => AgentUseCase.DIdCampaigns,
                _ => null,
            };
        }
    }
}