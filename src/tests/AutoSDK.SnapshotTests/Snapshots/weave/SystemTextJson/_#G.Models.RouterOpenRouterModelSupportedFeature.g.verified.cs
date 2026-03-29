//HintName: G.Models.RouterOpenRouterModelSupportedFeature.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RouterOpenRouterModelSupportedFeature
    {
        /// <summary>
        /// 
        /// </summary>
        JsonMode,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        StructuredOutputs,
        /// <summary>
        /// 
        /// </summary>
        Tools,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouterOpenRouterModelSupportedFeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouterOpenRouterModelSupportedFeature value)
        {
            return value switch
            {
                RouterOpenRouterModelSupportedFeature.JsonMode => "json_mode",
                RouterOpenRouterModelSupportedFeature.Reasoning => "reasoning",
                RouterOpenRouterModelSupportedFeature.StructuredOutputs => "structured_outputs",
                RouterOpenRouterModelSupportedFeature.Tools => "tools",
                RouterOpenRouterModelSupportedFeature.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouterOpenRouterModelSupportedFeature? ToEnum(string value)
        {
            return value switch
            {
                "json_mode" => RouterOpenRouterModelSupportedFeature.JsonMode,
                "reasoning" => RouterOpenRouterModelSupportedFeature.Reasoning,
                "structured_outputs" => RouterOpenRouterModelSupportedFeature.StructuredOutputs,
                "tools" => RouterOpenRouterModelSupportedFeature.Tools,
                "web_search" => RouterOpenRouterModelSupportedFeature.WebSearch,
                _ => null,
            };
        }
    }
}