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
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// The type of credit the user is receiving.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecurityAdvisoryCreditTypesJsonConverter))]
        public global::G.SecurityAdvisoryCreditTypes? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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