//HintName: G.Models.ChatCompletionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model ID to use for completion
    /// </summary>
    public enum ChatCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Sarvam105b,
        /// <summary>
        /// 
        /// </summary>
        Sarvam105b32k,
        /// <summary>
        /// 
        /// </summary>
        Sarvam30b,
        /// <summary>
        /// 
        /// </summary>
        Sarvam30b16k,
        /// <summary>
        /// 
        /// </summary>
        SarvamM,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestModel value)
        {
            return value switch
            {
                ChatCompletionRequestModel.Sarvam105b => "sarvam-105b",
                ChatCompletionRequestModel.Sarvam105b32k => "sarvam-105b-32k",
                ChatCompletionRequestModel.Sarvam30b => "sarvam-30b",
                ChatCompletionRequestModel.Sarvam30b16k => "sarvam-30b-16k",
                ChatCompletionRequestModel.SarvamM => "sarvam-m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "sarvam-105b" => ChatCompletionRequestModel.Sarvam105b,
                "sarvam-105b-32k" => ChatCompletionRequestModel.Sarvam105b32k,
                "sarvam-30b" => ChatCompletionRequestModel.Sarvam30b,
                "sarvam-30b-16k" => ChatCompletionRequestModel.Sarvam30b16k,
                "sarvam-m" => ChatCompletionRequestModel.SarvamM,
                _ => null,
            };
        }
    }
}