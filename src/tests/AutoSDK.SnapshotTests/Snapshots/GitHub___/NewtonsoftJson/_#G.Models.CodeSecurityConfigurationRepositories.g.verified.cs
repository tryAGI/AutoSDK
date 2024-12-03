//HintName: G.Models.CodeSecurityConfigurationRepositories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repositories associated with a code security configuration and attachment status
    /// </summary>
    public sealed partial class CodeSecurityConfigurationRepositories
    {
        /// <summary>
        /// The attachment status of the code security configuration on the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.CodeSecurityConfigurationRepositoriesStatus? Status { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.SimpleRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationRepositories" /> class.
        /// </summary>
        /// <param name="status">
        /// The attachment status of the code security configuration on the repository.
        /// </param>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        public CodeSecurityConfigurationRepositories(
            global::G.CodeSecurityConfigurationRepositoriesStatus? status,
            global::G.SimpleRepository? repository)
        {
            this.Status = status;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationRepositories" /> class.
        /// </summary>
        public CodeSecurityConfigurationRepositories()
        {
        }
    }
}