//HintName: G.Models.CredentialGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class CredentialGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AuthError { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="authError"></param>
        public CredentialGet(
            string id,
            string provider,
            bool authError)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.AuthError = authError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialGet" /> class.
        /// </summary>
        public CredentialGet()
        {
        }
    }
}