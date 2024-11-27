//HintName: G.Models.GrantAdminRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GrantAdminRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantAdminRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        public GrantAdminRequest(
            global::System.Guid accountId,
            global::System.Guid userId)
        {
            this.AccountId = accountId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantAdminRequest" /> class.
        /// </summary>
        public GrantAdminRequest()
        {
        }
    }
}