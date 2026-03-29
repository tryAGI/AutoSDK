//HintName: G.Models.GetTalksDtoTalkStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalksDtoTalkStatus
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
    public static class GetTalksDtoTalkStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalksDtoTalkStatus value)
        {
            return value switch
            {
                GetTalksDtoTalkStatus.Created => "created",
                GetTalksDtoTalkStatus.Done => "done",
                GetTalksDtoTalkStatus.Error => "error",
                GetTalksDtoTalkStatus.Rejected => "rejected",
                GetTalksDtoTalkStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalksDtoTalkStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTalksDtoTalkStatus.Created,
                "done" => GetTalksDtoTalkStatus.Done,
                "error" => GetTalksDtoTalkStatus.Error,
                "rejected" => GetTalksDtoTalkStatus.Rejected,
                "started" => GetTalksDtoTalkStatus.Started,
                _ => null,
            };
        }
    }
}