//HintName: G.Models.GetClientByPhoneParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Look up a client by their exact phone number.
    /// </summary>
    public sealed partial class GetClientByPhoneParams
    {
        /// <summary>
        /// Default Value: get_client_by_phone
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientByPhoneParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_client_by_phone
        /// </param>
        public GetClientByPhoneParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientByPhoneParams" /> class.
        /// </summary>
        public GetClientByPhoneParams()
        {
        }
    }
}