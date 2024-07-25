//HintName: G.Models.TenantUsageLimitInfoUsageLimitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TenantUsageLimitInfoUsageLimitType
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
    public static class TenantUsageLimitInfoUsageLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantUsageLimitInfoUsageLimitType value)
        {
            return value switch
            {
                TenantUsageLimitInfoUsageLimitType.PayloadSize => "payload_size",
                TenantUsageLimitInfoUsageLimitType.EventsIngestedPerHour => "events_ingested_per_hour",
                TenantUsageLimitInfoUsageLimitType.TotalUniqueTraces => "total_unique_traces",
                TenantUsageLimitInfoUsageLimitType.EventsIngestedPerMinute => "events_ingested_per_minute",
                TenantUsageLimitInfoUsageLimitType.UserDefinedMonthlyTraces => "user_defined_monthly_traces",
                TenantUsageLimitInfoUsageLimitType.UserDefinedMonthlyLonglivedTraces => "user_defined_monthly_longlived_traces",
                TenantUsageLimitInfoUsageLimitType.UserDefinedUnknown => "user_defined_unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantUsageLimitInfoUsageLimitType? ToEnum(string value)
        {
            return value switch
            {
                "payload_size" => TenantUsageLimitInfoUsageLimitType.PayloadSize,
                "events_ingested_per_hour" => TenantUsageLimitInfoUsageLimitType.EventsIngestedPerHour,
                "total_unique_traces" => TenantUsageLimitInfoUsageLimitType.TotalUniqueTraces,
                "events_ingested_per_minute" => TenantUsageLimitInfoUsageLimitType.EventsIngestedPerMinute,
                "user_defined_monthly_traces" => TenantUsageLimitInfoUsageLimitType.UserDefinedMonthlyTraces,
                "user_defined_monthly_longlived_traces" => TenantUsageLimitInfoUsageLimitType.UserDefinedMonthlyLonglivedTraces,
                "user_defined_unknown" => TenantUsageLimitInfoUsageLimitType.UserDefinedUnknown,
                _ => null,
            };
        }
    }
}