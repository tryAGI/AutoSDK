//HintName: G.Models.ListCallsSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum ListCallsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCallsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsSortBy value)
        {
            return value switch
            {
                ListCallsSortBy.CreatedAt => "created_at",
                ListCallsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListCallsSortBy.CreatedAt,
                "updated_at" => ListCallsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}