//HintName: G.Models.CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesCreateWithRepoForAuthenticatedUserRequestGeo
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
    public static class CodespacesCreateWithRepoForAuthenticatedUserRequestGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesCreateWithRepoForAuthenticatedUserRequestGeo value)
        {
            return value switch
            {
                CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.EuropeWest => "EuropeWest",
                CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.SoutheastAsia => "SoutheastAsia",
                CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.UsEast => "UsEast",
                CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.UsWest => "UsWest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesCreateWithRepoForAuthenticatedUserRequestGeo ToEnum(string value)
        {
            return value switch
            {
                "EuropeWest" => CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.EuropeWest,
                "SoutheastAsia" => CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.SoutheastAsia,
                "UsEast" => CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.UsEast,
                "UsWest" => CodespacesCreateWithRepoForAuthenticatedUserRequestGeo.UsWest,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}