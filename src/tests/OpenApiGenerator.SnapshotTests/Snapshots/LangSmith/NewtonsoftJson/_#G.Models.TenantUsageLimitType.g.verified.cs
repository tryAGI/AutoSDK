//HintName: G.Models.TenantUsageLimitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TenantUsageLimitType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="payload_size")]
        PayloadSize,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="events_ingested_per_hour")]
        EventsIngestedPerHour,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="total_unique_traces")]
        TotalUniqueTraces,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="events_ingested_per_minute")]
        EventsIngestedPerMinute,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_defined_monthly_traces")]
        UserDefinedMonthlyTraces,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_defined_monthly_longlived_traces")]
        UserDefinedMonthlyLonglivedTraces,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_defined_unknown")]
        UserDefinedUnknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TenantUsageLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantUsageLimitType value)
        {
            return value switch
            {
                TenantUsageLimitType.PayloadSize => "payload_size",
                TenantUsageLimitType.EventsIngestedPerHour => "events_ingested_per_hour",
                TenantUsageLimitType.TotalUniqueTraces => "total_unique_traces",
                TenantUsageLimitType.EventsIngestedPerMinute => "events_ingested_per_minute",
                TenantUsageLimitType.UserDefinedMonthlyTraces => "user_defined_monthly_traces",
                TenantUsageLimitType.UserDefinedMonthlyLonglivedTraces => "user_defined_monthly_longlived_traces",
                TenantUsageLimitType.UserDefinedUnknown => "user_defined_unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantUsageLimitType? ToEnum(string value)
        {
            return value switch
            {
                "payload_size" => TenantUsageLimitType.PayloadSize,
                "events_ingested_per_hour" => TenantUsageLimitType.EventsIngestedPerHour,
                "total_unique_traces" => TenantUsageLimitType.TotalUniqueTraces,
                "events_ingested_per_minute" => TenantUsageLimitType.EventsIngestedPerMinute,
                "user_defined_monthly_traces" => TenantUsageLimitType.UserDefinedMonthlyTraces,
                "user_defined_monthly_longlived_traces" => TenantUsageLimitType.UserDefinedMonthlyLonglivedTraces,
                "user_defined_unknown" => TenantUsageLimitType.UserDefinedUnknown,
                _ => null,
            };
        }
    }
}