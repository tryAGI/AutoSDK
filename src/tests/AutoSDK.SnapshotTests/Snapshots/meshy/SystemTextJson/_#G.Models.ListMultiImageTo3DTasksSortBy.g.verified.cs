//HintName: G.Models.ListMultiImageTo3DTasksSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListMultiImageTo3DTasksSortBy
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
    public static class ListMultiImageTo3DTasksSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMultiImageTo3DTasksSortBy value)
        {
            return value switch
            {
                ListMultiImageTo3DTasksSortBy.PluscreatedAt => "+created_at",
                ListMultiImageTo3DTasksSortBy.MinuscreatedAt => "-created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMultiImageTo3DTasksSortBy? ToEnum(string value)
        {
            return value switch
            {
                "+created_at" => ListMultiImageTo3DTasksSortBy.PluscreatedAt,
                "-created_at" => ListMultiImageTo3DTasksSortBy.MinuscreatedAt,
                _ => null,
            };
        }
    }
}