//HintName: G.Models.SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signedEntryTimestamp")]
        public string? SignedEntryTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise" /> class.
        /// </summary>
        /// <param name="signedEntryTimestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise(
            string? signedEntryTimestamp)
        {
            this.SignedEntryTimestamp = signedEntryTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterialTlogEntrieInclusionPromise()
        {
        }
    }
}