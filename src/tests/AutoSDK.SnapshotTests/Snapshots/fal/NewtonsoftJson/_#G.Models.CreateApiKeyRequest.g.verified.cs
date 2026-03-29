//HintName: G.Models.CreateApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating a new API key
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// Required friendly name for the API key<br/>
        /// Example: Production Key
        /// </summary>
        /// <example>Production Key</example>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="alias">
        /// Required friendly name for the API key<br/>
        /// Example: Production Key
        /// </param>
        public CreateApiKeyRequest(
            string alias)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }
    }
}