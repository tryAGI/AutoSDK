//HintName: G.Models.IndexesIndexedAssetsCreateResponse202.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexesIndexedAssetsCreateResponse202
    {
        /// <summary>
        /// The unique identifier of the indexed asset. Use it to monitor the indexing progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexedAssetsCreateResponse202" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the indexed asset. Use it to monitor the indexing progress.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexesIndexedAssetsCreateResponse202(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexedAssetsCreateResponse202" /> class.
        /// </summary>
        public IndexesIndexedAssetsCreateResponse202()
        {
        }
    }
}