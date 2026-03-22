//HintName: G.Models.SearchUsersOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SearchUsersOrder
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
    public static class SearchUsersOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchUsersOrder value)
        {
            return value switch
            {
                SearchUsersOrder.Asc => "asc",
                SearchUsersOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchUsersOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SearchUsersOrder.Asc,
                "desc" => SearchUsersOrder.Desc,
                _ => null,
            };
        }
    }
}