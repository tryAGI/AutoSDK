//HintName: G.Models.GetScenesResponseSceneStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetScenesResponseSceneStatus
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
    public static class GetScenesResponseSceneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScenesResponseSceneStatus value)
        {
            return value switch
            {
                GetScenesResponseSceneStatus.Created => "created",
                GetScenesResponseSceneStatus.Done => "done",
                GetScenesResponseSceneStatus.Error => "error",
                GetScenesResponseSceneStatus.Rejected => "rejected",
                GetScenesResponseSceneStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScenesResponseSceneStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetScenesResponseSceneStatus.Created,
                "done" => GetScenesResponseSceneStatus.Done,
                "error" => GetScenesResponseSceneStatus.Error,
                "rejected" => GetScenesResponseSceneStatus.Rejected,
                "started" => GetScenesResponseSceneStatus.Started,
                _ => null,
            };
        }
    }
}