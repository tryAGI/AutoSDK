//HintName: G.Models.PostApiTermsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"terms_id":"TOS_2024_04_20"}
    /// </summary>
    public sealed partial class PostApiTermsRequest
    {
        /// <summary>
        /// The ID of the terms which are being accepted.<br/>
        /// Example: TOS_2024_04_20
        /// </summary>
        /// <example>TOS_2024_04_20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TermsId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiTermsRequest" /> class.
        /// </summary>
        /// <param name="termsId">
        /// The ID of the terms which are being accepted.<br/>
        /// Example: TOS_2024_04_20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostApiTermsRequest(
            string termsId)
        {
            this.TermsId = termsId ?? throw new global::System.ArgumentNullException(nameof(termsId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiTermsRequest" /> class.
        /// </summary>
        public PostApiTermsRequest()
        {
        }
    }
}