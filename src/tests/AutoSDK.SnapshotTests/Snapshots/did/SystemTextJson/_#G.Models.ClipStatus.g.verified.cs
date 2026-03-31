//HintName: G.Models.ClipStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClipStatus
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
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipStatus value)
        {
            return value switch
            {
                ClipStatus.Created => "created",
                ClipStatus.Done => "done",
                ClipStatus.Error => "error",
                ClipStatus.Rejected => "rejected",
                ClipStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ClipStatus.Created,
                "done" => ClipStatus.Done,
                "error" => ClipStatus.Error,
                "rejected" => ClipStatus.Rejected,
                "started" => ClipStatus.Started,
                _ => null,
            };
        }
    }
}