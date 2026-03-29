//HintName: G.Models.TokenizePostResponsesContentApplicationJsonSchemaTokensItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizePostResponsesContentApplicationJsonSchemaTokensItems
    {
        /// <summary>
        /// The converted token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The index the token starts at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Start { get; set; }

        /// <summary>
        /// The index the token ends at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public int? Stop { get; set; }

        /// <summary>
        /// The token as text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizePostResponsesContentApplicationJsonSchemaTokensItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The converted token.
        /// </param>
        /// <param name="start">
        /// The index the token starts at.
        /// </param>
        /// <param name="stop">
        /// The index the token ends at.
        /// </param>
        /// <param name="text">
        /// The token as text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizePostResponsesContentApplicationJsonSchemaTokensItems(
            int? id,
            int? start,
            int? stop,
            string? text)
        {
            this.Id = id;
            this.Start = start;
            this.Stop = stop;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizePostResponsesContentApplicationJsonSchemaTokensItems" /> class.
        /// </summary>
        public TokenizePostResponsesContentApplicationJsonSchemaTokensItems()
        {
        }
    }
}