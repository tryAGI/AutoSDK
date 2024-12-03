//HintName: G.Models.CodeSecurityConfigurationForRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code security configuration associated with a repository and attachment status
    /// </summary>
    public sealed partial class CodeSecurityConfigurationForRepository
    {
        /// <summary>
        /// The attachment status of the code security configuration on the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.CodeSecurityConfigurationForRepositoryStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationForRepository" /> class.
        /// </summary>
        /// <param name="status">
        /// The attachment status of the code security configuration on the repository.
        /// </param>
        /// <param name="configuration">
        /// A code security configuration
        /// </param>
        public CodeSecurityConfigurationForRepository(
            global::G.CodeSecurityConfigurationForRepositoryStatus? status,
            global::G.CodeSecurityConfiguration? configuration)
        {
            this.Status = status;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationForRepository" /> class.
        /// </summary>
        public CodeSecurityConfigurationForRepository()
        {
        }
    }
}