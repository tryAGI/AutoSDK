//HintName: G.Models.UpdateCurrentUserPasswordRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCurrentUserPasswordRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedPass")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedPass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentUserPasswordRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="encryptedPass"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateCurrentUserPasswordRequest(
            global::System.Guid userId,
            string encryptedPass)
        {
            this.UserId = userId;
            this.EncryptedPass = encryptedPass ?? throw new global::System.ArgumentNullException(nameof(encryptedPass));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentUserPasswordRequest" /> class.
        /// </summary>
        public UpdateCurrentUserPasswordRequest()
        {
        }
    }
}