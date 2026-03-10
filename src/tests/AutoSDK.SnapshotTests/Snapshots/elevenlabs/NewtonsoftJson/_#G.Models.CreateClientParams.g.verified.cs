//HintName: G.Models.CreateClientParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new client in the system.
    /// </summary>
    public sealed partial class CreateClientParams
    {
        /// <summary>
        /// Default Value: create_client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: create_client
        /// </param>
        public CreateClientParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientParams" /> class.
        /// </summary>
        public CreateClientParams()
        {
        }
    }
}