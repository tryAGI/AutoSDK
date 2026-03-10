//HintName: G.Models.GetClientAppointmentsParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClientAppointmentsParams
    {
        /// <summary>
        /// Default Value: get_client_appointments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientAppointmentsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_client_appointments
        /// </param>
        public GetClientAppointmentsParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientAppointmentsParams" /> class.
        /// </summary>
        public GetClientAppointmentsParams()
        {
        }
    }
}