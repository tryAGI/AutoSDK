//HintName: G.Models.DependabotListAlertsForRepoScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependabotListAlertsForRepoScope
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
    public static class DependabotListAlertsForRepoScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForRepoScope value)
        {
            return value switch
            {
                DependabotListAlertsForRepoScope.Development => "development",
                DependabotListAlertsForRepoScope.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForRepoScope? ToEnum(string value)
        {
            return value switch
            {
                "development" => DependabotListAlertsForRepoScope.Development,
                "runtime" => DependabotListAlertsForRepoScope.Runtime,
                _ => null,
            };
        }
    }
}