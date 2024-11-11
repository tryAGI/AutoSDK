//HintName: G.Models.ActionsWorkflowAccessToRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsWorkflowAccessToRepository
    {
        /// <summary>
        /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the<br/>
        /// repository.<br/>
        /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActionsWorkflowAccessToRepositoryAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActionsWorkflowAccessToRepositoryAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsWorkflowAccessToRepository" /> class.
        /// </summary>
        /// <param name="accessLevel">
        /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the<br/>
        /// repository.<br/>
        /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsWorkflowAccessToRepository(
            global::G.ActionsWorkflowAccessToRepositoryAccessLevel accessLevel)
        {
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsWorkflowAccessToRepository" /> class.
        /// </summary>
        public ActionsWorkflowAccessToRepository()
        {
        }
    }
}