//HintName: G.Models.DashboardTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `overview` - Overview<br/>
    /// * `member_performance` - Member Performance
    /// </summary>
    public enum DashboardTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        MemberPerformance,
        /// <summary>
        /// 
        /// </summary>
        Overview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardTypeEnum value)
        {
            return value switch
            {
                DashboardTypeEnum.MemberPerformance => "member_performance",
                DashboardTypeEnum.Overview => "overview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "member_performance" => DashboardTypeEnum.MemberPerformance,
                "overview" => DashboardTypeEnum.Overview,
                _ => null,
            };
        }
    }
}