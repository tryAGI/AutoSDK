//HintName: G.Models.BalanceResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"credits":0.07903292496944721}
    /// </summary>
    public sealed partial class BalanceResponseBody
    {
        /// <summary>
        /// The balance of the account/organization associated with the API key<br/>
        /// Example: 0.41122252F
        /// </summary>
        /// <example>0.41122252F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseBody" /> class.
        /// </summary>
        /// <param name="credits">
        /// The balance of the account/organization associated with the API key<br/>
        /// Example: 0.41122252F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceResponseBody(
            double credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseBody" /> class.
        /// </summary>
        public BalanceResponseBody()
        {
        }
    }
}