//HintName: G.Models.UpdateAgentResponseTestRouteResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAgentResponseTestRouteResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Simulation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAgentResponseTestRouteResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentResponseTestRouteResponseDiscriminatorType value)
        {
            return value switch
            {
                UpdateAgentResponseTestRouteResponseDiscriminatorType.Llm => "llm",
                UpdateAgentResponseTestRouteResponseDiscriminatorType.Tool => "tool",
                UpdateAgentResponseTestRouteResponseDiscriminatorType.Simulation => "simulation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentResponseTestRouteResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm" => UpdateAgentResponseTestRouteResponseDiscriminatorType.Llm,
                "tool" => UpdateAgentResponseTestRouteResponseDiscriminatorType.Tool,
                "simulation" => UpdateAgentResponseTestRouteResponseDiscriminatorType.Simulation,
                _ => null,
            };
        }
    }
}