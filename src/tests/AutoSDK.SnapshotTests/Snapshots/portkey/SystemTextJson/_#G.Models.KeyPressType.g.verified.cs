//HintName: G.Models.KeyPressType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a keypress action, this property is <br/>
    /// always set to `keypress`.<br/>
    /// Default Value: keypress
    /// </summary>
    public enum KeyPressType
    {
        /// <summary>
        /// 
        /// </summary>
        Keypress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyPressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyPressType value)
        {
            return value switch
            {
                KeyPressType.Keypress => "keypress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyPressType? ToEnum(string value)
        {
            return value switch
            {
                "keypress" => KeyPressType.Keypress,
                _ => null,
            };
        }
    }
}