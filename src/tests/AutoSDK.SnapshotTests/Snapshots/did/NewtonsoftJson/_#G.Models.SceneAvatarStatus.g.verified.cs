//HintName: G.Models.SceneAvatarStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SceneAvatarStatus
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
    public static class SceneAvatarStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SceneAvatarStatus value)
        {
            return value switch
            {
                SceneAvatarStatus.Created => "created",
                SceneAvatarStatus.Done => "done",
                SceneAvatarStatus.Draft => "draft",
                SceneAvatarStatus.Error => "error",
                SceneAvatarStatus.Rejected => "rejected",
                SceneAvatarStatus.Started => "started",
                SceneAvatarStatus.TrainingStarted => "training-started",
                SceneAvatarStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SceneAvatarStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => SceneAvatarStatus.Created,
                "done" => SceneAvatarStatus.Done,
                "draft" => SceneAvatarStatus.Draft,
                "error" => SceneAvatarStatus.Error,
                "rejected" => SceneAvatarStatus.Rejected,
                "started" => SceneAvatarStatus.Started,
                "training-started" => SceneAvatarStatus.TrainingStarted,
                "validating" => SceneAvatarStatus.Validating,
                _ => null,
            };
        }
    }
}