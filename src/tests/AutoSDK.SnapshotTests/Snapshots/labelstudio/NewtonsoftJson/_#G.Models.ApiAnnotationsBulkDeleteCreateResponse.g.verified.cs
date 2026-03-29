//HintName: G.Models.ApiAnnotationsBulkDeleteCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiAnnotationsBulkDeleteCreateResponse
    {
        /// <summary>
        /// Number of annotations deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_count")]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationsBulkDeleteCreateResponse" /> class.
        /// </summary>
        /// <param name="deletedCount">
        /// Number of annotations deleted
        /// </param>
        public ApiAnnotationsBulkDeleteCreateResponse(
            int? deletedCount)
        {
            this.DeletedCount = deletedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAnnotationsBulkDeleteCreateResponse" /> class.
        /// </summary>
        public ApiAnnotationsBulkDeleteCreateResponse()
        {
        }
    }
}