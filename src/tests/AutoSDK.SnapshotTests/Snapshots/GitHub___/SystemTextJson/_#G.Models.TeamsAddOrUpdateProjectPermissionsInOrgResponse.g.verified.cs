//HintName: G.Models.TeamsAddOrUpdateProjectPermissionsInOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsAddOrUpdateProjectPermissionsInOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateProjectPermissionsInOrgResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TeamsAddOrUpdateProjectPermissionsInOrgResponse(
            string? message,
            string? documentationUrl)
        {
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateProjectPermissionsInOrgResponse" /> class.
        /// </summary>
        public TeamsAddOrUpdateProjectPermissionsInOrgResponse()
        {
        }
    }
}