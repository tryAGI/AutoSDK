//HintName: G.Models.DatasetExportJobPublicStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum DatasetExportJobPublicStatus
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetExportJobPublicStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetExportJobPublicStatus value)
        {
            return value switch
            {
                DatasetExportJobPublicStatus.Completed => "COMPLETED",
                DatasetExportJobPublicStatus.Failed => "FAILED",
                DatasetExportJobPublicStatus.Pending => "PENDING",
                DatasetExportJobPublicStatus.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetExportJobPublicStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => DatasetExportJobPublicStatus.Completed,
                "FAILED" => DatasetExportJobPublicStatus.Failed,
                "PENDING" => DatasetExportJobPublicStatus.Pending,
                "PROCESSING" => DatasetExportJobPublicStatus.Processing,
                _ => null,
            };
        }
    }
}