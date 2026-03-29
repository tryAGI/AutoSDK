//HintName: G.Models.SceneStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SceneStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SceneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SceneStatus value)
        {
            return value switch
            {
                SceneStatus.Created => "created",
                SceneStatus.Done => "done",
                SceneStatus.Error => "error",
                SceneStatus.Rejected => "rejected",
                SceneStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SceneStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => SceneStatus.Created,
                "done" => SceneStatus.Done,
                "error" => SceneStatus.Error,
                "rejected" => SceneStatus.Rejected,
                "started" => SceneStatus.Started,
                _ => null,
            };
        }
    }
}