//HintName: G.Models.ProjectsCreateApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateApiKeyRequest
    {
        /// <summary>
        /// Optional note for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Optional predefined public key. Must start with 'pk-lf-'. If provided, secretKey must also be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// Optional predefined secret key. Must start with 'sk-lf-'. If provided, publicKey must also be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretKey")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="note">
        /// Optional note for the API key
        /// </param>
        /// <param name="publicKey">
        /// Optional predefined public key. Must start with 'pk-lf-'. If provided, secretKey must also be provided.
        /// </param>
        /// <param name="secretKey">
        /// Optional predefined secret key. Must start with 'sk-lf-'. If provided, publicKey must also be provided.
        /// </param>
        public ProjectsCreateApiKeyRequest(
            string? note,
            string? publicKey,
            string? secretKey)
        {
            this.Note = note;
            this.PublicKey = publicKey;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateApiKeyRequest" /> class.
        /// </summary>
        public ProjectsCreateApiKeyRequest()
        {
        }
    }
}