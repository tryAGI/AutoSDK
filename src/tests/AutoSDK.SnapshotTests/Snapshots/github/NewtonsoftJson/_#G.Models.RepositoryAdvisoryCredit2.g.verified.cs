//HintName: G.Models.RepositoryAdvisoryCredit2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCredit2
    {
        /// <summary>
        /// The username of the user credited.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// The type of credit the user is receiving.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SecurityAdvisoryCreditTypes? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCredit2" /> class.
        /// </summary>
        /// <param name="login">
        /// The username of the user credited.
        /// </param>
        /// <param name="type">
        /// The type of credit the user is receiving.
        /// </param>
        public RepositoryAdvisoryCredit2(
            string? login,
            global::G.SecurityAdvisoryCreditTypes? type)
        {
            this.Login = login;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCredit2" /> class.
        /// </summary>
        public RepositoryAdvisoryCredit2()
        {
        }
    }
}