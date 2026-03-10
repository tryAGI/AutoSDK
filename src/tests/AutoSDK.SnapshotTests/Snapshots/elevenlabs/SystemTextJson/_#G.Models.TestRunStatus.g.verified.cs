//HintName: G.Models.TestRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Passed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestRunStatus value)
        {
            return value switch
            {
                TestRunStatus.Pending => "pending",
                TestRunStatus.Passed => "passed",
                TestRunStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => TestRunStatus.Pending,
                "passed" => TestRunStatus.Passed,
                "failed" => TestRunStatus.Failed,
                _ => null,
            };
        }
    }
}