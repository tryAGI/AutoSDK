//HintName: G.Models.CodeScanningSarifsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningSarifsStatus
    {
        /// <summary>
        /// `pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        public string? ProcessingStatus { get; set; }

        /// <summary>
        /// The REST API URL for getting the analyses associated with the upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyses_url")]
        public string? AnalysesUrl { get; set; }

        /// <summary>
        /// Any errors that ocurred during processing of the delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string?>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}