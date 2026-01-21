//HintName: G.Models.ConversationHistoryTranscriptToolCallClientDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallClientDetails
    {
        /// <summary>
        /// Default Value: client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public string Parameters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallClientDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: client
        /// </param>
        /// <param name="parameters"></param>
        public ConversationHistoryTranscriptToolCallClientDetails(
            string parameters,
            string? type)
        {
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallClientDetails" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallClientDetails()
        {
        }
    }
}