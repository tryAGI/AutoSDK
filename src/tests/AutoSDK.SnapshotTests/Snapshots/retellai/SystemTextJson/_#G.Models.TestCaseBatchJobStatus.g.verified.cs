//HintName: G.Models.TestCaseBatchJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the batch job
    /// </summary>
    public enum TestCaseBatchJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseBatchJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseBatchJobStatus value)
        {
            return value switch
            {
                TestCaseBatchJobStatus.Complete => "complete",
                TestCaseBatchJobStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseBatchJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => TestCaseBatchJobStatus.Complete,
                "in_progress" => TestCaseBatchJobStatus.InProgress,
                _ => null,
            };
        }
    }
}