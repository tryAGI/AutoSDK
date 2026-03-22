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
        ParameterLocationBody,
        /// <summary>
        /// 
        /// </summary>
        ParameterLocationHeader,
        /// <summary>
        /// 
        /// </summary>
        ParameterLocationPath,
        /// <summary>
        /// 
        /// </summary>
        ParameterLocationQuery,
        /// <summary>
        /// 
        /// </summary>
        ParameterLocationUnspecified,
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
                UltravoxV1DynamicParameterLocation.ParameterLocationBody => "PARAMETER_LOCATION_BODY",
                UltravoxV1DynamicParameterLocation.ParameterLocationHeader => "PARAMETER_LOCATION_HEADER",
                UltravoxV1DynamicParameterLocation.ParameterLocationPath => "PARAMETER_LOCATION_PATH",
                UltravoxV1DynamicParameterLocation.ParameterLocationQuery => "PARAMETER_LOCATION_QUERY",
                UltravoxV1DynamicParameterLocation.ParameterLocationUnspecified => "PARAMETER_LOCATION_UNSPECIFIED",
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
                "PARAMETER_LOCATION_BODY" => UltravoxV1DynamicParameterLocation.ParameterLocationBody,
                "PARAMETER_LOCATION_HEADER" => UltravoxV1DynamicParameterLocation.ParameterLocationHeader,
                "PARAMETER_LOCATION_PATH" => UltravoxV1DynamicParameterLocation.ParameterLocationPath,
                "PARAMETER_LOCATION_QUERY" => UltravoxV1DynamicParameterLocation.ParameterLocationQuery,
                "PARAMETER_LOCATION_UNSPECIFIED" => UltravoxV1DynamicParameterLocation.ParameterLocationUnspecified,
                _ => null,
            };
        }
    }
}