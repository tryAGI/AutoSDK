//HintName: G.Models.GlobalAdvisoryCredit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalAdvisoryCredit
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser User { get; set; } = default!;

        /// <summary>
        /// The type of credit the user is receiving.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SecurityAdvisoryCreditTypes Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryCredit" /> class.
        /// </summary>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="type">
        /// The type of credit the user is receiving.
        /// </param>
        public GlobalAdvisoryCredit(
            global::G.SimpleUser user,
            global::G.SecurityAdvisoryCreditTypes type)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryCredit" /> class.
        /// </summary>
        public GlobalAdvisoryCredit()
        {
        }
    }
}