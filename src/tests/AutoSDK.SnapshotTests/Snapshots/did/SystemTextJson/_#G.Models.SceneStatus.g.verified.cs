//HintName: G.Models.SceneStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SceneStatus
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
        Rejected,
        /// <summary>
        /// 
        /// </summary>
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