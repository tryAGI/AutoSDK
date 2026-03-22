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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
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
                ClassificationStatus.Completed => "completed",
                ClassificationStatus.Failed => "failed",
                ClassificationStatus.Running => "running",
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
                "completed" => ClassificationStatus.Completed,
                "failed" => ClassificationStatus.Failed,
                "running" => ClassificationStatus.Running,
                _ => null,
            };
        }
    }
}