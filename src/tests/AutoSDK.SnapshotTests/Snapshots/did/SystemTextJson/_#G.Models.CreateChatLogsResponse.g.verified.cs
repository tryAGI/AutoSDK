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
        [global::System.Text.Json.Serialization.JsonPropertyName("export_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatLogsResponse" /> class.
        /// </summary>
        /// <param name="exportId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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