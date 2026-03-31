//HintName: G.Models.GetTalkDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    public enum GetTalkDtoStatus
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
    public static class GetTalkDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkDtoStatus value)
        {
            return value switch
            {
                GetTalkDtoStatus.Created => "created",
                GetTalkDtoStatus.Done => "done",
                GetTalkDtoStatus.Error => "error",
                GetTalkDtoStatus.Rejected => "rejected",
                GetTalkDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTalkDtoStatus.Created,
                "done" => GetTalkDtoStatus.Done,
                "error" => GetTalkDtoStatus.Error,
                "rejected" => GetTalkDtoStatus.Rejected,
                "started" => GetTalkDtoStatus.Started,
                _ => null,
            };
        }
    }
}