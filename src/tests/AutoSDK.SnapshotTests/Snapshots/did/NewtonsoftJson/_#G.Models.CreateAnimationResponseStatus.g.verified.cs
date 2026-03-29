//HintName: G.Models.CreateAnimationResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnimationResponseStatus
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
    public static class CreateAnimationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnimationResponseStatus value)
        {
            return value switch
            {
                CreateAnimationResponseStatus.Created => "created",
                CreateAnimationResponseStatus.Done => "done",
                CreateAnimationResponseStatus.Error => "error",
                CreateAnimationResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnimationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateAnimationResponseStatus.Created,
                "done" => CreateAnimationResponseStatus.Done,
                "error" => CreateAnimationResponseStatus.Error,
                "started" => CreateAnimationResponseStatus.Started,
                _ => null,
            };
        }
    }
}