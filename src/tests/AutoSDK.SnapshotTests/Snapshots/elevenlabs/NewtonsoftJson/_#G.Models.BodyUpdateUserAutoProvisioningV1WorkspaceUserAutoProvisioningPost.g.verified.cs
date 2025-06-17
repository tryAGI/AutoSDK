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
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost" /> class.
        /// </summary>
        /// <param name="enabled"></param>
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