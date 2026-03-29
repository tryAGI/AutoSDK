//HintName: G.Models.CreateGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGuardrailRequest
    {
        /// <summary>
        /// Name of the guardrail<br/>
        /// Example: Content Safety Check
        /// </summary>
        /// <example>Content Safety Check</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Workspace UUID (required if organisation_id not provided and not using API key)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Organisation UUID (required if workspace_id not provided and not using API key)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Array of guardrail checks to apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GuardrailCheck> Checks { get; set; }

        /// <summary>
        /// Actions to take when guardrail checks fail or pass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuardrailActions Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the guardrail<br/>
        /// Example: Content Safety Check
        /// </param>
        /// <param name="checks">
        /// Array of guardrail checks to apply
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        /// <param name="workspaceId">
        /// Workspace UUID (required if organisation_id not provided and not using API key)
        /// </param>
        /// <param name="organisationId">
        /// Organisation UUID (required if workspace_id not provided and not using API key)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailRequest(
            string name,
            global::System.Collections.Generic.IList<global::G.GuardrailCheck> checks,
            global::G.GuardrailActions actions,
            global::System.Guid? workspaceId,
            global::System.Guid? organisationId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        public CreateGuardrailRequest()
        {
        }
    }
}