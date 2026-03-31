//HintName: G.Models.GetAnimationsResponseDtoAnimationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    public enum GetAnimationsResponseDtoAnimationStatus
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
    public static class GetAnimationsResponseDtoAnimationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationsResponseDtoAnimationStatus value)
        {
            return value switch
            {
                GetAnimationsResponseDtoAnimationStatus.Created => "created",
                GetAnimationsResponseDtoAnimationStatus.Done => "done",
                GetAnimationsResponseDtoAnimationStatus.Error => "error",
                GetAnimationsResponseDtoAnimationStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationsResponseDtoAnimationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAnimationsResponseDtoAnimationStatus.Created,
                "done" => GetAnimationsResponseDtoAnimationStatus.Done,
                "error" => GetAnimationsResponseDtoAnimationStatus.Error,
                "started" => GetAnimationsResponseDtoAnimationStatus.Started,
                _ => null,
            };
        }
    }
}