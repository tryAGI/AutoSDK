//HintName: G.Models.TalkStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TalkStatus
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
    public static class TalkStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalkStatus value)
        {
            return value switch
            {
                TalkStatus.Created => "created",
                TalkStatus.Done => "done",
                TalkStatus.Error => "error",
                TalkStatus.Rejected => "rejected",
                TalkStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalkStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => TalkStatus.Created,
                "done" => TalkStatus.Done,
                "error" => TalkStatus.Error,
                "rejected" => TalkStatus.Rejected,
                "started" => TalkStatus.Started,
                _ => null,
            };
        }
    }
}