//HintName: G.Models.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse
    {
        /// <summary>
        /// The newly generated API key for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey ApiKey { get; set; }

        /// <summary>
        /// Success message<br/>
        /// Example: API key regenerated successfully
        /// </summary>
        /// <example>API key regenerated successfully</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The newly generated API key for this project
        /// </param>
        /// <param name="message">
        /// Success message<br/>
        /// Example: API key regenerated successfully
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse(
            global::G.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey apiKey,
            string message)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse" /> class.
        /// </summary>
        public PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse()
        {
        }
    }
}