//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestVariant1Geo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
    /// </summary>
    public enum CodespacesCreateForAuthenticatedUserRequestVariant1Geo
    {
        /// <summary>
        /// 
        /// </summary>
        EuropeWest,
        /// <summary>
        /// 
        /// </summary>
        SoutheastAsia,
        /// <summary>
        /// 
        /// </summary>
        UsEast,
        /// <summary>
        /// 
        /// </summary>
        UsWest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespacesCreateForAuthenticatedUserRequestVariant1GeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesCreateForAuthenticatedUserRequestVariant1Geo value)
        {
            return value switch
            {
                CodespacesCreateForAuthenticatedUserRequestVariant1Geo.EuropeWest => "EuropeWest",
                CodespacesCreateForAuthenticatedUserRequestVariant1Geo.SoutheastAsia => "SoutheastAsia",
                CodespacesCreateForAuthenticatedUserRequestVariant1Geo.UsEast => "UsEast",
                CodespacesCreateForAuthenticatedUserRequestVariant1Geo.UsWest => "UsWest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesCreateForAuthenticatedUserRequestVariant1Geo? ToEnum(string value)
        {
            return value switch
            {
                "EuropeWest" => CodespacesCreateForAuthenticatedUserRequestVariant1Geo.EuropeWest,
                "SoutheastAsia" => CodespacesCreateForAuthenticatedUserRequestVariant1Geo.SoutheastAsia,
                "UsEast" => CodespacesCreateForAuthenticatedUserRequestVariant1Geo.UsEast,
                "UsWest" => CodespacesCreateForAuthenticatedUserRequestVariant1Geo.UsWest,
                _ => null,
            };
        }
    }
}