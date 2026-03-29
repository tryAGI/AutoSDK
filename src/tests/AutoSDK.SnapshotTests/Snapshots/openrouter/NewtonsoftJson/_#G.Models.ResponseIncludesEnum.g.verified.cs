//HintName: G.Models.ResponseIncludesEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseIncludesEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter_call.outputs")]
        CodeInterpreterCallOutputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_call_output.output.image_url")]
        ComputerCallOutputOutputImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search_call.results")]
        FileSearchCallResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message.input_image.image_url")]
        MessageInputImageImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning.encrypted_content")]
        ReasoningEncryptedContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseIncludesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseIncludesEnum value)
        {
            return value switch
            {
                ResponseIncludesEnum.CodeInterpreterCallOutputs => "code_interpreter_call.outputs",
                ResponseIncludesEnum.ComputerCallOutputOutputImageUrl => "computer_call_output.output.image_url",
                ResponseIncludesEnum.FileSearchCallResults => "file_search_call.results",
                ResponseIncludesEnum.MessageInputImageImageUrl => "message.input_image.image_url",
                ResponseIncludesEnum.ReasoningEncryptedContent => "reasoning.encrypted_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseIncludesEnum? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call.outputs" => ResponseIncludesEnum.CodeInterpreterCallOutputs,
                "computer_call_output.output.image_url" => ResponseIncludesEnum.ComputerCallOutputOutputImageUrl,
                "file_search_call.results" => ResponseIncludesEnum.FileSearchCallResults,
                "message.input_image.image_url" => ResponseIncludesEnum.MessageInputImageImageUrl,
                "reasoning.encrypted_content" => ResponseIncludesEnum.ReasoningEncryptedContent,
                _ => null,
            };
        }
    }
}