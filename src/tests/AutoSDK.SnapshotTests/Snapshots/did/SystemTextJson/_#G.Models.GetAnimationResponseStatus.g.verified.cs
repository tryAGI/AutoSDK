//HintName: G.Models.GetAnimationResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    public enum GetAnimationResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnimationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationResponseStatus value)
        {
            return value switch
            {
                GetAnimationResponseStatus.Created => "created",
                GetAnimationResponseStatus.Done => "done",
                GetAnimationResponseStatus.Error => "error",
                GetAnimationResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAnimationResponseStatus.Created,
                "done" => GetAnimationResponseStatus.Done,
                "error" => GetAnimationResponseStatus.Error,
                "started" => GetAnimationResponseStatus.Started,
                _ => null,
            };
        }
    }
}