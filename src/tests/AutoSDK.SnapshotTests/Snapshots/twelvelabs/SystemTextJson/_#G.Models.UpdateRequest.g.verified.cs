//HintName: G.Models.UpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRequest
    {
        /// <summary>
        /// The name of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest" /> class.
        /// </summary>
        /// <param name="indexName">
        /// The name of the index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequest(
            string indexName)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest" /> class.
        /// </summary>
        public UpdateRequest()
        {
        }
    }
}