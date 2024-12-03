//HintName: G.Models.CodespacesPreFlightWithRepoForAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesPreFlightWithRepoForAuthenticatedUserResponse
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable_owner")]
        public global::G.SimpleUser? BillableOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaults")]
        public global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults? Defaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="billableOwner">
        /// A GitHub user.
        /// </param>
        /// <param name="defaults"></param>
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponse(
            global::G.SimpleUser? billableOwner,
            global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults? defaults)
        {
            this.BillableOwner = billableOwner;
            this.Defaults = defaults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponse" /> class.
        /// </summary>
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponse()
        {
        }
    }
}