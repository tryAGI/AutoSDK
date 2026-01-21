//HintName: G.Models.ChatCompletionContentPartAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputAudio InputAudio { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartAudio" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="inputAudio"></param>
        public ChatCompletionContentPartAudio(
            string type,
            global::G.InputAudio inputAudio)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartAudio" /> class.
        /// </summary>
        public ChatCompletionContentPartAudio()
        {
        }
    }
}