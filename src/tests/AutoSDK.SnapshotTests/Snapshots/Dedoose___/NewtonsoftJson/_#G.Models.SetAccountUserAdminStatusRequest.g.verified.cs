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
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isAdmin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAdmin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountUserAdminStatusRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="isAdmin"></param>
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