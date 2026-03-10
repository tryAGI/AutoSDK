//HintName: G.Models.SearchClientsParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search for clients by name, phone number, or email.
    /// </summary>
    public sealed partial class SearchClientsParams
    {
        /// <summary>
        /// Default Value: search_clients
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchClientsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: search_clients
        /// </param>
        public SearchClientsParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchClientsParams" /> class.
        /// </summary>
        public SearchClientsParams()
        {
        }
    }
}