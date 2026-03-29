//HintName: G.Models.SaveDraftDatasetVersionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveDraftDatasetVersionResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// ID of the draft dataset being saved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DraftDatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDraftDatasetVersionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="draftDatasetId">
        /// ID of the draft dataset being saved
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveDraftDatasetVersionResponse(
            bool success,
            string message,
            int draftDatasetId)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DraftDatasetId = draftDatasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDraftDatasetVersionResponse" /> class.
        /// </summary>
        public SaveDraftDatasetVersionResponse()
        {
        }
    }
}