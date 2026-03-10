//HintName: G.Models.CheckServiceAvailabilityParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckServiceAvailabilityParams
    {
        /// <summary>
        /// Default Value: check_service_availability
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckServiceAvailabilityParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: check_service_availability
        /// </param>
        public CheckServiceAvailabilityParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckServiceAvailabilityParams" /> class.
        /// </summary>
        public CheckServiceAvailabilityParams()
        {
        }
    }
}