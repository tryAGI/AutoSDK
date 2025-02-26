//HintName: G.Models.ResponseCharLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: char_location
    /// </summary>
    public enum ResponseCharLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCharLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCharLocationCitationType value)
        {
            return value switch
            {
                ResponseCharLocationCitationType.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCharLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => ResponseCharLocationCitationType.CharLocation,
                _ => null,
            };
        }
    }
}