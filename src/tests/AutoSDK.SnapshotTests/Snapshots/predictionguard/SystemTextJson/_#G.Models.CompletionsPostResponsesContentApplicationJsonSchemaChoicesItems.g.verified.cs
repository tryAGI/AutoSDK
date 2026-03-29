//HintName: G.Models.CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The generated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="text">
        /// The generated text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems(
            int? index,
            string? text)
        {
            this.Index = index;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems" /> class.
        /// </summary>
        public CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems()
        {
        }
    }
}