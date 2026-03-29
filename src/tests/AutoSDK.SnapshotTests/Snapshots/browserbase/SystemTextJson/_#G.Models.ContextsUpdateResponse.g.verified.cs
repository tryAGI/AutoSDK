//HintName: G.Models.ContextsUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextsUpdateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An upload URL to upload a custom user-data-directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// The public key to encrypt the user-data-directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// The cipher algorithm used to encrypt the user-data-directory. AES-256-CBC is currently the only supported algorithm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cipherAlgorithm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CipherAlgorithm { get; set; }

        /// <summary>
        /// The initialization vector size used to encrypt the user-data-directory. [Read more about how to use it](/features/contexts).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initializationVectorSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte InitializationVectorSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsUpdateResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextsUpdateResponse(
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
        /// Initializes a new instance of the <see cref="ContextsUpdateResponse" /> class.
        /// </summary>
        public ContextsUpdateResponse()
        {
        }
    }
}