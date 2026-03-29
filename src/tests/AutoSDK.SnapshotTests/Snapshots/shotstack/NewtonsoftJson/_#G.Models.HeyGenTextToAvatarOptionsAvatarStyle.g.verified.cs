//HintName: G.Models.HeyGenTextToAvatarOptionsAvatarStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The display style of the avatar, a rectangle `normal` or circular `circle` background. Defaults to `normal`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HeyGenTextToAvatarOptionsAvatarStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="circle")]
        Circle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeyGenTextToAvatarOptionsAvatarStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeyGenTextToAvatarOptionsAvatarStyle value)
        {
            return value switch
            {
                HeyGenTextToAvatarOptionsAvatarStyle.Circle => "circle",
                HeyGenTextToAvatarOptionsAvatarStyle.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeyGenTextToAvatarOptionsAvatarStyle? ToEnum(string value)
        {
            return value switch
            {
                "circle" => HeyGenTextToAvatarOptionsAvatarStyle.Circle,
                "normal" => HeyGenTextToAvatarOptionsAvatarStyle.Normal,
                _ => null,
            };
        }
    }
}