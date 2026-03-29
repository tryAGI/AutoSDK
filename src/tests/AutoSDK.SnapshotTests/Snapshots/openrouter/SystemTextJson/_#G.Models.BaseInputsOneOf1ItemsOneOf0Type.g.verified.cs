//HintName: G.Models.BaseInputsOneOf1ItemsOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0Type value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => BaseInputsOneOf1ItemsOneOf0Type.Message,
                _ => null,
            };
        }
    }
}