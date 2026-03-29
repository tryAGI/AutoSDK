//HintName: G.Models.CreateTalkResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkResponseDtoStatus
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
    public static class CreateTalkResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkResponseDtoStatus value)
        {
            return value switch
            {
                CreateTalkResponseDtoStatus.Created => "created",
                CreateTalkResponseDtoStatus.Done => "done",
                CreateTalkResponseDtoStatus.Error => "error",
                CreateTalkResponseDtoStatus.Rejected => "rejected",
                CreateTalkResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateTalkResponseDtoStatus.Created,
                "done" => CreateTalkResponseDtoStatus.Done,
                "error" => CreateTalkResponseDtoStatus.Error,
                "rejected" => CreateTalkResponseDtoStatus.Rejected,
                "started" => CreateTalkResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}