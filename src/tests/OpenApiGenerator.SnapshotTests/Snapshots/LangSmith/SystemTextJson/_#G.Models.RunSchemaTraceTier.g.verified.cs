//HintName: G.Models.RunSchemaTraceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunSchemaTraceTier
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
    public static class RunSchemaTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSchemaTraceTier value)
        {
            return value switch
            {
                RunSchemaTraceTier.Longlived => "longlived",
                RunSchemaTraceTier.Shortlived => "shortlived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSchemaTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "longlived" => RunSchemaTraceTier.Longlived,
                "shortlived" => RunSchemaTraceTier.Shortlived,
                _ => null,
            };
        }
    }
}