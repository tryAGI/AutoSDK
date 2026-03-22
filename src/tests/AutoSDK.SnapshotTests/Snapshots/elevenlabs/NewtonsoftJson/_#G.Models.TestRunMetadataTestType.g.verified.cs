//HintName: G.Models.TestRunMetadataTestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: llm
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestRunMetadataTestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simulation")]
        Simulation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_call")]
        ToolCall,
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
                TestRunMetadataTestType.Simulation => "simulation",
                TestRunMetadataTestType.ToolCall => "tool_call",
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
                "simulation" => TestRunMetadataTestType.Simulation,
                "tool_call" => TestRunMetadataTestType.ToolCall,
                _ => null,
            };
        }
    }
}