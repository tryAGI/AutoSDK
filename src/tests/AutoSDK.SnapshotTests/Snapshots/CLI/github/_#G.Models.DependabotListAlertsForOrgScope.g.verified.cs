//HintName: G.Models.DependabotListAlertsForOrgScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependabotListAlertsForOrgScope
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Runtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForOrgScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForOrgScope value)
        {
            return value switch
            {
                DependabotListAlertsForOrgScope.Development => "development",
                DependabotListAlertsForOrgScope.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForOrgScope? ToEnum(string value)
        {
            return value switch
            {
                "development" => DependabotListAlertsForOrgScope.Development,
                "runtime" => DependabotListAlertsForOrgScope.Runtime,
                _ => null,
            };
        }
    }
}