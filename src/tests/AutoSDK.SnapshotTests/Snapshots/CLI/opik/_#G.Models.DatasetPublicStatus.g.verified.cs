//HintName: G.Models.DatasetPublicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum DatasetPublicStatus
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
    public static class DatasetPublicStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetPublicStatus value)
        {
            return value switch
            {
                DatasetPublicStatus.Completed => "completed",
                DatasetPublicStatus.Failed => "failed",
                DatasetPublicStatus.Processing => "processing",
                DatasetPublicStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetPublicStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DatasetPublicStatus.Completed,
                "failed" => DatasetPublicStatus.Failed,
                "processing" => DatasetPublicStatus.Processing,
                "unknown" => DatasetPublicStatus.Unknown,
                _ => null,
            };
        }
    }
}