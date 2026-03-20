//HintName: G.Models.ChatStreamStartEvent5v9jyv.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamStartEvent5v9jyv
    {
        /// <summary>
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GenerationId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamStartEvent5v9jyv" /> class.
        /// </summary>
        /// <param name="generationId">
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </param>
        public ChatStreamStartEvent5v9jyv(
            global::System.Guid generationId)
        {
            this.GenerationId = generationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamStartEvent5v9jyv" /> class.
        /// </summary>
        public ChatStreamStartEvent5v9jyv()
        {
        }
    }
}