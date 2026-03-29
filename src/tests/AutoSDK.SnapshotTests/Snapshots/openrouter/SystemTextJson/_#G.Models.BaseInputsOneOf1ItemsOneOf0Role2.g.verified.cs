//HintName: G.Models.BaseInputsOneOf1ItemsOneOf0Role2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0Role2
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0Role2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0Role2 value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0Role2.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0Role2? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BaseInputsOneOf1ItemsOneOf0Role2.Assistant,
                _ => null,
            };
        }
    }
}