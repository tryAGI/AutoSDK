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
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string MessageType { get; set; } = "listen_config";

        /// <summary>
        /// The model to use for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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