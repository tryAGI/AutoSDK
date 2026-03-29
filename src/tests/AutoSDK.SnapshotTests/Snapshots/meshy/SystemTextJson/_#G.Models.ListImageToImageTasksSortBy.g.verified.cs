//HintName: G.Models.ListImageToImageTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListImageToImageTasksSortBy
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
    public static class ListImageToImageTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListImageToImageTasksSortBy value)
        {
            return value switch
            {
                ListImageToImageTasksSortBy.PluscreatedAt => "+created_at",
                ListImageToImageTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListImageToImageTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListImageToImageTasksSortBy.PluscreatedAt,
                "-created_at" => ListImageToImageTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}