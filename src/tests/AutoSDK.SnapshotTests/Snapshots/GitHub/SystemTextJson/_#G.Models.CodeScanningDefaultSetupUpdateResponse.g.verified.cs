//HintName: G.Models.CodeScanningDefaultSetupUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// You can use `run_url` to track the status of the run. This includes a property status and conclusion.<br/>
    /// You should not rely on this always being an actions workflow run object.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdateResponse
    {
        /// <summary>
        /// ID of the corresponding run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public int? RunId { get; set; }

        /// <summary>
        /// URL of the corresponding run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_url")]
        public string? RunUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}