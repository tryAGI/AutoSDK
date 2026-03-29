//HintName: G.Models.TestCaseJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the test case job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestCaseJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseJobStatus value)
        {
            return value switch
            {
                TestCaseJobStatus.Error => "error",
                TestCaseJobStatus.Fail => "fail",
                TestCaseJobStatus.InProgress => "in_progress",
                TestCaseJobStatus.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TestCaseJobStatus.Error,
                "fail" => TestCaseJobStatus.Fail,
                "in_progress" => TestCaseJobStatus.InProgress,
                "pass" => TestCaseJobStatus.Pass,
                _ => null,
            };
        }
    }
}