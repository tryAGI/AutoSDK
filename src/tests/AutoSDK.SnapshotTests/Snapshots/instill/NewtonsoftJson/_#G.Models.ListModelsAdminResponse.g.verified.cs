//HintName: G.Models.ListModelsAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsAdminResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models")]
        public global::System.Collections.Generic.IList<global::G.Model>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsAdminResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="nextPageToken"></param>
        /// <param name="totalSize">
        /// Total number of models.
        /// </param>
        public ListModelsAdminResponse(
            global::System.Collections.Generic.IList<global::G.Model>? models,
            string? nextPageToken,
            int? totalSize)
        {
            this.Models = models;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsAdminResponse" /> class.
        /// </summary>
        public ListModelsAdminResponse()
        {
        }
    }
}