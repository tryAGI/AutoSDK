﻿//HintName: G.Models.BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost" /> class.
        /// </summary>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost" /> class.
        /// </summary>
        public BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost()
        {
        }
    }
}