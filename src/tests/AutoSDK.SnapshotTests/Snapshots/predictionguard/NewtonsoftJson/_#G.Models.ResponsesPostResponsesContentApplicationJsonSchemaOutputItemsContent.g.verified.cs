//HintName: G.Models.ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content for the output object.
    /// </summary>
    public sealed partial class ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent
    {
        /// <summary>
        /// The output text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The type of output content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The output text.
        /// </param>
        /// <param name="type">
        /// The type of output content.
        /// </param>
        public ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent(
            string? text,
            string? type)
        {
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent" /> class.
        /// </summary>
        public ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent()
        {
        }
    }
}