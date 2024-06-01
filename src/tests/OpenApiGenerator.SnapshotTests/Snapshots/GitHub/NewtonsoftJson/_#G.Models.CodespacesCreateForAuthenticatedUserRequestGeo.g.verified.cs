//HintName: G.Models.CodespacesCreateForAuthenticatedUserRequestGeo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesCreateForAuthenticatedUserRequestGeo
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