//HintName: G.Models.GetAvatarsResponseAvatarStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    public enum GetAvatarsResponseAvatarStatus
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
    public static class GetAvatarsResponseAvatarStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarStatus value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarStatus.Created => "created",
                GetAvatarsResponseAvatarStatus.Done => "done",
                GetAvatarsResponseAvatarStatus.Draft => "draft",
                GetAvatarsResponseAvatarStatus.Error => "error",
                GetAvatarsResponseAvatarStatus.Rejected => "rejected",
                GetAvatarsResponseAvatarStatus.Started => "started",
                GetAvatarsResponseAvatarStatus.TrainingStarted => "training-started",
                GetAvatarsResponseAvatarStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetAvatarsResponseAvatarStatus.Created,
                "done" => GetAvatarsResponseAvatarStatus.Done,
                "draft" => GetAvatarsResponseAvatarStatus.Draft,
                "error" => GetAvatarsResponseAvatarStatus.Error,
                "rejected" => GetAvatarsResponseAvatarStatus.Rejected,
                "started" => GetAvatarsResponseAvatarStatus.Started,
                "training-started" => GetAvatarsResponseAvatarStatus.TrainingStarted,
                "validating" => GetAvatarsResponseAvatarStatus.Validating,
                _ => null,
            };
        }
    }
}