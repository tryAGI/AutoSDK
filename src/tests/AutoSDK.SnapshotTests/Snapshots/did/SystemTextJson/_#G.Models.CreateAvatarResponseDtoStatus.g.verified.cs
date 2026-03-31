//HintName: G.Models.CreateAvatarResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    public enum CreateAvatarResponseDtoStatus
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
    public static class CreateAvatarResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarResponseDtoStatus value)
        {
            return value switch
            {
                CreateAvatarResponseDtoStatus.Created => "created",
                CreateAvatarResponseDtoStatus.Done => "done",
                CreateAvatarResponseDtoStatus.Draft => "draft",
                CreateAvatarResponseDtoStatus.Error => "error",
                CreateAvatarResponseDtoStatus.Rejected => "rejected",
                CreateAvatarResponseDtoStatus.Started => "started",
                CreateAvatarResponseDtoStatus.TrainingStarted => "training-started",
                CreateAvatarResponseDtoStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateAvatarResponseDtoStatus.Created,
                "done" => CreateAvatarResponseDtoStatus.Done,
                "draft" => CreateAvatarResponseDtoStatus.Draft,
                "error" => CreateAvatarResponseDtoStatus.Error,
                "rejected" => CreateAvatarResponseDtoStatus.Rejected,
                "started" => CreateAvatarResponseDtoStatus.Started,
                "training-started" => CreateAvatarResponseDtoStatus.TrainingStarted,
                "validating" => CreateAvatarResponseDtoStatus.Validating,
                _ => null,
            };
        }
    }
}