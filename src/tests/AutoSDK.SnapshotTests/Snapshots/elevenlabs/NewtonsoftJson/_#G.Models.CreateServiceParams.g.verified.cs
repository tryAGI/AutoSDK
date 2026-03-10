//HintName: G.Models.CreateServiceParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new service in the system.
    /// </summary>
    public sealed partial class CreateServiceParams
    {
        /// <summary>
        /// Default Value: create_service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: create_service
        /// </param>
        public CreateServiceParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceParams" /> class.
        /// </summary>
        public CreateServiceParams()
        {
        }
    }
}