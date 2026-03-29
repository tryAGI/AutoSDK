//HintName: G.Models.TestSuiteTestScorerAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the scorer, which must be AI.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestSuiteTestScorerAIType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai")]
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteTestScorerAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteTestScorerAIType value)
        {
            return value switch
            {
                TestSuiteTestScorerAIType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteTestScorerAIType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => TestSuiteTestScorerAIType.Ai,
                _ => null,
            };
        }
    }
}