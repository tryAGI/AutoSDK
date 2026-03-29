//HintName: G.Models.HeyGenTextToAvatarOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-avatar` for text-to-avatar.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HeyGenTextToAvatarOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-avatar")]
        TextToAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeyGenTextToAvatarOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeyGenTextToAvatarOptionsType value)
        {
            return value switch
            {
                HeyGenTextToAvatarOptionsType.TextToAvatar => "text-to-avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeyGenTextToAvatarOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-avatar" => HeyGenTextToAvatarOptionsType.TextToAvatar,
                _ => null,
            };
        }
    }
}