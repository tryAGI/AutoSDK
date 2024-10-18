//HintName: G.Models.CreateVideoFromImageXRunwayVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoFromImageXRunwayVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20240913,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoFromImageXRunwayVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoFromImageXRunwayVersion value)
        {
            return value switch
            {
                CreateVideoFromImageXRunwayVersion.x20240913 => "2024-09-13",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoFromImageXRunwayVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-09-13" => CreateVideoFromImageXRunwayVersion.x20240913,
                _ => null,
            };
        }
    }
}