//HintName: G.Models.ResponseOutputItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOutputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseOutputItemDiscriminatorType.FunctionCall => "function_call",
                ResponseOutputItemDiscriminatorType.Message => "message",
                ResponseOutputItemDiscriminatorType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponseOutputItemDiscriminatorType.FunctionCall,
                "message" => ResponseOutputItemDiscriminatorType.Message,
                "reasoning" => ResponseOutputItemDiscriminatorType.Reasoning,
                _ => null,
            };
        }
    }
}