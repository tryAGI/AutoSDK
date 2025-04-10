//HintName: G.Models.UltravoxV1StaticParameterLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the parameter is used.
    /// </summary>
    public enum UltravoxV1StaticParameterLocation
    {
        /// <summary>
        /// 
        /// </summary>
        PARAMETERLOCATIONUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        PARAMETERLOCATIONQUERY,
        /// <summary>
        /// 
        /// </summary>
        PARAMETERLOCATIONPATH,
        /// <summary>
        /// 
        /// </summary>
        PARAMETERLOCATIONHEADER,
        /// <summary>
        /// 
        /// </summary>
        PARAMETERLOCATIONBODY,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StaticParameterLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StaticParameterLocation value)
        {
            return value switch
            {
                UltravoxV1StaticParameterLocation.PARAMETERLOCATIONUNSPECIFIED => "PARAMETER_LOCATION_UNSPECIFIED",
                UltravoxV1StaticParameterLocation.PARAMETERLOCATIONQUERY => "PARAMETER_LOCATION_QUERY",
                UltravoxV1StaticParameterLocation.PARAMETERLOCATIONPATH => "PARAMETER_LOCATION_PATH",
                UltravoxV1StaticParameterLocation.PARAMETERLOCATIONHEADER => "PARAMETER_LOCATION_HEADER",
                UltravoxV1StaticParameterLocation.PARAMETERLOCATIONBODY => "PARAMETER_LOCATION_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StaticParameterLocation? ToEnum(string value)
        {
            return value switch
            {
                "PARAMETER_LOCATION_UNSPECIFIED" => UltravoxV1StaticParameterLocation.PARAMETERLOCATIONUNSPECIFIED,
                "PARAMETER_LOCATION_QUERY" => UltravoxV1StaticParameterLocation.PARAMETERLOCATIONQUERY,
                "PARAMETER_LOCATION_PATH" => UltravoxV1StaticParameterLocation.PARAMETERLOCATIONPATH,
                "PARAMETER_LOCATION_HEADER" => UltravoxV1StaticParameterLocation.PARAMETERLOCATIONHEADER,
                "PARAMETER_LOCATION_BODY" => UltravoxV1StaticParameterLocation.PARAMETERLOCATIONBODY,
                _ => null,
            };
        }
    }
}