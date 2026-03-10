//HintName: G.Models.TestRunMetadataTestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: llm
    /// </summary>
    public enum TestRunMetadataTestType
    {
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        Simulation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestRunMetadataTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestRunMetadataTestType value)
        {
            return value switch
            {
                TestRunMetadataTestType.Llm => "llm",
                TestRunMetadataTestType.ToolCall => "tool_call",
                TestRunMetadataTestType.Simulation => "simulation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestRunMetadataTestType? ToEnum(string value)
        {
            return value switch
            {
                "llm" => TestRunMetadataTestType.Llm,
                "tool_call" => TestRunMetadataTestType.ToolCall,
                "simulation" => TestRunMetadataTestType.Simulation,
                _ => null,
            };
        }
    }
}