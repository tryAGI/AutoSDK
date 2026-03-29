//HintName: G.Models.ScanFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScanFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("policyUUID")]
        public string? PolicyUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("policy")]
        public global::G.FileScanPolicy? Policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestMetadata")]
        public string? RequestMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanFileRequest" /> class.
        /// </summary>
        /// <param name="policyUUID"></param>
        /// <param name="policy"></param>
        /// <param name="requestMetadata"></param>
        public ScanFileRequest(
            string? policyUUID,
            global::G.FileScanPolicy? policy,
            string? requestMetadata)
        {
            this.PolicyUUID = policyUUID;
            this.Policy = policy;
            this.RequestMetadata = requestMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanFileRequest" /> class.
        /// </summary>
        public ScanFileRequest()
        {
        }
    }
}