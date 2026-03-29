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
        [global::Newtonsoft.Json.JsonProperty("input_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputAudio InputAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"input_audio"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "input_audio";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartInputAudioParam" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type"></param>
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