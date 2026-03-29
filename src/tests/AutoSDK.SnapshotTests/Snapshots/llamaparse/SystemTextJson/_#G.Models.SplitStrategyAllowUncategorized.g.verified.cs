//HintName: G.Models.SplitStrategyAllowUncategorized.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls handling of pages that don't match any category. 'include': pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.<br/>
    /// Default Value: include
    /// </summary>
    public enum SplitStrategyAllowUncategorized
    {
        /// <summary>
        /// pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.
        /// </summary>
        Forbid,
        /// <summary>
        /// pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.
        /// </summary>
        Include,
        /// <summary>
        /// pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.
        /// </summary>
        Omit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitStrategyAllowUncategorizedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitStrategyAllowUncategorized value)
        {
            return value switch
            {
                SplitStrategyAllowUncategorized.Forbid => "forbid",
                SplitStrategyAllowUncategorized.Include => "include",
                SplitStrategyAllowUncategorized.Omit => "omit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitStrategyAllowUncategorized? ToEnum(string value)
        {
            return value switch
            {
                "forbid" => SplitStrategyAllowUncategorized.Forbid,
                "include" => SplitStrategyAllowUncategorized.Include,
                "omit" => SplitStrategyAllowUncategorized.Omit,
                _ => null,
            };
        }
    }
}