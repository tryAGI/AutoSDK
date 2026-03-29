//HintName: G.Models.TestSuiteRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the current status of the test suite run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestSuiteRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in-progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunStatus value)
        {
            return value switch
            {
                TestSuiteRunStatus.Completed => "completed",
                TestSuiteRunStatus.Failed => "failed",
                TestSuiteRunStatus.InProgress => "in-progress",
                TestSuiteRunStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TestSuiteRunStatus.Completed,
                "failed" => TestSuiteRunStatus.Failed,
                "in-progress" => TestSuiteRunStatus.InProgress,
                "queued" => TestSuiteRunStatus.Queued,
                _ => null,
            };
        }
    }
}