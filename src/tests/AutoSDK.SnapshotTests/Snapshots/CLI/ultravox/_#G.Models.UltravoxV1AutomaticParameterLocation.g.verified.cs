//HintName: G.Models.UltravoxV1AutomaticParameterLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the parameter is used.
    /// </summary>
    public enum UltravoxV1AutomaticParameterLocation
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
    public static class UltravoxV1AutomaticParameterLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1AutomaticParameterLocation value)
        {
            return value switch
            {
                UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONUNSPECIFIED => "PARAMETER_LOCATION_UNSPECIFIED",
                UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONQUERY => "PARAMETER_LOCATION_QUERY",
                UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONPATH => "PARAMETER_LOCATION_PATH",
                UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONHEADER => "PARAMETER_LOCATION_HEADER",
                UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONBODY => "PARAMETER_LOCATION_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1AutomaticParameterLocation? ToEnum(string value)
        {
            return value switch
            {
                "PARAMETER_LOCATION_UNSPECIFIED" => UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONUNSPECIFIED,
                "PARAMETER_LOCATION_QUERY" => UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONQUERY,
                "PARAMETER_LOCATION_PATH" => UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONPATH,
                "PARAMETER_LOCATION_HEADER" => UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONHEADER,
                "PARAMETER_LOCATION_BODY" => UltravoxV1AutomaticParameterLocation.PARAMETERLOCATIONBODY,
                _ => null,
            };
        }
    }
}