//HintName: G.Models.TenantUsageLimitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TenantUsageLimitType
    {
        /// <summary>
        /// 
        /// </summary>
        EventsIngestedPerHour,
        /// <summary>
        /// 
        /// </summary>
        EventsIngestedPerMinute,
        /// <summary>
        /// 
        /// </summary>
        PayloadSize,
        /// <summary>
        /// 
        /// </summary>
        TotalUniqueTraces,
        /// <summary>
        /// 
        /// </summary>
        UserDefinedMonthlyLonglivedTraces,
        /// <summary>
        /// 
        /// </summary>
        UserDefinedMonthlyTraces,
        /// <summary>
        /// 
        /// </summary>
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
                TenantUsageLimitType.EventsIngestedPerHour => "events_ingested_per_hour",
                TenantUsageLimitType.EventsIngestedPerMinute => "events_ingested_per_minute",
                TenantUsageLimitType.PayloadSize => "payload_size",
                TenantUsageLimitType.TotalUniqueTraces => "total_unique_traces",
                TenantUsageLimitType.UserDefinedMonthlyLonglivedTraces => "user_defined_monthly_longlived_traces",
                TenantUsageLimitType.UserDefinedMonthlyTraces => "user_defined_monthly_traces",
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
                "events_ingested_per_hour" => TenantUsageLimitType.EventsIngestedPerHour,
                "events_ingested_per_minute" => TenantUsageLimitType.EventsIngestedPerMinute,
                "payload_size" => TenantUsageLimitType.PayloadSize,
                "total_unique_traces" => TenantUsageLimitType.TotalUniqueTraces,
                "user_defined_monthly_longlived_traces" => TenantUsageLimitType.UserDefinedMonthlyLonglivedTraces,
                "user_defined_monthly_traces" => TenantUsageLimitType.UserDefinedMonthlyTraces,
                "user_defined_unknown" => TenantUsageLimitType.UserDefinedUnknown,
                _ => null,
            };
        }
    }
}