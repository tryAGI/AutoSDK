//HintName: G.Models.ChatSearchQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generated search query. Contains the text of the query and a unique identifier for the query.
    /// </summary>
    public sealed partial class ChatSearchQuery
    {
        /// <summary>
        /// Unique identifier for the generated search query. Useful for submitting feedback.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GenerationId { get; set; } = default!;

        /// <summary>
        /// The text of the search query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQuery" /> class.
        /// </summary>
        /// <param name="generationId">
        /// Unique identifier for the generated search query. Useful for submitting feedback.
        /// </param>
        /// <param name="text">
        /// The text of the search query.
        /// </param>
        public ChatSearchQuery(
            global::System.Guid generationId,
            string text)
        {
            this.GenerationId = generationId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQuery" /> class.
        /// </summary>
        public ChatSearchQuery()
        {
        }
    }
}