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

    public static class GetGameAnalyticsTypeExtensions
    {
        public static string ToValueString(this GetGameAnalyticsType value)
        {
            return value switch
            {
                GetGameAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetGameAnalyticsType ToEnum(string value)
        {
            return value switch
            {
                "overview_v2" => GetGameAnalyticsType.OverviewV2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetGameAnalyticsType ToEnum(int value)
        {
            return value switch
            {
                0 => GetGameAnalyticsType.OverviewV2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}