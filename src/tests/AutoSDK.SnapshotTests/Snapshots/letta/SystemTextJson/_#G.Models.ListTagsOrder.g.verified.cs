//HintName: G.Models.ListTagsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for tags. 'asc' for alphabetical order, 'desc' for reverse alphabetical order<br/>
    /// Default Value: asc
    /// </summary>
    public enum ListTagsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTagsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTagsOrder value)
        {
            return value switch
            {
                ListTagsOrder.Asc => "asc",
                ListTagsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTagsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListTagsOrder.Asc,
                "desc" => ListTagsOrder.Desc,
                _ => null,
            };
        }
    }
}