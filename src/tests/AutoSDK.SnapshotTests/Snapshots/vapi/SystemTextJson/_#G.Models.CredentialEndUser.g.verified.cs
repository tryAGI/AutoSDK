//HintName: G.Models.CredentialEndUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialEndUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endUserEmail")]
        public string? EndUserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialEndUser" /> class.
        /// </summary>
        /// <param name="endUserId"></param>
        /// <param name="organizationId"></param>
        /// <param name="endUserEmail"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialEndUser(
            string endUserId,
            string organizationId,
            string? endUserEmail,
            object? tags)
        {
            this.EndUserEmail = endUserEmail;
            this.EndUserId = endUserId ?? throw new global::System.ArgumentNullException(nameof(endUserId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialEndUser" /> class.
        /// </summary>
        public CredentialEndUser()
        {
        }
    }
}