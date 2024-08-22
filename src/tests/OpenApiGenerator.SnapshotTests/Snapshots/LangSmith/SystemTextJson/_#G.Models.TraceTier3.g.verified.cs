//HintName: G.Models.TraceTier3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceTier3
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
    public static class TraceTier3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceTier3 value)
        {
            return value switch
            {
                TraceTier3.Longlived => "longlived",
                TraceTier3.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceTier3? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TraceTier3.Longlived,
                "shortlived" => TraceTier3.Shortlived,
                _ => null,
            };
        }
    }
}