//HintName: G.Models.UnitTestToolCallParameterEvalDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnitTestToolCallParameterEvalDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Anything,
        /// <summary>
        /// 
        /// </summary>
        Exact,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitTestToolCallParameterEvalDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitTestToolCallParameterEvalDiscriminatorType value)
        {
            return value switch
            {
                UnitTestToolCallParameterEvalDiscriminatorType.Anything => "anything",
                UnitTestToolCallParameterEvalDiscriminatorType.Exact => "exact",
                UnitTestToolCallParameterEvalDiscriminatorType.Llm => "llm",
                UnitTestToolCallParameterEvalDiscriminatorType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitTestToolCallParameterEvalDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "anything" => UnitTestToolCallParameterEvalDiscriminatorType.Anything,
                "exact" => UnitTestToolCallParameterEvalDiscriminatorType.Exact,
                "llm" => UnitTestToolCallParameterEvalDiscriminatorType.Llm,
                "regex" => UnitTestToolCallParameterEvalDiscriminatorType.Regex,
                _ => null,
            };
        }
    }
}