//HintName: G.Models.ApiDmViewsUpdateRequestDataFiltersConjunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
    /// </summary>
    public enum ApiDmViewsUpdateRequestDataFiltersConjunction
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiDmViewsUpdateRequestDataFiltersConjunctionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmViewsUpdateRequestDataFiltersConjunction value)
        {
            return value switch
            {
                ApiDmViewsUpdateRequestDataFiltersConjunction.And => "and",
                ApiDmViewsUpdateRequestDataFiltersConjunction.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmViewsUpdateRequestDataFiltersConjunction? ToEnum(string value)
        {
            return value switch
            {
                "and" => ApiDmViewsUpdateRequestDataFiltersConjunction.And,
                "or" => ApiDmViewsUpdateRequestDataFiltersConjunction.Or,
                _ => null,
            };
        }
    }
}