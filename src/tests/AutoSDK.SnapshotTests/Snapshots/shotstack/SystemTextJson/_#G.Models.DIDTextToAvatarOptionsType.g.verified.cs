//HintName: G.Models.DIDTextToAvatarOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-avatar` for text-to-avatar.
    /// </summary>
    public enum DIDTextToAvatarOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        TextToAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DIDTextToAvatarOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIDTextToAvatarOptionsType value)
        {
            return value switch
            {
                DIDTextToAvatarOptionsType.TextToAvatar => "text-to-avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIDTextToAvatarOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-avatar" => DIDTextToAvatarOptionsType.TextToAvatar,
                _ => null,
            };
        }
    }
}