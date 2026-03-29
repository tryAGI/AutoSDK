//HintName: G.Models.CreateClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipResponseStatus
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
    public static class CreateClipResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipResponseStatus value)
        {
            return value switch
            {
                CreateClipResponseStatus.Created => "created",
                CreateClipResponseStatus.Done => "done",
                CreateClipResponseStatus.Error => "error",
                CreateClipResponseStatus.Rejected => "rejected",
                CreateClipResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateClipResponseStatus.Created,
                "done" => CreateClipResponseStatus.Done,
                "error" => CreateClipResponseStatus.Error,
                "rejected" => CreateClipResponseStatus.Rejected,
                "started" => CreateClipResponseStatus.Started,
                _ => null,
            };
        }
    }
}