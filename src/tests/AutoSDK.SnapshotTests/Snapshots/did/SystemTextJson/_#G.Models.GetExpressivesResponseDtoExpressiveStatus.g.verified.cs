//HintName: G.Models.GetExpressivesResponseDtoExpressiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExpressivesResponseDtoExpressiveStatus
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
    public static class GetExpressivesResponseDtoExpressiveStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressivesResponseDtoExpressiveStatus value)
        {
            return value switch
            {
                GetExpressivesResponseDtoExpressiveStatus.Created => "created",
                GetExpressivesResponseDtoExpressiveStatus.Done => "done",
                GetExpressivesResponseDtoExpressiveStatus.Error => "error",
                GetExpressivesResponseDtoExpressiveStatus.Rejected => "rejected",
                GetExpressivesResponseDtoExpressiveStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressivesResponseDtoExpressiveStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetExpressivesResponseDtoExpressiveStatus.Created,
                "done" => GetExpressivesResponseDtoExpressiveStatus.Done,
                "error" => GetExpressivesResponseDtoExpressiveStatus.Error,
                "rejected" => GetExpressivesResponseDtoExpressiveStatus.Rejected,
                "started" => GetExpressivesResponseDtoExpressiveStatus.Started,
                _ => null,
            };
        }
    }
}