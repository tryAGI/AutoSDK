//HintName: G.Models.StatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for representing the status of a job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARTIAL_SUCCESS")]
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusEnum value)
        {
            return value switch
            {
                StatusEnum.Cancelled => "CANCELLED",
                StatusEnum.Error => "ERROR",
                StatusEnum.PartialSuccess => "PARTIAL_SUCCESS",
                StatusEnum.Pending => "PENDING",
                StatusEnum.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => StatusEnum.Cancelled,
                "ERROR" => StatusEnum.Error,
                "PARTIAL_SUCCESS" => StatusEnum.PartialSuccess,
                "PENDING" => StatusEnum.Pending,
                "SUCCESS" => StatusEnum.Success,
                _ => null,
            };
        }
    }
}