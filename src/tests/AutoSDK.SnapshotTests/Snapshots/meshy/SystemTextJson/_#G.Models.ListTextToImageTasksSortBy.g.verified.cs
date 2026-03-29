//HintName: G.Models.ListTextToImageTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTextToImageTasksSortBy
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
    public static class ListTextToImageTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTextToImageTasksSortBy value)
        {
            return value switch
            {
                ListTextToImageTasksSortBy.PluscreatedAt => "+created_at",
                ListTextToImageTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTextToImageTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListTextToImageTasksSortBy.PluscreatedAt,
                "-created_at" => ListTextToImageTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}