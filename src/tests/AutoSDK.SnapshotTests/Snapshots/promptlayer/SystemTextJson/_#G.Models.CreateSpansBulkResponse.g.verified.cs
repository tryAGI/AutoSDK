//HintName: G.Models.CreateSpansBulkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpansBulkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_logs")]
        public global::System.Collections.Generic.IList<object>? RequestLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulkResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="spans"></param>
        /// <param name="requestLogs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpansBulkResponse(
            bool success,
            global::System.Collections.Generic.IList<object> spans,
            global::System.Collections.Generic.IList<object>? requestLogs)
        {
            this.Success = success;
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.RequestLogs = requestLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulkResponse" /> class.
        /// </summary>
        public CreateSpansBulkResponse()
        {
        }
    }
}