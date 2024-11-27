//HintName: G.Models.SetAccountUserAdminStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetAccountUserAdminStatusRequest
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdmin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountUserAdminStatusRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="isAdmin"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SetAccountUserAdminStatusRequest(
            global::System.Guid accountId,
            global::System.Guid userId,
            bool isAdmin)
        {
            this.AccountId = accountId;
            this.UserId = userId;
            this.IsAdmin = isAdmin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountUserAdminStatusRequest" /> class.
        /// </summary>
        public SetAccountUserAdminStatusRequest()
        {
        }
    }
}