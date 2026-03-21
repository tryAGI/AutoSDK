//HintName: G.Models.ListenConfigPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Listen configuration.
    /// </summary>
    public sealed partial class ListenConfigPayload
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"listen_config"</default>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string MessageType { get; set; } = "listen_config";

        /// <summary>
        /// The model to use for transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Language code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenConfigPayload" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="model">
        /// The model to use for transcription.
        /// </param>
        /// <param name="language">
        /// Language code.
        /// </param>
        public ListenConfigPayload(
            string? model,
            string? language,
            string messageType = "listen_config")
        {
            this.MessageType = messageType;
            this.Model = model;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenConfigPayload" /> class.
        /// </summary>
        public ListenConfigPayload()
        {
        }
    }
}