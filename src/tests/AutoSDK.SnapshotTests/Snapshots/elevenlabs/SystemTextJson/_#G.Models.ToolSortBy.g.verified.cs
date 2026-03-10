//HintName: G.Models.ToolSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSortBy value)
        {
            return value switch
            {
                ToolSortBy.Name => "name",
                ToolSortBy.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSortBy? ToEnum(string value)
        {
            return value switch
            {
                "name" => ToolSortBy.Name,
                "created_at" => ToolSortBy.CreatedAt,
                _ => null,
            };
        }
    }
}