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
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsImportPredictionsCreateResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// Number of predictions created
        /// </param>
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