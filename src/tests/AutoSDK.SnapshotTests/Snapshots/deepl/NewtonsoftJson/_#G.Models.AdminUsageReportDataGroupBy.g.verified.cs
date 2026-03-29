//HintName: G.Models.AdminUsageReportDataGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The grouping method used, if any.<br/>
    /// Example: key_and_day
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AdminUsageReportDataGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key")]
        Key,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key_and_day")]
        KeyAndDay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminUsageReportDataGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminUsageReportDataGroupBy value)
        {
            return value switch
            {
                AdminUsageReportDataGroupBy.Key => "key",
                AdminUsageReportDataGroupBy.KeyAndDay => "key_and_day",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminUsageReportDataGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "key" => AdminUsageReportDataGroupBy.Key,
                "key_and_day" => AdminUsageReportDataGroupBy.KeyAndDay,
                _ => null,
            };
        }
    }
}