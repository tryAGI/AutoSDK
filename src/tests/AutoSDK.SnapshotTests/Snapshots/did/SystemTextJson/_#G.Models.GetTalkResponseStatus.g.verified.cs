//HintName: G.Models.GetTalkResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    public enum GetTalkResponseStatus
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
    public static class GetTalkResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkResponseStatus value)
        {
            return value switch
            {
                GetTalkResponseStatus.Created => "created",
                GetTalkResponseStatus.Done => "done",
                GetTalkResponseStatus.Error => "error",
                GetTalkResponseStatus.Rejected => "rejected",
                GetTalkResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTalkResponseStatus.Created,
                "done" => GetTalkResponseStatus.Done,
                "error" => GetTalkResponseStatus.Error,
                "rejected" => GetTalkResponseStatus.Rejected,
                "started" => GetTalkResponseStatus.Started,
                _ => null,
            };
        }
    }
}