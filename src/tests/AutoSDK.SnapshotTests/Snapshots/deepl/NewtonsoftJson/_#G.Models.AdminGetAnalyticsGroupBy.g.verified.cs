//HintName: G.Models.AdminGetAnalyticsGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AdminGetAnalyticsGroupBy
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
    public static class AdminGetAnalyticsGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminGetAnalyticsGroupBy value)
        {
            return value switch
            {
                AdminGetAnalyticsGroupBy.Key => "key",
                AdminGetAnalyticsGroupBy.KeyAndDay => "key_and_day",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminGetAnalyticsGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "key" => AdminGetAnalyticsGroupBy.Key,
                "key_and_day" => AdminGetAnalyticsGroupBy.KeyAndDay,
                _ => null,
            };
        }
    }
}