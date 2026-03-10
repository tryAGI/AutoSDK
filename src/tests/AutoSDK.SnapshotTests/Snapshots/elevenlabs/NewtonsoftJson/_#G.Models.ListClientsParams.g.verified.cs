//HintName: G.Models.ListClientsParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List clients ordered by most recently updated, with an optional limit.
    /// </summary>
    public sealed partial class ListClientsParams
    {
        /// <summary>
        /// Default Value: list_clients
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClientsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: list_clients
        /// </param>
        public ListClientsParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClientsParams" /> class.
        /// </summary>
        public ListClientsParams()
        {
        }
    }
}