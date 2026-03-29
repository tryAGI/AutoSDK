//HintName: G.Models.GetTalkDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalkDtoStatus
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
    public static class GetTalkDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkDtoStatus value)
        {
            return value switch
            {
                GetTalkDtoStatus.Created => "created",
                GetTalkDtoStatus.Done => "done",
                GetTalkDtoStatus.Error => "error",
                GetTalkDtoStatus.Rejected => "rejected",
                GetTalkDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTalkDtoStatus.Created,
                "done" => GetTalkDtoStatus.Done,
                "error" => GetTalkDtoStatus.Error,
                "rejected" => GetTalkDtoStatus.Rejected,
                "started" => GetTalkDtoStatus.Started,
                _ => null,
            };
        }
    }
}