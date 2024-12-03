//HintName: G.Models.RevokeAdminRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RevokeAdminRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeAdminRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RevokeAdminRequest(
            global::System.Guid accountId,
            global::System.Guid userId)
        {
            this.AccountId = accountId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeAdminRequest" /> class.
        /// </summary>
        public RevokeAdminRequest()
        {
        }
    }
}