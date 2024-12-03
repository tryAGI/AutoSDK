//HintName: G.Models.RepositoryAdvisoryCredit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A credit given to a user for a repository security advisory.
    /// </summary>
    public sealed partial class RepositoryAdvisoryCredit
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
        /// The state of the user's acceptance of the credit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryCreditState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCredit" /> class.
        /// </summary>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="type">
        /// The type of credit the user is receiving.
        /// </param>
        /// <param name="state">
        /// The state of the user's acceptance of the credit.
        /// </param>
        public RepositoryAdvisoryCredit(
            global::G.SimpleUser user,
            global::G.SecurityAdvisoryCreditTypes type,
            global::G.RepositoryAdvisoryCreditState state)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Type = type;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCredit" /> class.
        /// </summary>
        public RepositoryAdvisoryCredit()
        {
        }
    }
}