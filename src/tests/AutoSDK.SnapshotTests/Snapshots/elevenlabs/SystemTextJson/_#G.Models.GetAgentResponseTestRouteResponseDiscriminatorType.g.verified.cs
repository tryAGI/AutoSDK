//HintName: G.Models.GetAgentResponseTestRouteResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentResponseTestRouteResponseDiscriminatorType
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
    public static class GetAgentResponseTestRouteResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentResponseTestRouteResponseDiscriminatorType value)
        {
            return value switch
            {
                GetAgentResponseTestRouteResponseDiscriminatorType.Llm => "llm",
                GetAgentResponseTestRouteResponseDiscriminatorType.Tool => "tool",
                GetAgentResponseTestRouteResponseDiscriminatorType.Simulation => "simulation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentResponseTestRouteResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm" => GetAgentResponseTestRouteResponseDiscriminatorType.Llm,
                "tool" => GetAgentResponseTestRouteResponseDiscriminatorType.Tool,
                "simulation" => GetAgentResponseTestRouteResponseDiscriminatorType.Simulation,
                _ => null,
            };
        }
    }
}