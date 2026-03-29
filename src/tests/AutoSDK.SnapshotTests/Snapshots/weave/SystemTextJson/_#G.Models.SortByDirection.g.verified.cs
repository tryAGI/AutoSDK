//HintName: G.Models.SortByDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SortByDirection
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
    public static class SortByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortByDirection value)
        {
            return value switch
            {
                SortByDirection.Asc => "asc",
                SortByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SortByDirection.Asc,
                "desc" => SortByDirection.Desc,
                _ => null,
            };
        }
    }
}