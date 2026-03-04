//HintName: G.Models.UltravoxV1StaticParameterLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Where the parameter is used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1StaticParameterLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARAMETER_LOCATION_UNSPECIFIED")]
        ParameterLocationUnspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARAMETER_LOCATION_QUERY")]
        ParameterLocationQuery,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARAMETER_LOCATION_PATH")]
        ParameterLocationPath,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARAMETER_LOCATION_HEADER")]
        ParameterLocationHeader,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARAMETER_LOCATION_BODY")]
        ParameterLocationBody,
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
                UltravoxV1StaticParameterLocation.ParameterLocationUnspecified => "PARAMETER_LOCATION_UNSPECIFIED",
                UltravoxV1StaticParameterLocation.ParameterLocationQuery => "PARAMETER_LOCATION_QUERY",
                UltravoxV1StaticParameterLocation.ParameterLocationPath => "PARAMETER_LOCATION_PATH",
                UltravoxV1StaticParameterLocation.ParameterLocationHeader => "PARAMETER_LOCATION_HEADER",
                UltravoxV1StaticParameterLocation.ParameterLocationBody => "PARAMETER_LOCATION_BODY",
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
                "PARAMETER_LOCATION_UNSPECIFIED" => UltravoxV1StaticParameterLocation.ParameterLocationUnspecified,
                "PARAMETER_LOCATION_QUERY" => UltravoxV1StaticParameterLocation.ParameterLocationQuery,
                "PARAMETER_LOCATION_PATH" => UltravoxV1StaticParameterLocation.ParameterLocationPath,
                "PARAMETER_LOCATION_HEADER" => UltravoxV1StaticParameterLocation.ParameterLocationHeader,
                "PARAMETER_LOCATION_BODY" => UltravoxV1StaticParameterLocation.ParameterLocationBody,
                _ => null,
            };
        }
    }
}