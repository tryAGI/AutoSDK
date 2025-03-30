//HintName: G.Models.OrbAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the avatar<br/>
    /// Default Value: orb
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrbAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="orb")]
        Orb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrbAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrbAvatarType value)
        {
            return value switch
            {
                OrbAvatarType.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrbAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "orb" => OrbAvatarType.Orb,
                _ => null,
            };
        }
    }
}