//HintName: G.Models.TopicAutomationConfigFacetFunctionVariant2GlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicAutomationConfigFacetFunctionVariant2GlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationConfigFacetFunctionVariant2GlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationConfigFacetFunctionVariant2GlobalType value)
        {
            return value switch
            {
                TopicAutomationConfigFacetFunctionVariant2GlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationConfigFacetFunctionVariant2GlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => TopicAutomationConfigFacetFunctionVariant2GlobalType.Global,
                _ => null,
            };
        }
    }
}