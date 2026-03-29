//HintName: G.Models.GetSceneResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetSceneResponseDtoStatus
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
    public static class GetSceneResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSceneResponseDtoStatus value)
        {
            return value switch
            {
                GetSceneResponseDtoStatus.Created => "created",
                GetSceneResponseDtoStatus.Done => "done",
                GetSceneResponseDtoStatus.Error => "error",
                GetSceneResponseDtoStatus.Rejected => "rejected",
                GetSceneResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSceneResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetSceneResponseDtoStatus.Created,
                "done" => GetSceneResponseDtoStatus.Done,
                "error" => GetSceneResponseDtoStatus.Error,
                "rejected" => GetSceneResponseDtoStatus.Rejected,
                "started" => GetSceneResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}