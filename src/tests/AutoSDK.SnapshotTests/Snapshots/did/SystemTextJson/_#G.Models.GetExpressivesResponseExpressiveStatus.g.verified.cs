//HintName: G.Models.GetExpressivesResponseExpressiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExpressivesResponseExpressiveStatus
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
    public static class GetExpressivesResponseExpressiveStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressivesResponseExpressiveStatus value)
        {
            return value switch
            {
                GetExpressivesResponseExpressiveStatus.Created => "created",
                GetExpressivesResponseExpressiveStatus.Done => "done",
                GetExpressivesResponseExpressiveStatus.Error => "error",
                GetExpressivesResponseExpressiveStatus.Rejected => "rejected",
                GetExpressivesResponseExpressiveStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressivesResponseExpressiveStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetExpressivesResponseExpressiveStatus.Created,
                "done" => GetExpressivesResponseExpressiveStatus.Done,
                "error" => GetExpressivesResponseExpressiveStatus.Error,
                "rejected" => GetExpressivesResponseExpressiveStatus.Rejected,
                "started" => GetExpressivesResponseExpressiveStatus.Started,
                _ => null,
            };
        }
    }
}