//HintName: G.Models.ListFoldersOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for folders by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: asc
    /// </summary>
    public enum ListFoldersOrder
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
    public static class ListFoldersOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFoldersOrder value)
        {
            return value switch
            {
                ListFoldersOrder.Asc => "asc",
                ListFoldersOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFoldersOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFoldersOrder.Asc,
                "desc" => ListFoldersOrder.Desc,
                _ => null,
            };
        }
    }
}