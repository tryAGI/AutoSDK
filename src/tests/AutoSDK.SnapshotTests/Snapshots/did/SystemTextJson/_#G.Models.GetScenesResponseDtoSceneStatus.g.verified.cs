//HintName: G.Models.GetScenesResponseDtoSceneStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScenesResponseDtoSceneStatus
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
    public static class GetScenesResponseDtoSceneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScenesResponseDtoSceneStatus value)
        {
            return value switch
            {
                GetScenesResponseDtoSceneStatus.Created => "created",
                GetScenesResponseDtoSceneStatus.Done => "done",
                GetScenesResponseDtoSceneStatus.Error => "error",
                GetScenesResponseDtoSceneStatus.Rejected => "rejected",
                GetScenesResponseDtoSceneStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScenesResponseDtoSceneStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetScenesResponseDtoSceneStatus.Created,
                "done" => GetScenesResponseDtoSceneStatus.Done,
                "error" => GetScenesResponseDtoSceneStatus.Error,
                "rejected" => GetScenesResponseDtoSceneStatus.Rejected,
                "started" => GetScenesResponseDtoSceneStatus.Started,
                _ => null,
            };
        }
    }
}