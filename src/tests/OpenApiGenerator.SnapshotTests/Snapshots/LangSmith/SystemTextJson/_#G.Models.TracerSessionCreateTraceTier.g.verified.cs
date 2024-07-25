//HintName: G.Models.TracerSessionCreateTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TracerSessionCreateTraceTier
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
    public static class TracerSessionCreateTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionCreateTraceTier value)
        {
            return value switch
            {
                TracerSessionCreateTraceTier.Longlived => "longlived",
                TracerSessionCreateTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionCreateTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TracerSessionCreateTraceTier.Longlived,
                "shortlived" => TracerSessionCreateTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}