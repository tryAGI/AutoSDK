//HintName: G.Models.GetAvatarsResponseDtoAvatarStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    public enum GetAvatarsResponseDtoAvatarStatus
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
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        TrainingStarted,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarsResponseDtoAvatarStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDtoAvatarStatus value)
        {
            return value switch
            {
                GetAvatarsResponseDtoAvatarStatus.Created => "created",
                GetAvatarsResponseDtoAvatarStatus.Done => "done",
                GetAvatarsResponseDtoAvatarStatus.Draft => "draft",
                GetAvatarsResponseDtoAvatarStatus.Error => "error",
                GetAvatarsResponseDtoAvatarStatus.Rejected => "rejected",
                GetAvatarsResponseDtoAvatarStatus.Started => "started",
                GetAvatarsResponseDtoAvatarStatus.TrainingStarted => "training-started",
                GetAvatarsResponseDtoAvatarStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDtoAvatarStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAvatarsResponseDtoAvatarStatus.Created,
                "done" => GetAvatarsResponseDtoAvatarStatus.Done,
                "draft" => GetAvatarsResponseDtoAvatarStatus.Draft,
                "error" => GetAvatarsResponseDtoAvatarStatus.Error,
                "rejected" => GetAvatarsResponseDtoAvatarStatus.Rejected,
                "started" => GetAvatarsResponseDtoAvatarStatus.Started,
                "training-started" => GetAvatarsResponseDtoAvatarStatus.TrainingStarted,
                "validating" => GetAvatarsResponseDtoAvatarStatus.Validating,
                _ => null,
            };
        }
    }
}