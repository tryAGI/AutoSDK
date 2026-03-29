//HintName: G.Models.DatasetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum DatasetStatus
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
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetStatus value)
        {
            return value switch
            {
                DatasetStatus.Completed => "completed",
                DatasetStatus.Failed => "failed",
                DatasetStatus.Processing => "processing",
                DatasetStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DatasetStatus.Completed,
                "failed" => DatasetStatus.Failed,
                "processing" => DatasetStatus.Processing,
                "unknown" => DatasetStatus.Unknown,
                _ => null,
            };
        }
    }
}