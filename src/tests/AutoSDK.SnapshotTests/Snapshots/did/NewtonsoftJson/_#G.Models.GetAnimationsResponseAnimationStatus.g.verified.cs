//HintName: G.Models.GetAnimationsResponseAnimationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the animation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnimationsResponseAnimationStatus
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
    public static class GetAnimationsResponseAnimationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationsResponseAnimationStatus value)
        {
            return value switch
            {
                GetAnimationsResponseAnimationStatus.Created => "created",
                GetAnimationsResponseAnimationStatus.Done => "done",
                GetAnimationsResponseAnimationStatus.Error => "error",
                GetAnimationsResponseAnimationStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationsResponseAnimationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAnimationsResponseAnimationStatus.Created,
                "done" => GetAnimationsResponseAnimationStatus.Done,
                "error" => GetAnimationsResponseAnimationStatus.Error,
                "started" => GetAnimationsResponseAnimationStatus.Started,
                _ => null,
            };
        }
    }
}