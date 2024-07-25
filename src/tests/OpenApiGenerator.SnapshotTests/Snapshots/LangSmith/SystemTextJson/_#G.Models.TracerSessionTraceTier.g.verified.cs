//HintName: G.Models.TracerSessionTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TracerSessionTraceTier
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
    public static class TracerSessionTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionTraceTier value)
        {
            return value switch
            {
                TracerSessionTraceTier.Longlived => "longlived",
                TracerSessionTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TracerSessionTraceTier.Longlived,
                "shortlived" => TracerSessionTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}