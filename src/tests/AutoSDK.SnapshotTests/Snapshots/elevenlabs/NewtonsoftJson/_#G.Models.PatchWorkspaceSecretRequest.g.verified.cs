﻿//HintName: G.Models.PatchWorkspaceSecretRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWorkspaceSecretRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PatchWorkspaceSecretRequestType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWorkspaceSecretRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public PatchWorkspaceSecretRequest(
            string name,
            string value,
            global::G.PatchWorkspaceSecretRequestType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWorkspaceSecretRequest" /> class.
        /// </summary>
        public PatchWorkspaceSecretRequest()
        {
        }
    }
}