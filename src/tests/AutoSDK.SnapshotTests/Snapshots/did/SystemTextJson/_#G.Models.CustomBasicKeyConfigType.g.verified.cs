//HintName: G.Models.CustomBasicKeyConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomBasicKeyConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomBasicKeyConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomBasicKeyConfigType value)
        {
            return value switch
            {
                CustomBasicKeyConfigType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomBasicKeyConfigType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CustomBasicKeyConfigType.Basic,
                _ => null,
            };
        }
    }
}