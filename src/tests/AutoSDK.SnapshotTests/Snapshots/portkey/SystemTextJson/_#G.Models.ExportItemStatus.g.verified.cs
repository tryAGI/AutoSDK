//HintName: G.Models.ExportItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportItemStatus value)
        {
            return value switch
            {
                ExportItemStatus.Draft => "draft",
                ExportItemStatus.Failed => "failed",
                ExportItemStatus.InProgress => "in_progress",
                ExportItemStatus.Stopped => "stopped",
                ExportItemStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ExportItemStatus.Draft,
                "failed" => ExportItemStatus.Failed,
                "in_progress" => ExportItemStatus.InProgress,
                "stopped" => ExportItemStatus.Stopped,
                "success" => ExportItemStatus.Success,
                _ => null,
            };
        }
    }
}