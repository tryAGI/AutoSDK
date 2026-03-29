//HintName: G.Models.ApiOrganizationsMemberTagsBulkCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOrganizationsMemberTagsBulkCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsBulkCreateResponse" /> class.
        /// </summary>
        /// <param name="created"></param>
        public ApiOrganizationsMemberTagsBulkCreateResponse(
            int? created)
        {
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsBulkCreateResponse" /> class.
        /// </summary>
        public ApiOrganizationsMemberTagsBulkCreateResponse()
        {
        }
    }
}