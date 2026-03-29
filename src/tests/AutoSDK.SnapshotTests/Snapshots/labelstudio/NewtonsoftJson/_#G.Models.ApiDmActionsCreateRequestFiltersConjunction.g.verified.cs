//HintName: G.Models.ApiDmActionsCreateRequestFiltersConjunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logical conjunction for the filters. This conjunction (either "or" or "and") will be applied to all items in the filters list. It is not possible to combine "or" and "and" within one list of filters. All filters will be either combined with "or" or with "and", but not a mix of both.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiDmActionsCreateRequestFiltersConjunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and")]
        And,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiDmActionsCreateRequestFiltersConjunctionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmActionsCreateRequestFiltersConjunction value)
        {
            return value switch
            {
                ApiDmActionsCreateRequestFiltersConjunction.And => "and",
                ApiDmActionsCreateRequestFiltersConjunction.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmActionsCreateRequestFiltersConjunction? ToEnum(string value)
        {
            return value switch
            {
                "and" => ApiDmActionsCreateRequestFiltersConjunction.And,
                "or" => ApiDmActionsCreateRequestFiltersConjunction.Or,
                _ => null,
            };
        }
    }
}