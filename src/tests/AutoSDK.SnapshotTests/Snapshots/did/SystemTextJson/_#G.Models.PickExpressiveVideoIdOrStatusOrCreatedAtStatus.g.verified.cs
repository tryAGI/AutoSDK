//HintName: G.Models.PickExpressiveVideoIdOrStatusOrCreatedAtStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PickExpressiveVideoIdOrStatusOrCreatedAtStatus
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
    public static class PickExpressiveVideoIdOrStatusOrCreatedAtStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveVideoIdOrStatusOrCreatedAtStatus value)
        {
            return value switch
            {
                PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Created => "created",
                PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Done => "done",
                PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Error => "error",
                PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Rejected => "rejected",
                PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveVideoIdOrStatusOrCreatedAtStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Created,
                "done" => PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Done,
                "error" => PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Error,
                "rejected" => PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Rejected,
                "started" => PickExpressiveVideoIdOrStatusOrCreatedAtStatus.Started,
                _ => null,
            };
        }
    }
}