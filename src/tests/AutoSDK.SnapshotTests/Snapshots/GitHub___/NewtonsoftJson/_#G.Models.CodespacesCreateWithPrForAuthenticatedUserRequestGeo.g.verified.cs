//HintName: G.Models.CodespacesCreateWithPrForAuthenticatedUserRequestGeo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesCreateWithPrForAuthenticatedUserRequestGeo
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
    public static class CodespacesCreateWithPrForAuthenticatedUserRequestGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesCreateWithPrForAuthenticatedUserRequestGeo value)
        {
            return value switch
            {
                CodespacesCreateWithPrForAuthenticatedUserRequestGeo.EuropeWest => "EuropeWest",
                CodespacesCreateWithPrForAuthenticatedUserRequestGeo.SoutheastAsia => "SoutheastAsia",
                CodespacesCreateWithPrForAuthenticatedUserRequestGeo.UsEast => "UsEast",
                CodespacesCreateWithPrForAuthenticatedUserRequestGeo.UsWest => "UsWest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesCreateWithPrForAuthenticatedUserRequestGeo? ToEnum(string value)
        {
            return value switch
            {
                "EuropeWest" => CodespacesCreateWithPrForAuthenticatedUserRequestGeo.EuropeWest,
                "SoutheastAsia" => CodespacesCreateWithPrForAuthenticatedUserRequestGeo.SoutheastAsia,
                "UsEast" => CodespacesCreateWithPrForAuthenticatedUserRequestGeo.UsEast,
                "UsWest" => CodespacesCreateWithPrForAuthenticatedUserRequestGeo.UsWest,
                _ => null,
            };
        }
    }
}