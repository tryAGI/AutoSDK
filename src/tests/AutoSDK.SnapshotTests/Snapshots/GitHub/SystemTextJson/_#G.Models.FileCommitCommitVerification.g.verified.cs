//HintName: G.Models.FileCommitCommitVerification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCommitCommitVerification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitVerification" /> class.
        /// </summary>
        /// <param name="verified"></param>
        /// <param name="reason"></param>
        /// <param name="signature"></param>
        /// <param name="payload"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FileCommitCommitVerification(
            bool? verified,
            string? reason,
            string? signature,
            string? payload)
        {
            this.Verified = verified;
            this.Reason = reason;
            this.Signature = signature;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitVerification" /> class.
        /// </summary>
        public FileCommitCommitVerification()
        {
        }
    }
}