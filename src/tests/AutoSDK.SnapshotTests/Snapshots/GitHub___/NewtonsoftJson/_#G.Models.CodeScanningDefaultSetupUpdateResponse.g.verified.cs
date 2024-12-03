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
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public int? RunId { get; set; }

        /// <summary>
        /// URL of the corresponding run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_url")]
        public string? RunUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdateResponse" /> class.
        /// </summary>
        /// <param name="runId">
        /// ID of the corresponding run.
        /// </param>
        /// <param name="runUrl">
        /// URL of the corresponding run.
        /// </param>
        public CodeScanningDefaultSetupUpdateResponse(
            int? runId,
            string? runUrl)
        {
            this.RunId = runId;
            this.RunUrl = runUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdateResponse" /> class.
        /// </summary>
        public CodeScanningDefaultSetupUpdateResponse()
        {
        }
    }
}