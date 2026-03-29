//HintName: G.Models.DeleteAnimationResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteAnimationResponseStatus
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
    public static class DeleteAnimationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAnimationResponseStatus value)
        {
            return value switch
            {
                DeleteAnimationResponseStatus.Created => "created",
                DeleteAnimationResponseStatus.Done => "done",
                DeleteAnimationResponseStatus.Error => "error",
                DeleteAnimationResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAnimationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => DeleteAnimationResponseStatus.Created,
                "done" => DeleteAnimationResponseStatus.Done,
                "error" => DeleteAnimationResponseStatus.Error,
                "started" => DeleteAnimationResponseStatus.Started,
                _ => null,
            };
        }
    }
}