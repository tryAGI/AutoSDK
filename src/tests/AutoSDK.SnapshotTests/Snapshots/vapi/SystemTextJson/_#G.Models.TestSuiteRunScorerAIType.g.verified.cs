//HintName: G.Models.TestSuiteRunScorerAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the scorer, which must be AI.
    /// </summary>
    public enum TestSuiteRunScorerAIType
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunScorerAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunScorerAIType value)
        {
            return value switch
            {
                TestSuiteRunScorerAIType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunScorerAIType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => TestSuiteRunScorerAIType.Ai,
                _ => null,
            };
        }
    }
}