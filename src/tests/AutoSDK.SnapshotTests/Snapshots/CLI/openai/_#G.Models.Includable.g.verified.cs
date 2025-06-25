//HintName: G.Models.Includable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify additional output data to include in the model response. Currently<br/>
    /// supported values are:<br/>
    /// - `file_search_call.results`: Include the search results of<br/>
    ///   the file search tool call.<br/>
    /// - `message.input_image.image_url`: Include image urls from the input message.<br/>
    /// - `computer_call_output.output.image_url`: Include image urls from the computer call output.<br/>
    /// - `reasoning.encrypted_content`: Includes an encrypted version of reasoning<br/>
    ///   tokens in reasoning item outputs. This enables reasoning items to be used in<br/>
    ///   multi-turn conversations when using the Responses API statelessly (like<br/>
    ///   when the `store` parameter is set to `false`, or when an organization is<br/>
    ///   enrolled in the zero data retention program).<br/>
    /// - `code_interpreter_call.outputs`: Includes the outputs of python code execution<br/>
    ///   in code interpreter tool call items.
    /// </summary>
    public enum Includable
    {
        /// <summary>
        /// Include the search results of
        /// </summary>
        FileSearchCallResults,
        /// <summary>
        /// Include image urls from the input message.
        /// </summary>
        MessageInputImageImageUrl,
        /// <summary>
        /// Include image urls from the computer call output.
        /// </summary>
        ComputerCallOutputOutputImageUrl,
        /// <summary>
        /// Includes an encrypted version of reasoning
        /// </summary>
        ReasoningEncryptedContent,
        /// <summary>
        /// Includes the outputs of python code execution
        /// </summary>
        CodeInterpreterCallOutputs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IncludableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Includable value)
        {
            return value switch
            {
                Includable.FileSearchCallResults => "file_search_call.results",
                Includable.MessageInputImageImageUrl => "message.input_image.image_url",
                Includable.ComputerCallOutputOutputImageUrl => "computer_call_output.output.image_url",
                Includable.ReasoningEncryptedContent => "reasoning.encrypted_content",
                Includable.CodeInterpreterCallOutputs => "code_interpreter_call.outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Includable? ToEnum(string value)
        {
            return value switch
            {
                "file_search_call.results" => Includable.FileSearchCallResults,
                "message.input_image.image_url" => Includable.MessageInputImageImageUrl,
                "computer_call_output.output.image_url" => Includable.ComputerCallOutputOutputImageUrl,
                "reasoning.encrypted_content" => Includable.ReasoningEncryptedContent,
                "code_interpreter_call.outputs" => Includable.CodeInterpreterCallOutputs,
                _ => null,
            };
        }
    }
}