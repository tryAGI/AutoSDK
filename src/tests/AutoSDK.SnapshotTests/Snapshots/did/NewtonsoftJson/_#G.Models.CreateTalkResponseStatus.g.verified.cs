//HintName: G.Models.CreateTalkResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkResponseStatus
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
    public static class CreateTalkResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkResponseStatus value)
        {
            return value switch
            {
                CreateTalkResponseStatus.Created => "created",
                CreateTalkResponseStatus.Done => "done",
                CreateTalkResponseStatus.Error => "error",
                CreateTalkResponseStatus.Rejected => "rejected",
                CreateTalkResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateTalkResponseStatus.Created,
                "done" => CreateTalkResponseStatus.Done,
                "error" => CreateTalkResponseStatus.Error,
                "rejected" => CreateTalkResponseStatus.Rejected,
                "started" => CreateTalkResponseStatus.Started,
                _ => null,
            };
        }
    }
}