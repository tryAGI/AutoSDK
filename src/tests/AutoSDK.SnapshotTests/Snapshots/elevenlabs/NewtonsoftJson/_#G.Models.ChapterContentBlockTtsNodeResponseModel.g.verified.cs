//HintName: G.Models.ChapterContentBlockTtsNodeResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterContentBlockTtsNodeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tts_node"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "tts_node";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockTtsNodeResponseModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId"></param>
        /// <param name="text"></param>
        public ChapterContentBlockTtsNodeResponseModel(
            string voiceId,
            string text,
            string type = "tts_node")
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockTtsNodeResponseModel" /> class.
        /// </summary>
        public ChapterContentBlockTtsNodeResponseModel()
        {
        }
    }
}