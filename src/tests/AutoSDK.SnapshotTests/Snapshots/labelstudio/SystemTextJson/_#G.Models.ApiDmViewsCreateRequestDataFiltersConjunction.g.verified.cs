//HintName: G.Models.ApiDmViewsCreateRequestDataFiltersConjunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
    /// </summary>
    public enum ApiDmViewsCreateRequestDataFiltersConjunction
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
    public static class ApiDmViewsCreateRequestDataFiltersConjunctionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmViewsCreateRequestDataFiltersConjunction value)
        {
            return value switch
            {
                ApiDmViewsCreateRequestDataFiltersConjunction.And => "and",
                ApiDmViewsCreateRequestDataFiltersConjunction.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmViewsCreateRequestDataFiltersConjunction? ToEnum(string value)
        {
            return value switch
            {
                "and" => ApiDmViewsCreateRequestDataFiltersConjunction.And,
                "or" => ApiDmViewsCreateRequestDataFiltersConjunction.Or,
                _ => null,
            };
        }
    }
}