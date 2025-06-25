﻿//HintName: G.Models.ReposAddCollaboratorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposAddCollaboratorRequest
    {
        /// <summary>
        /// The permission to grant the collaborator. **Only valid on organization-owned repositories.** We accept the following permissions to be set: `pull`, `triage`, `push`, `maintain`, `admin` and you can also specify a custom repository role name, if the owning organization has defined any.<br/>
        /// Default Value: push
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddCollaboratorRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant the collaborator. **Only valid on organization-owned repositories.** We accept the following permissions to be set: `pull`, `triage`, `push`, `maintain`, `admin` and you can also specify a custom repository role name, if the owning organization has defined any.<br/>
        /// Default Value: push
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposAddCollaboratorRequest(
            string? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddCollaboratorRequest" /> class.
        /// </summary>
        public ReposAddCollaboratorRequest()
        {
        }
    }
}