//HintName: G.Models.AnimationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnimationStatus
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
    public static class AnimationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationStatus value)
        {
            return value switch
            {
                AnimationStatus.Created => "created",
                AnimationStatus.Done => "done",
                AnimationStatus.Error => "error",
                AnimationStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => AnimationStatus.Created,
                "done" => AnimationStatus.Done,
                "error" => AnimationStatus.Error,
                "started" => AnimationStatus.Started,
                _ => null,
            };
        }
    }
}