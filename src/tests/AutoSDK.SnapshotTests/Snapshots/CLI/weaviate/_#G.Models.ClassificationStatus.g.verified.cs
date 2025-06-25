//HintName: G.Models.ClassificationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// status of this classification<br/>
    /// Example: running
    /// </summary>
    public enum ClassificationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassificationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassificationStatus value)
        {
            return value switch
            {
                ClassificationStatus.Running => "running",
                ClassificationStatus.Completed => "completed",
                ClassificationStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassificationStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => ClassificationStatus.Running,
                "completed" => ClassificationStatus.Completed,
                "failed" => ClassificationStatus.Failed,
                _ => null,
            };
        }
    }
}