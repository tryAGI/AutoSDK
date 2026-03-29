//HintName: G.Models.ContextsCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextsCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An upload URL to upload a custom user-data-directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadUrl { get; set; } = default!;

        /// <summary>
        /// The public key to encrypt the user-data-directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; } = default!;

        /// <summary>
        /// The cipher algorithm used to encrypt the user-data-directory. AES-256-CBC is currently the only supported algorithm.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cipherAlgorithm", Required = global::Newtonsoft.Json.Required.Always)]
        public string CipherAlgorithm { get; set; } = default!;

        /// <summary>
        /// The initialization vector size used to encrypt the user-data-directory. [Read more about how to use it](/features/contexts).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initializationVectorSize", Required = global::Newtonsoft.Json.Required.Always)]
        public byte InitializationVectorSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsCreateResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uploadUrl">
        /// An upload URL to upload a custom user-data-directory.
        /// </param>
        /// <param name="publicKey">
        /// The public key to encrypt the user-data-directory.
        /// </param>
        /// <param name="cipherAlgorithm">
        /// The cipher algorithm used to encrypt the user-data-directory. AES-256-CBC is currently the only supported algorithm.
        /// </param>
        /// <param name="initializationVectorSize">
        /// The initialization vector size used to encrypt the user-data-directory. [Read more about how to use it](/features/contexts).
        /// </param>
        public ContextsCreateResponse(
            string id,
            string uploadUrl,
            string publicKey,
            string cipherAlgorithm,
            byte initializationVectorSize)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.CipherAlgorithm = cipherAlgorithm ?? throw new global::System.ArgumentNullException(nameof(cipherAlgorithm));
            this.InitializationVectorSize = initializationVectorSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsCreateResponse" /> class.
        /// </summary>
        public ContextsCreateResponse()
        {
        }
    }
}