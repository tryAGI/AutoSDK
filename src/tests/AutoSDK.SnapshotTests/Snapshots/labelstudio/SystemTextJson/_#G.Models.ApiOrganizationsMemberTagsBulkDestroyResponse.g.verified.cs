//HintName: G.Models.ApiOrganizationsMemberTagsBulkDestroyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOrganizationsMemberTagsBulkDestroyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public int? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsBulkDestroyResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOrganizationsMemberTagsBulkDestroyResponse(
            int? deleted)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsBulkDestroyResponse" /> class.
        /// </summary>
        public ApiOrganizationsMemberTagsBulkDestroyResponse()
        {
        }
    }
}