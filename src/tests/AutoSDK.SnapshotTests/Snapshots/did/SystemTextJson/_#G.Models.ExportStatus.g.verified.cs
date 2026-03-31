//HintName: G.Models.ExportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Partial,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportStatus value)
        {
            return value switch
            {
                ExportStatus.Created => "created",
                ExportStatus.Done => "done",
                ExportStatus.Error => "error",
                ExportStatus.Partial => "partial",
                ExportStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ExportStatus.Created,
                "done" => ExportStatus.Done,
                "error" => ExportStatus.Error,
                "partial" => ExportStatus.Partial,
                "started" => ExportStatus.Started,
                _ => null,
            };
        }
    }
}