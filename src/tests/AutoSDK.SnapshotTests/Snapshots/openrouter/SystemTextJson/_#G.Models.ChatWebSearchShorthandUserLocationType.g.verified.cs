//HintName: G.Models.ChatWebSearchShorthandUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatWebSearchShorthandUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchShorthandUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandUserLocationType value)
        {
            return value switch
            {
                ChatWebSearchShorthandUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => ChatWebSearchShorthandUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}