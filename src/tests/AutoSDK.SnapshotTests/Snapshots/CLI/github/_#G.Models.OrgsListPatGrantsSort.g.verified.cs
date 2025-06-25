//HintName: G.Models.OrgsListPatGrantsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum OrgsListPatGrantsSort
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListPatGrantsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListPatGrantsSort value)
        {
            return value switch
            {
                OrgsListPatGrantsSort.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPatGrantsSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => OrgsListPatGrantsSort.CreatedAt,
                _ => null,
            };
        }
    }
}