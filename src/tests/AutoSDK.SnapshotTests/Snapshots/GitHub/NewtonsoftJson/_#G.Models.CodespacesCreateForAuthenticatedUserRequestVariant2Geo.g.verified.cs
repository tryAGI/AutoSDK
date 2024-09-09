//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestVariant2Geo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesCreateForAuthenticatedUserRequestVariant2Geo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EuropeWest")]
        EuropeWest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SoutheastAsia")]
        SoutheastAsia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UsEast")]
        UsEast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UsWest")]
        UsWest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespacesCreateForAuthenticatedUserRequestVariant2GeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesCreateForAuthenticatedUserRequestVariant2Geo value)
        {
            return value switch
            {
                CodespacesCreateForAuthenticatedUserRequestVariant2Geo.EuropeWest => "EuropeWest",
                CodespacesCreateForAuthenticatedUserRequestVariant2Geo.SoutheastAsia => "SoutheastAsia",
                CodespacesCreateForAuthenticatedUserRequestVariant2Geo.UsEast => "UsEast",
                CodespacesCreateForAuthenticatedUserRequestVariant2Geo.UsWest => "UsWest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesCreateForAuthenticatedUserRequestVariant2Geo? ToEnum(string value)
        {
            return value switch
            {
                "EuropeWest" => CodespacesCreateForAuthenticatedUserRequestVariant2Geo.EuropeWest,
                "SoutheastAsia" => CodespacesCreateForAuthenticatedUserRequestVariant2Geo.SoutheastAsia,
                "UsEast" => CodespacesCreateForAuthenticatedUserRequestVariant2Geo.UsEast,
                "UsWest" => CodespacesCreateForAuthenticatedUserRequestVariant2Geo.UsWest,
                _ => null,
            };
        }
    }
}