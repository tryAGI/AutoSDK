//HintName: G.Models.TestSuiteRunScorerAIResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the result of the test suite.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestSuiteRunScorerAIResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunScorerAIResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunScorerAIResult value)
        {
            return value switch
            {
                TestSuiteRunScorerAIResult.Fail => "fail",
                TestSuiteRunScorerAIResult.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunScorerAIResult? ToEnum(string value)
        {
            return value switch
            {
                "fail" => TestSuiteRunScorerAIResult.Fail,
                "pass" => TestSuiteRunScorerAIResult.Pass,
                _ => null,
            };
        }
    }
}