//HintName: G.Models.ChatRequestPromptTruncation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defaults to `AUTO` when `connectors` are specified and `OFF` in all other cases.<br/>
    /// Dictates how the prompt will be constructed.<br/>
    /// With `prompt_truncation` set to "AUTO", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be changed and ranked by relevance.<br/>
    /// With `prompt_truncation` set to "AUTO_PRESERVE_ORDER", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be preserved as they are inputted into the API.<br/>
    /// With `prompt_truncation` set to "OFF", no elements will be dropped. If the sum of the inputs exceeds the model's context length limit, a `TooManyTokens` error will be returned.<br/>
    /// Compatible Deployments: Cohere Platform Only AUTO_PRESERVE_ORDER: Azure, AWS Sagemaker/Bedrock, Private Deployments
    /// </summary>
    public enum ChatRequestPromptTruncation
    {
        /// <summary>
        /// 
        /// </summary>
        OFF,
        /// <summary>
        /// 
        /// </summary>
        AUTO,
        /// <summary>
        /// 
        /// </summary>
        AUTOPRESERVEORDER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPromptTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPromptTruncation value)
        {
            return value switch
            {
                ChatRequestPromptTruncation.OFF => "OFF",
                ChatRequestPromptTruncation.AUTO => "AUTO",
                ChatRequestPromptTruncation.AUTOPRESERVEORDER => "AUTO_PRESERVE_ORDER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPromptTruncation? ToEnum(string value)
        {
            return value switch
            {
                "OFF" => ChatRequestPromptTruncation.OFF,
                "AUTO" => ChatRequestPromptTruncation.AUTO,
                "AUTO_PRESERVE_ORDER" => ChatRequestPromptTruncation.AUTOPRESERVEORDER,
                _ => null,
            };
        }
    }
}