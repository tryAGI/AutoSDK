//HintName: G.Models.CodeSecurityDetachConfigurationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityDetachConfigurationRequest
    {
        /// <summary>
        /// An array of repository IDs to detach from configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityDetachConfigurationRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs to detach from configurations.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeSecurityDetachConfigurationRequest(
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityDetachConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityDetachConfigurationRequest()
        {
        }
    }
}