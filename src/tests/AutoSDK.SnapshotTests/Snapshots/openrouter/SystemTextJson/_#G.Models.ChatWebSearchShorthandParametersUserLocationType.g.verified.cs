//HintName: G.Models.ChatWebSearchShorthandParametersUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatWebSearchShorthandParametersUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchShorthandParametersUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandParametersUserLocationType value)
        {
            return value switch
            {
                ChatWebSearchShorthandParametersUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandParametersUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => ChatWebSearchShorthandParametersUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}