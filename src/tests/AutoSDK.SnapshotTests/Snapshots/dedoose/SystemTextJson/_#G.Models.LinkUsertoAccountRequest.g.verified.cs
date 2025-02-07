//HintName: G.Models.LinkUsertoAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkUsertoAccountRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUsertoAccountRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkUsertoAccountRequest(
            global::System.Guid userId,
            global::System.Guid accountId)
        {
            this.UserId = userId;
            this.AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUsertoAccountRequest" /> class.
        /// </summary>
        public LinkUsertoAccountRequest()
        {
        }
    }
}