//HintName: G.Models.CodeSecuritySetConfigurationAsDefaultResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecuritySetConfigurationAsDefaultResponse
    {
        /// <summary>
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_for_new_repos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewReposJsonConverter))]
        public global::G.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos? DefaultForNewRepos { get; set; }

        /// <summary>
        /// A code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::G.CodeSecurityConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultResponse" /> class.
        /// </summary>
        /// <param name="defaultForNewRepos">
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </param>
        /// <param name="configuration">
        /// A code security configuration
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeSecuritySetConfigurationAsDefaultResponse(
            global::G.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos? defaultForNewRepos,
            global::G.CodeSecurityConfiguration? configuration)
        {
            this.DefaultForNewRepos = defaultForNewRepos;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultResponse" /> class.
        /// </summary>
        public CodeSecuritySetConfigurationAsDefaultResponse()
        {
        }
    }
}