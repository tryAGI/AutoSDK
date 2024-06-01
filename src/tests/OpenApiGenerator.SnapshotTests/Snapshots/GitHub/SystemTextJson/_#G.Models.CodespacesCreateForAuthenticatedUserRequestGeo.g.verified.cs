//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestGeo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
    /// </summary>
    public enum CodespacesCreateForAuthenticatedUserRequestGeo
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
    public static class CodespacesCreateForAuthenticatedUserRequestGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesCreateForAuthenticatedUserRequestGeo value)
        {
            return value switch
            {
                CodespacesCreateForAuthenticatedUserRequestGeo.EuropeWest => "EuropeWest",
                CodespacesCreateForAuthenticatedUserRequestGeo.SoutheastAsia => "SoutheastAsia",
                CodespacesCreateForAuthenticatedUserRequestGeo.UsEast => "UsEast",
                CodespacesCreateForAuthenticatedUserRequestGeo.UsWest => "UsWest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesCreateForAuthenticatedUserRequestGeo ToEnum(string value)
        {
            return value switch
            {
                "EuropeWest" => CodespacesCreateForAuthenticatedUserRequestGeo.EuropeWest,
                "SoutheastAsia" => CodespacesCreateForAuthenticatedUserRequestGeo.SoutheastAsia,
                "UsEast" => CodespacesCreateForAuthenticatedUserRequestGeo.UsEast,
                "UsWest" => CodespacesCreateForAuthenticatedUserRequestGeo.UsWest,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}