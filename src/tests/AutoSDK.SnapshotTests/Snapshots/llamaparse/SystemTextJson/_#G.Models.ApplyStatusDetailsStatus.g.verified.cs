//HintName: G.Models.ApplyStatusDetailsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the apply process (file updates and deletions)<br/>
    /// Default Value: pending
    /// </summary>
    public enum ApplyStatusDetailsStatus
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
    public static class ApplyStatusDetailsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyStatusDetailsStatus value)
        {
            return value switch
            {
                ApplyStatusDetailsStatus.Completed => "completed",
                ApplyStatusDetailsStatus.Failed => "failed",
                ApplyStatusDetailsStatus.Pending => "pending",
                ApplyStatusDetailsStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyStatusDetailsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ApplyStatusDetailsStatus.Completed,
                "failed" => ApplyStatusDetailsStatus.Failed,
                "pending" => ApplyStatusDetailsStatus.Pending,
                "processing" => ApplyStatusDetailsStatus.Processing,
                _ => null,
            };
        }
    }
}