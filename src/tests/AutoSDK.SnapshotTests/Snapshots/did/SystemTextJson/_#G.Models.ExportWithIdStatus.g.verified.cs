//HintName: G.Models.ExportWithIdStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates full partial or failed export
    /// </summary>
    public enum ExportWithIdStatus
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
    public static class ExportWithIdStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportWithIdStatus value)
        {
            return value switch
            {
                ExportWithIdStatus.Created => "created",
                ExportWithIdStatus.Done => "done",
                ExportWithIdStatus.Error => "error",
                ExportWithIdStatus.Partial => "partial",
                ExportWithIdStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportWithIdStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ExportWithIdStatus.Created,
                "done" => ExportWithIdStatus.Done,
                "error" => ExportWithIdStatus.Error,
                "partial" => ExportWithIdStatus.Partial,
                "started" => ExportWithIdStatus.Started,
                _ => null,
            };
        }
    }
}