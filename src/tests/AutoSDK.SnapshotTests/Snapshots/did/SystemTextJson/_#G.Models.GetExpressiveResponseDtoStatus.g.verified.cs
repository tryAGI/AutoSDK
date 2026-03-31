//HintName: G.Models.GetExpressiveResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExpressiveResponseDtoStatus
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
    public static class GetExpressiveResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveResponseDtoStatus value)
        {
            return value switch
            {
                GetExpressiveResponseDtoStatus.Created => "created",
                GetExpressiveResponseDtoStatus.Done => "done",
                GetExpressiveResponseDtoStatus.Error => "error",
                GetExpressiveResponseDtoStatus.Rejected => "rejected",
                GetExpressiveResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetExpressiveResponseDtoStatus.Created,
                "done" => GetExpressiveResponseDtoStatus.Done,
                "error" => GetExpressiveResponseDtoStatus.Error,
                "rejected" => GetExpressiveResponseDtoStatus.Rejected,
                "started" => GetExpressiveResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}