//HintName: G.Models.DeleteAssetParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAssetParams
    {
        /// <summary>
        /// Default Value: delete_asset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAssetParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: delete_asset
        /// </param>
        public DeleteAssetParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAssetParams" /> class.
        /// </summary>
        public DeleteAssetParams()
        {
        }
    }
}