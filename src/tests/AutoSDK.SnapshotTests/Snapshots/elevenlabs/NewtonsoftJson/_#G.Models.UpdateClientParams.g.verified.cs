//HintName: G.Models.UpdateClientParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update an existing client's information.
    /// </summary>
    public sealed partial class UpdateClientParams
    {
        /// <summary>
        /// Default Value: update_client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: update_client
        /// </param>
        public UpdateClientParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientParams" /> class.
        /// </summary>
        public UpdateClientParams()
        {
        }
    }
}