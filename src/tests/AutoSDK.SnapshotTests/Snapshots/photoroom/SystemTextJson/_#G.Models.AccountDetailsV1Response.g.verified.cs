//HintName: G.Models.AccountDetailsV1Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AccountDetailsV1ResponseCredits Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1Response" /> class.
        /// </summary>
        /// <param name="credits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountDetailsV1Response(
            global::G.AccountDetailsV1ResponseCredits credits)
        {
            this.Credits = credits ?? throw new global::System.ArgumentNullException(nameof(credits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1Response" /> class.
        /// </summary>
        public AccountDetailsV1Response()
        {
        }
    }
}