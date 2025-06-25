﻿//HintName: G.Models.CodeSecurityAttachConfigurationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityAttachConfigurationRequest
    {
        /// <summary>
        /// The type of repositories to attach the configuration to. `selected` means the configuration will be attached to only the repositories specified by `selected_repository_ids`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityAttachConfigurationRequestScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeSecurityAttachConfigurationRequestScope Scope { get; set; }

        /// <summary>
        /// An array of repository IDs to attach the configuration to. You can only provide a list of repository ids when the `scope` is set to `selected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityAttachConfigurationRequest" /> class.
        /// </summary>
        /// <param name="scope">
        /// The type of repositories to attach the configuration to. `selected` means the configuration will be attached to only the repositories specified by `selected_repository_ids`
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs to attach the configuration to. You can only provide a list of repository ids when the `scope` is set to `selected`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityAttachConfigurationRequest(
            global::G.CodeSecurityAttachConfigurationRequestScope scope,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds)
        {
            this.Scope = scope;
            this.SelectedRepositoryIds = selectedRepositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityAttachConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityAttachConfigurationRequest()
        {
        }
    }
}