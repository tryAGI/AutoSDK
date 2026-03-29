//HintName: G.Models.CreateChatLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatLogsResponse" /> class.
        /// </summary>
        /// <param name="exportId"></param>
        public CreateChatLogsResponse(
            string exportId)
        {
            this.ExportId = exportId ?? throw new global::System.ArgumentNullException(nameof(exportId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatLogsResponse" /> class.
        /// </summary>
        public CreateChatLogsResponse()
        {
        }
    }
}