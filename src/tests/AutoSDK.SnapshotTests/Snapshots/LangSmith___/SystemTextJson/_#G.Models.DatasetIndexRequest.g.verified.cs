//HintName: G.Models.DatasetIndexRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class DatasetIndexRequest
    {
        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetIndexRequest" /> class.
        /// </summary>
        /// <param name="tag">
        /// Default Value: latest
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetIndexRequest(
            string? tag)
        {
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetIndexRequest" /> class.
        /// </summary>
        public DatasetIndexRequest()
        {
        }
    }
}