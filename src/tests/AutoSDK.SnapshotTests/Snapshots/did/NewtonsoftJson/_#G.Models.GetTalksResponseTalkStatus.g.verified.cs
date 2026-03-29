//HintName: G.Models.GetTalksResponseTalkStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalksResponseTalkStatus
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
    public static class GetTalksResponseTalkStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalksResponseTalkStatus value)
        {
            return value switch
            {
                GetTalksResponseTalkStatus.Created => "created",
                GetTalksResponseTalkStatus.Done => "done",
                GetTalksResponseTalkStatus.Error => "error",
                GetTalksResponseTalkStatus.Rejected => "rejected",
                GetTalksResponseTalkStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalksResponseTalkStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTalksResponseTalkStatus.Created,
                "done" => GetTalksResponseTalkStatus.Done,
                "error" => GetTalksResponseTalkStatus.Error,
                "rejected" => GetTalksResponseTalkStatus.Rejected,
                "started" => GetTalksResponseTalkStatus.Started,
                _ => null,
            };
        }
    }
}