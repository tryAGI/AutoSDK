//HintName: G.Models.CheckEncryptedDataRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckEncryptedDataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedSymKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedSymKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEncryptedDataRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="encryptedSymKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CheckEncryptedDataRequest(
            global::System.Guid projectId,
            string encryptedSymKey)
        {
            this.ProjectId = projectId;
            this.EncryptedSymKey = encryptedSymKey ?? throw new global::System.ArgumentNullException(nameof(encryptedSymKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEncryptedDataRequest" /> class.
        /// </summary>
        public CheckEncryptedDataRequest()
        {
        }
    }
}