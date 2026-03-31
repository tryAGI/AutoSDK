//HintName: G.Models.TopicAutomationConfigFacetFunctionVariant2FunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicAutomationConfigFacetFunctionVariant2FunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationConfigFacetFunctionVariant2FunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationConfigFacetFunctionVariant2FunctionType value)
        {
            return value switch
            {
                TopicAutomationConfigFacetFunctionVariant2FunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationConfigFacetFunctionVariant2FunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => TopicAutomationConfigFacetFunctionVariant2FunctionType.Function,
                _ => null,
            };
        }
    }
}