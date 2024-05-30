//HintName: G.Models.GetExtensionAnalyticsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExtensionAnalyticsType
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
    public static class GetExtensionAnalyticsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExtensionAnalyticsType value)
        {
            return value switch
            {
                GetExtensionAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExtensionAnalyticsType ToEnum(string value)
        {
            return value switch
            {
                "overview_v2" => GetExtensionAnalyticsType.OverviewV2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}