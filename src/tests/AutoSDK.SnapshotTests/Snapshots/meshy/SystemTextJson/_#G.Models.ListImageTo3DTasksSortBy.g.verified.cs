//HintName: G.Models.ListImageTo3DTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListImageTo3DTasksSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        PluscreatedAt,
        /// <summary>
        /// 
        /// </summary>
        MinuscreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListImageTo3DTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListImageTo3DTasksSortBy value)
        {
            return value switch
            {
                ListImageTo3DTasksSortBy.PluscreatedAt => "+created_at",
                ListImageTo3DTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListImageTo3DTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListImageTo3DTasksSortBy.PluscreatedAt,
                "-created_at" => ListImageTo3DTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}