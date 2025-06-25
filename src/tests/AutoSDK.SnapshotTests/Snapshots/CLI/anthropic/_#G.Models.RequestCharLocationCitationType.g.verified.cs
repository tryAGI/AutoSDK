//HintName: G.Models.RequestCharLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestCharLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestCharLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestCharLocationCitationType value)
        {
            return value switch
            {
                RequestCharLocationCitationType.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestCharLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => RequestCharLocationCitationType.CharLocation,
                _ => null,
            };
        }
    }
}