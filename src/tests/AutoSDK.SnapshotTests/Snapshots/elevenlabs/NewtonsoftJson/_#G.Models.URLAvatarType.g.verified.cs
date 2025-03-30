//HintName: G.Models.URLAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the avatar<br/>
    /// Default Value: url
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum URLAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class URLAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this URLAvatarType value)
        {
            return value switch
            {
                URLAvatarType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static URLAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "url" => URLAvatarType.Url,
                _ => null,
            };
        }
    }
}