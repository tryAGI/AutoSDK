//HintName: G.Models.AnalyticsQueryTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the table you want to query.
    /// </summary>
    public enum AnalyticsQueryTable
    {
        /// <summary>
        /// 
        /// </summary>
        Call,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsQueryTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsQueryTable value)
        {
            return value switch
            {
                AnalyticsQueryTable.Call => "call",
                AnalyticsQueryTable.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsQueryTable? ToEnum(string value)
        {
            return value switch
            {
                "call" => AnalyticsQueryTable.Call,
                "subscription" => AnalyticsQueryTable.Subscription,
                _ => null,
            };
        }
    }
}