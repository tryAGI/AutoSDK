//HintName: G.Models.SearchDatasetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class SearchDatasetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SearchedFewShotExample> Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDatasetResponse" /> class.
        /// </summary>
        /// <param name="examples"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SearchDatasetResponse(
            global::System.Collections.Generic.IList<global::G.SearchedFewShotExample> examples)
        {
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDatasetResponse" /> class.
        /// </summary>
        public SearchDatasetResponse()
        {
        }
    }
}