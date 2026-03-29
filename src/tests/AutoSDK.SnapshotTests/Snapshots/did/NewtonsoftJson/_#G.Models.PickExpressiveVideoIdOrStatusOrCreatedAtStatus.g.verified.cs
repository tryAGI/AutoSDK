//HintName: G.Models.PickExpressiveVideoIdOrStatusOrCreatedAtStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickExpressiveVideoIdOrStatusOrCreatedAtStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
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