//HintName: G.Models.DatasetValidationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The validation status of the dataset
    /// </summary>
    public enum DatasetValidationStatus
    {
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
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Validated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetValidationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetValidationStatus value)
        {
            return value switch
            {
                DatasetValidationStatus.Failed => "failed",
                DatasetValidationStatus.Processing => "processing",
                DatasetValidationStatus.Queued => "queued",
                DatasetValidationStatus.Skipped => "skipped",
                DatasetValidationStatus.Unknown => "unknown",
                DatasetValidationStatus.Validated => "validated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetValidationStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DatasetValidationStatus.Failed,
                "processing" => DatasetValidationStatus.Processing,
                "queued" => DatasetValidationStatus.Queued,
                "skipped" => DatasetValidationStatus.Skipped,
                "unknown" => DatasetValidationStatus.Unknown,
                "validated" => DatasetValidationStatus.Validated,
                _ => null,
            };
        }
    }
}