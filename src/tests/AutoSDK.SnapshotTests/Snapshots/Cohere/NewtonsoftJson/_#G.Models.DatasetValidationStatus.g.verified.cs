//HintName: G.Models.DatasetValidationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The validation status of the dataset
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetValidationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validated")]
        Validated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
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
                DatasetValidationStatus.Unknown => "unknown",
                DatasetValidationStatus.Queued => "queued",
                DatasetValidationStatus.Processing => "processing",
                DatasetValidationStatus.Failed => "failed",
                DatasetValidationStatus.Validated => "validated",
                DatasetValidationStatus.Skipped => "skipped",
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
                "unknown" => DatasetValidationStatus.Unknown,
                "queued" => DatasetValidationStatus.Queued,
                "processing" => DatasetValidationStatus.Processing,
                "failed" => DatasetValidationStatus.Failed,
                "validated" => DatasetValidationStatus.Validated,
                "skipped" => DatasetValidationStatus.Skipped,
                _ => null,
            };
        }
    }
}