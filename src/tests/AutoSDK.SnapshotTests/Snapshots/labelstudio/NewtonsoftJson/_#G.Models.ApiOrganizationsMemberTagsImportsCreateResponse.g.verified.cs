//HintName: G.Models.ApiOrganizationsMemberTagsImportsCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOrganizationsMemberTagsImportsCreateResponse
    {
        /// <summary>
        /// The ID of the created import job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("import")]
        public int? Import { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsImportsCreateResponse" /> class.
        /// </summary>
        /// <param name="import">
        /// The ID of the created import job
        /// </param>
        public ApiOrganizationsMemberTagsImportsCreateResponse(
            int? import)
        {
            this.Import = import;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsImportsCreateResponse" /> class.
        /// </summary>
        public ApiOrganizationsMemberTagsImportsCreateResponse()
        {
        }
    }
}