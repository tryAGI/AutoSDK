//HintName: G.Models.BaseInputsOneOf1ItemsOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf3Type value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf3Type.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => BaseInputsOneOf1ItemsOneOf3Type.FunctionCall,
                _ => null,
            };
        }
    }
}