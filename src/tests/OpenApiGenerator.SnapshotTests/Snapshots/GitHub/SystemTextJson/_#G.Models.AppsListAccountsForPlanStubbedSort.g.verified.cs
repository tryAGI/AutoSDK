//HintName: G.Models.AppsListAccountsForPlanStubbedSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    public enum AppsListAccountsForPlanStubbedSort
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
    public static class AppsListAccountsForPlanStubbedSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsListAccountsForPlanStubbedSort value)
        {
            return value switch
            {
                AppsListAccountsForPlanStubbedSort.Created => "created",
                AppsListAccountsForPlanStubbedSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsListAccountsForPlanStubbedSort ToEnum(string value)
        {
            return value switch
            {
                "created" => AppsListAccountsForPlanStubbedSort.Created,
                "updated" => AppsListAccountsForPlanStubbedSort.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}