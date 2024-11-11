//HintName: G.Models.AccountServiceGetAccountDetailsForCurrentUserControllerOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountServiceGetAccountDetailsForCurrentUserControllerOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account")]
        public global::G.AccountVO? Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<global::G.User>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountServiceGetAccountDetailsForCurrentUserControllerOutput" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="users"></param>
        public AccountServiceGetAccountDetailsForCurrentUserControllerOutput(
            global::G.AccountVO? account,
            global::System.Collections.Generic.IList<global::G.User>? users)
        {
            this.Account = account;
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountServiceGetAccountDetailsForCurrentUserControllerOutput" /> class.
        /// </summary>
        public AccountServiceGetAccountDetailsForCurrentUserControllerOutput()
        {
        }
    }
}