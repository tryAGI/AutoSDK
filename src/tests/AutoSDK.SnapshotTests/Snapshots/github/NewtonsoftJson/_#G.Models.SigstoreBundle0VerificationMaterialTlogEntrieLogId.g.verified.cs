//HintName: G.Models.SigstoreBundle0VerificationMaterialTlogEntrieLogId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterialTlogEntrieLogId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyId")]
        public string? KeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrieLogId" /> class.
        /// </summary>
        /// <param name="keyId"></param>
        public SigstoreBundle0VerificationMaterialTlogEntrieLogId(
            string? keyId)
        {
            this.KeyId = keyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrieLogId" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterialTlogEntrieLogId()
        {
        }
    }
}