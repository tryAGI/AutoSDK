//HintName: G.Models.ResponsePageLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: page_location
    /// </summary>
    public enum ResponsePageLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsePageLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePageLocationCitationType value)
        {
            return value switch
            {
                ResponsePageLocationCitationType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePageLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => ResponsePageLocationCitationType.PageLocation,
                _ => null,
            };
        }
    }
}