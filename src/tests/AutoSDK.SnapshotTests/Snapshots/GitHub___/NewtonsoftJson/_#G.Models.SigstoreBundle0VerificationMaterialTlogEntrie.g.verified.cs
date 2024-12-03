//HintName: G.Models.SigstoreBundle0VerificationMaterialTlogEntrie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterialTlogEntrie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logIndex")]
        public string? LogIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logId")]
        public global::G.SigstoreBundle0VerificationMaterialTlogEntrieLogId? LogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kindVersion")]
        public global::G.SigstoreBundle0VerificationMaterialTlogEntrieKindVersion? KindVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integratedTime")]
        public string? IntegratedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inclusionPromise")]
        public global::G.SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise? InclusionPromise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inclusionProof")]
        public string? InclusionProof { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canonicalizedBody")]
        public string? CanonicalizedBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrie" /> class.
        /// </summary>
        /// <param name="logIndex"></param>
        /// <param name="logId"></param>
        /// <param name="kindVersion"></param>
        /// <param name="integratedTime"></param>
        /// <param name="inclusionPromise"></param>
        /// <param name="inclusionProof"></param>
        /// <param name="canonicalizedBody"></param>
        public SigstoreBundle0VerificationMaterialTlogEntrie(
            string? logIndex,
            global::G.SigstoreBundle0VerificationMaterialTlogEntrieLogId? logId,
            global::G.SigstoreBundle0VerificationMaterialTlogEntrieKindVersion? kindVersion,
            string? integratedTime,
            global::G.SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise? inclusionPromise,
            string? inclusionProof,
            string? canonicalizedBody)
        {
            this.LogIndex = logIndex;
            this.LogId = logId;
            this.KindVersion = kindVersion;
            this.IntegratedTime = integratedTime;
            this.InclusionPromise = inclusionPromise;
            this.InclusionProof = inclusionProof;
            this.CanonicalizedBody = canonicalizedBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrie" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterialTlogEntrie()
        {
        }
    }
}