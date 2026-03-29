//HintName: G.Models.DeleteMcpServersByServerIdInstancesByInstanceIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMcpServersByServerIdInstancesByInstanceIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_connected_accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DeletedConnectedAccounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMcpServersByServerIdInstancesByInstanceIdResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="deletedConnectedAccounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMcpServersByServerIdInstancesByInstanceIdResponse(
            string message,
            double deletedConnectedAccounts)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DeletedConnectedAccounts = deletedConnectedAccounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMcpServersByServerIdInstancesByInstanceIdResponse" /> class.
        /// </summary>
        public DeleteMcpServersByServerIdInstancesByInstanceIdResponse()
        {
        }
    }
}