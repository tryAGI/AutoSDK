//HintName: G.Models.GetExtensionAnalyticsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExtensionAnalyticsType
    {
        /// <summary>
        /// 
        /// </summary>
        OverviewV2,
    }

    public static class GetExtensionAnalyticsTypeExtensions
    {
        public static string ToValueString(this GetExtensionAnalyticsType value)
        {
            return value switch
            {
                GetExtensionAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetExtensionAnalyticsType ToEnum(string value)
        {
            return value switch
            {
                "overview_v2" => GetExtensionAnalyticsType.OverviewV2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetExtensionAnalyticsType ToEnum(int value)
        {
            return value switch
            {
                0 => GetExtensionAnalyticsType.OverviewV2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}