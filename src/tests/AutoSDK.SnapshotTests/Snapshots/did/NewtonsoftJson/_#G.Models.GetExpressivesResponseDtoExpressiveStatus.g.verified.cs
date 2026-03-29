//HintName: G.Models.GetExpressivesResponseDtoExpressiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressivesResponseDtoExpressiveStatus
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