//HintName: G.Models.ResponseInputItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseInputItemDiscriminatorType.FunctionCall => "function_call",
                ResponseInputItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                ResponseInputItemDiscriminatorType.ItemReference => "item_reference",
                ResponseInputItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponseInputItemDiscriminatorType.FunctionCall,
                "function_call_output" => ResponseInputItemDiscriminatorType.FunctionCallOutput,
                "item_reference" => ResponseInputItemDiscriminatorType.ItemReference,
                "message" => ResponseInputItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}