//HintName: G.Models.DeleteServiceParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delete an existing service from the system.
    /// </summary>
    public sealed partial class DeleteServiceParams
    {
        /// <summary>
        /// Default Value: delete_service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: delete_service
        /// </param>
        public DeleteServiceParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceParams" /> class.
        /// </summary>
        public DeleteServiceParams()
        {
        }
    }
}