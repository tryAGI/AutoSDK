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
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_connected_accounts", Required = global::Newtonsoft.Json.Required.Always)]
        public double DeletedConnectedAccounts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMcpServersByServerIdInstancesByInstanceIdResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="deletedConnectedAccounts"></param>
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