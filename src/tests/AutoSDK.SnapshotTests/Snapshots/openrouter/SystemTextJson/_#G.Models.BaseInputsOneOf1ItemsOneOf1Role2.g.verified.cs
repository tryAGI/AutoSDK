//HintName: G.Models.BaseInputsOneOf1ItemsOneOf1Role2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf1Role2
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf1Role2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf1Role2 value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf1Role2.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf1Role2? ToEnum(string value)
        {
            return value switch
            {
                "developer" => BaseInputsOneOf1ItemsOneOf1Role2.Developer,
                _ => null,
            };
        }
    }
}