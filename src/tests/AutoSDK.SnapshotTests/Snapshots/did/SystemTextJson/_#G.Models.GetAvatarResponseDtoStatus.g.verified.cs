//HintName: G.Models.GetAvatarResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    public enum GetAvatarResponseDtoStatus
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
    public static class GetAvatarResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarResponseDtoStatus value)
        {
            return value switch
            {
                GetAvatarResponseDtoStatus.Created => "created",
                GetAvatarResponseDtoStatus.Done => "done",
                GetAvatarResponseDtoStatus.Draft => "draft",
                GetAvatarResponseDtoStatus.Error => "error",
                GetAvatarResponseDtoStatus.Rejected => "rejected",
                GetAvatarResponseDtoStatus.Started => "started",
                GetAvatarResponseDtoStatus.TrainingStarted => "training-started",
                GetAvatarResponseDtoStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAvatarResponseDtoStatus.Created,
                "done" => GetAvatarResponseDtoStatus.Done,
                "draft" => GetAvatarResponseDtoStatus.Draft,
                "error" => GetAvatarResponseDtoStatus.Error,
                "rejected" => GetAvatarResponseDtoStatus.Rejected,
                "started" => GetAvatarResponseDtoStatus.Started,
                "training-started" => GetAvatarResponseDtoStatus.TrainingStarted,
                "validating" => GetAvatarResponseDtoStatus.Validating,
                _ => null,
            };
        }
    }
}