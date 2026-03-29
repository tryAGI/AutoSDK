//HintName: G.Models.RouterOpenRouterModelSupportedFeature.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RouterOpenRouterModelSupportedFeature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_mode")]
        JsonMode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning")]
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="structured_outputs")]
        StructuredOutputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tools")]
        Tools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search")]
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