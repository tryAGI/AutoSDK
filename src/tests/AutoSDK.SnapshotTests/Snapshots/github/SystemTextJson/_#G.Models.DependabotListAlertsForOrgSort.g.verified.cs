//HintName: G.Models.DependabotListAlertsForOrgSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum DependabotListAlertsForOrgSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForOrgSort value)
        {
            return value switch
            {
                DependabotListAlertsForOrgSort.Created => "created",
                DependabotListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForOrgSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => DependabotListAlertsForOrgSort.Created,
                "updated" => DependabotListAlertsForOrgSort.Updated,
                _ => null,
            };
        }
    }
}