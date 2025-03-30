//HintName: G.Models.DeleteHistoryItemResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteHistoryItemResponse
    {
        /// <summary>
        /// The status of the deletion request. If the request was successful, the status will be 'ok'. Otherwise an error message with http code 500 will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHistoryItemResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the deletion request. If the request was successful, the status will be 'ok'. Otherwise an error message with http code 500 will be returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteHistoryItemResponse(
            string status)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHistoryItemResponse" /> class.
        /// </summary>
        public DeleteHistoryItemResponse()
        {
        }
    }
}