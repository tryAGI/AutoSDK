//HintName: G.Models.ResponseInputItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseInputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call_output")]
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="item_reference")]
        ItemReference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
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