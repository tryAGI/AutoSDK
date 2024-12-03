//HintName: G.Models.SdVersions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
    /// </summary>
    public enum SdVersions
    {
        /// <summary>
        /// 
        /// </summary>
        V15,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
        /// <summary>
        /// 
        /// </summary>
        SDXL08,
        /// <summary>
        /// 
        /// </summary>
        SDXL09,
        /// <summary>
        /// 
        /// </summary>
        SDXL10,
        /// <summary>
        /// 
        /// </summary>
        SDXLLIGHTNING,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SdVersionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SdVersions value)
        {
            return value switch
            {
                SdVersions.V15 => "v1_5",
                SdVersions.V2 => "v2",
                SdVersions.V3 => "v3",
                SdVersions.SDXL08 => "SDXL_0_8",
                SdVersions.SDXL09 => "SDXL_0_9",
                SdVersions.SDXL10 => "SDXL_1_0",
                SdVersions.SDXLLIGHTNING => "SDXL_LIGHTNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SdVersions? ToEnum(string value)
        {
            return value switch
            {
                "v1_5" => SdVersions.V15,
                "v2" => SdVersions.V2,
                "v3" => SdVersions.V3,
                "SDXL_0_8" => SdVersions.SDXL08,
                "SDXL_0_9" => SdVersions.SDXL09,
                "SDXL_1_0" => SdVersions.SDXL10,
                "SDXL_LIGHTNING" => SdVersions.SDXLLIGHTNING,
                _ => null,
            };
        }
    }
}