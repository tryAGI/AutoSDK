//HintName: G.Models.GetGameAnalyticsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetGameAnalyticsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="overview_v2")]
        OverviewV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetGameAnalyticsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGameAnalyticsType value)
        {
            return value switch
            {
                GetGameAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGameAnalyticsType? ToEnum(string value)
        {
            return value switch
            {
                "overview_v2" => GetGameAnalyticsType.OverviewV2,
                _ => null,
            };
        }
    }
}