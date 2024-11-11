//HintName: G.Models.CodeSecurityDefaultConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityDefaultConfiguration
    {
        /// <summary>
        /// The visibility of newly created repositories for which the code security configuration will be applied to by default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_for_new_repos")]
        public global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos? DefaultForNewRepos { get; set; }

        /// <summary>
        /// A code security configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.CodeSecurityConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityDefaultConfiguration" /> class.
        /// </summary>
        /// <param name="defaultForNewRepos">
        /// The visibility of newly created repositories for which the code security configuration will be applied to by default
        /// </param>
        /// <param name="configuration">
        /// A code security configuration
        /// </param>
        public CodeSecurityDefaultConfiguration(
            global::G.CodeSecurityDefaultConfigurationDefaultForNewRepos? defaultForNewRepos,
            global::G.CodeSecurityConfiguration? configuration)
        {
            this.DefaultForNewRepos = defaultForNewRepos;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityDefaultConfiguration" /> class.
        /// </summary>
        public CodeSecurityDefaultConfiguration()
        {
        }
    }
}