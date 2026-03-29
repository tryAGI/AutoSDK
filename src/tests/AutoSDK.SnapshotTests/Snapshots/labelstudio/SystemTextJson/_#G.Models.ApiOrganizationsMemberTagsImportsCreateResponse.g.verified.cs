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
        [global::System.Text.Json.Serialization.JsonPropertyName("import")]
        public int? Import { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsImportsCreateResponse" /> class.
        /// </summary>
        /// <param name="import">
        /// The ID of the created import job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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