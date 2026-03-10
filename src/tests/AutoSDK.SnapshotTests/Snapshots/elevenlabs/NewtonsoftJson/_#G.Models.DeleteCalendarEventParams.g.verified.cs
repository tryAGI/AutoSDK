//HintName: G.Models.DeleteCalendarEventParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteCalendarEventParams
    {
        /// <summary>
        /// Default Value: delete_calendar_event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCalendarEventParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: delete_calendar_event
        /// </param>
        public DeleteCalendarEventParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCalendarEventParams" /> class.
        /// </summary>
        public DeleteCalendarEventParams()
        {
        }
    }
}