//HintName: G.Models.ContentEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of floats representing an embedding.
    /// </summary>
    public sealed partial class ContentEmbedding
    {
        /// <summary>
        /// The embedding values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<float>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentEmbedding" /> class.
        /// </summary>
        /// <param name="values">
        /// The embedding values.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ContentEmbedding(
            global::System.Collections.Generic.IList<float>? values)
        {
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentEmbedding" /> class.
        /// </summary>
        public ContentEmbedding()
        {
        }
    }
}