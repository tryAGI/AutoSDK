//HintName: G.Models.SearchUsersOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SearchUsersOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Desc,
        /// <summary>
        /// 
        /// </summary>
        Asc,
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
                SearchUsersOrder.Desc => "desc",
                SearchUsersOrder.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchUsersOrder ToEnum(string value)
        {
            return value switch
            {
                "desc" => SearchUsersOrder.Desc,
                "asc" => SearchUsersOrder.Asc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}