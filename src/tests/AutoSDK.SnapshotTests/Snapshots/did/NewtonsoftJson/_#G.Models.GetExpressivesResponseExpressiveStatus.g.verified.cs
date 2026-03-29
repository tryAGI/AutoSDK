//HintName: G.Models.GetExpressivesResponseExpressiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressivesResponseExpressiveStatus
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