//HintName: G.Models.GetAnimationResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnimationResponseDtoStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnimationResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationResponseDtoStatus value)
        {
            return value switch
            {
                GetAnimationResponseDtoStatus.Created => "created",
                GetAnimationResponseDtoStatus.Done => "done",
                GetAnimationResponseDtoStatus.Error => "error",
                GetAnimationResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAnimationResponseDtoStatus.Created,
                "done" => GetAnimationResponseDtoStatus.Done,
                "error" => GetAnimationResponseDtoStatus.Error,
                "started" => GetAnimationResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}