//HintName: G.Models.UltravoxV1DynamicParameterLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the parameter is used.
    /// </summary>
    public enum UltravoxV1DynamicParameterLocation
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
    public static class UltravoxV1DynamicParameterLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1DynamicParameterLocation value)
        {
            return value switch
            {
                UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONUNSPECIFIED => "PARAMETER_LOCATION_UNSPECIFIED",
                UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONQUERY => "PARAMETER_LOCATION_QUERY",
                UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONPATH => "PARAMETER_LOCATION_PATH",
                UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONHEADER => "PARAMETER_LOCATION_HEADER",
                UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONBODY => "PARAMETER_LOCATION_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1DynamicParameterLocation? ToEnum(string value)
        {
            return value switch
            {
                "PARAMETER_LOCATION_UNSPECIFIED" => UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONUNSPECIFIED,
                "PARAMETER_LOCATION_QUERY" => UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONQUERY,
                "PARAMETER_LOCATION_PATH" => UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONPATH,
                "PARAMETER_LOCATION_HEADER" => UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONHEADER,
                "PARAMETER_LOCATION_BODY" => UltravoxV1DynamicParameterLocation.PARAMETERLOCATIONBODY,
                _ => null,
            };
        }
    }
}