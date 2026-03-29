//HintName: G.Models.ChatCompletionContentPartInputAudioParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [audio inputs](https://platform.openai.com/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionContentPartInputAudioParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InputAudio InputAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"input_audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_audio";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartInputAudioParam" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartInputAudioParam(
            global::G.InputAudio inputAudio,
            string type = "input_audio")
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartInputAudioParam" /> class.
        /// </summary>
        public ChatCompletionContentPartInputAudioParam()
        {
        }
    }
}