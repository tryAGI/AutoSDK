//HintName: G.Models.TracerSessionWithoutVirtualFieldsTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TracerSessionWithoutVirtualFieldsTraceTier
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
    public static class TracerSessionWithoutVirtualFieldsTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionWithoutVirtualFieldsTraceTier value)
        {
            return value switch
            {
                TracerSessionWithoutVirtualFieldsTraceTier.Longlived => "longlived",
                TracerSessionWithoutVirtualFieldsTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionWithoutVirtualFieldsTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => TracerSessionWithoutVirtualFieldsTraceTier.Longlived,
                "shortlived" => TracerSessionWithoutVirtualFieldsTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}