//HintName: G.Models.GetAuthSessionInfoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing user session information
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponse
    {
        /// <summary>
        /// Details of the current active project (null if accessing with org-level credentials)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::G.GetAuthSessionInfoResponseProject? Project { get; set; }

        /// <summary>
        /// Details of the API key used for authentication (null if using session auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::G.GetAuthSessionInfoResponseApiKey? ApiKey { get; set; }

        /// <summary>
        /// Information about the authenticated user<br/>
        /// Example: {"id":"550e8400-e29b-41d4-a716-446655440002","email":"user@example.com","name":"John Doe","role":"admin"}
        /// </summary>
        /// <example>{"id":"550e8400-e29b-41d4-a716-446655440002","email":"user@example.com","name":"John Doe","role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAuthSessionInfoResponseOrgMember OrgMember { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponse" /> class.
        /// </summary>
        /// <param name="orgMember">
        /// Information about the authenticated user<br/>
        /// Example: {"id":"550e8400-e29b-41d4-a716-446655440002","email":"user@example.com","name":"John Doe","role":"admin"}
        /// </param>
        /// <param name="project">
        /// Details of the current active project (null if accessing with org-level credentials)
        /// </param>
        /// <param name="apiKey">
        /// Details of the API key used for authentication (null if using session auth)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthSessionInfoResponse(
            global::G.GetAuthSessionInfoResponseOrgMember orgMember,
            global::G.GetAuthSessionInfoResponseProject? project,
            global::G.GetAuthSessionInfoResponseApiKey? apiKey)
        {
            this.Project = project;
            this.ApiKey = apiKey;
            this.OrgMember = orgMember ?? throw new global::System.ArgumentNullException(nameof(orgMember));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponse" /> class.
        /// </summary>
        public GetAuthSessionInfoResponse()
        {
        }
    }
}