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
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey ApiKey { get; set; } = default!;

        /// <summary>
        /// Success message<br/>
        /// Example: API key regenerated successfully
        /// </summary>
        /// <example>API key regenerated successfully</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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