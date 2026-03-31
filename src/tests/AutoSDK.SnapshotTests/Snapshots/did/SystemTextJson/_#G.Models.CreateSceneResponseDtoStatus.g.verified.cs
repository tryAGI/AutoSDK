//HintName: G.Models.CreateSceneResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the scene
    /// </summary>
    public enum CreateSceneResponseDtoStatus
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
    public static class CreateSceneResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneResponseDtoStatus value)
        {
            return value switch
            {
                CreateSceneResponseDtoStatus.Created => "created",
                CreateSceneResponseDtoStatus.Done => "done",
                CreateSceneResponseDtoStatus.Error => "error",
                CreateSceneResponseDtoStatus.Rejected => "rejected",
                CreateSceneResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateSceneResponseDtoStatus.Created,
                "done" => CreateSceneResponseDtoStatus.Done,
                "error" => CreateSceneResponseDtoStatus.Error,
                "rejected" => CreateSceneResponseDtoStatus.Rejected,
                "started" => CreateSceneResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}