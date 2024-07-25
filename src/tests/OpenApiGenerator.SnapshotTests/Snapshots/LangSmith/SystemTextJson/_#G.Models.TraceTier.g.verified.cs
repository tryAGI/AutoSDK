//HintName: G.Models.TraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Longlived,
        /// <summary>
        /// 
        /// </summary>
        Shortlived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceTier value)
        {
            return value switch
            {
                TraceTier.Longlived => "longlived",
                TraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TraceTier.Longlived,
                "shortlived" => TraceTier.Shortlived,
                _ => null,
            };
        }
    }
}