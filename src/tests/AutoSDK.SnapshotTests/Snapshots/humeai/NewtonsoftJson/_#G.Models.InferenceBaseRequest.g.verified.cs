//HintName: G.Models.InferenceBaseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceBaseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models")]
        public global::G.ModelsConfig? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public global::G.TranscriptionConfig? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::System.Collections.Generic.IList<string>? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notify")]
        public bool? Notify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceBaseRequest" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="transcription"></param>
        /// <param name="urls"></param>
        /// <param name="text"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="notify"></param>
        public InferenceBaseRequest(
            global::G.ModelsConfig? models,
            global::G.TranscriptionConfig? transcription,
            global::System.Collections.Generic.IList<string>? urls,
            global::System.Collections.Generic.IList<string>? text,
            string? callbackUrl,
            bool? notify)
        {
            this.Models = models;
            this.Transcription = transcription;
            this.Urls = urls;
            this.Text = text;
            this.CallbackUrl = callbackUrl;
            this.Notify = notify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceBaseRequest" /> class.
        /// </summary>
        public InferenceBaseRequest()
        {
        }
    }
}