//HintName: G.Models.GetAccountDetailsForCurrentUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAccountDetailsForCurrentUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AccountVO Account { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.User> Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountDetailsForCurrentUserResponse" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="users"></param>
        public GetAccountDetailsForCurrentUserResponse(
            global::G.AccountVO account,
            global::System.Collections.Generic.IList<global::G.User> users)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountDetailsForCurrentUserResponse" /> class.
        /// </summary>
        public GetAccountDetailsForCurrentUserResponse()
        {
        }
    }
}