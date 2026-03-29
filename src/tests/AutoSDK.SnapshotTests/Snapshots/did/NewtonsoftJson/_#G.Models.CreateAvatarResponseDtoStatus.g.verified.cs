//HintName: G.Models.CreateAvatarResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAvatarResponseDtoStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training-started")]
        TrainingStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
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