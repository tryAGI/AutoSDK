//HintName: G.Models.PostCallAnalysisSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostCallAnalysisSetting
    {
        /// <summary>
        /// 
        /// </summary>
        BothAgents,
        /// <summary>
        /// 
        /// </summary>
        OnlyDestinationAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCallAnalysisSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCallAnalysisSetting value)
        {
            return value switch
            {
                PostCallAnalysisSetting.BothAgents => "both_agents",
                PostCallAnalysisSetting.OnlyDestinationAgent => "only_destination_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCallAnalysisSetting? ToEnum(string value)
        {
            return value switch
            {
                "both_agents" => PostCallAnalysisSetting.BothAgents,
                "only_destination_agent" => PostCallAnalysisSetting.OnlyDestinationAgent,
                _ => null,
            };
        }
    }
}