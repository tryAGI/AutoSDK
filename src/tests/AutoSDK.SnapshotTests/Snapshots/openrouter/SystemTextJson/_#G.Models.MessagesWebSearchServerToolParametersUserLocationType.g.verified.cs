//HintName: G.Models.MessagesWebSearchServerToolParametersUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesWebSearchServerToolParametersUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesWebSearchServerToolParametersUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesWebSearchServerToolParametersUserLocationType value)
        {
            return value switch
            {
                MessagesWebSearchServerToolParametersUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesWebSearchServerToolParametersUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => MessagesWebSearchServerToolParametersUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}