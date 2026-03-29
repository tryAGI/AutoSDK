//HintName: G.Models.ApiProjectsImportPredictionsCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Import result
    /// </summary>
    public sealed partial class ApiProjectsImportPredictionsCreateResponse
    {
        /// <summary>
        /// Number of predictions created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsImportPredictionsCreateResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// Number of predictions created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsImportPredictionsCreateResponse(
            int? created)
        {
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsImportPredictionsCreateResponse" /> class.
        /// </summary>
        public ApiProjectsImportPredictionsCreateResponse()
        {
        }
    }
}