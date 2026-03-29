//HintName: G.Models.CreateAnimationResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnimationResponseDtoStatus
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
    public static class CreateAnimationResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnimationResponseDtoStatus value)
        {
            return value switch
            {
                CreateAnimationResponseDtoStatus.Created => "created",
                CreateAnimationResponseDtoStatus.Done => "done",
                CreateAnimationResponseDtoStatus.Error => "error",
                CreateAnimationResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnimationResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateAnimationResponseDtoStatus.Created,
                "done" => CreateAnimationResponseDtoStatus.Done,
                "error" => CreateAnimationResponseDtoStatus.Error,
                "started" => CreateAnimationResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}