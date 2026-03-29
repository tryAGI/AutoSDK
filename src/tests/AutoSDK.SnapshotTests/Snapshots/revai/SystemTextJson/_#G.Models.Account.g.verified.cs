//HintName: G.Models.Account.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai Account Model
    /// </summary>
    public sealed partial class Account
    {
        /// <summary>
        /// Email of developer account<br/>
        /// Example: jay@rev.ai
        /// </summary>
        /// <example>jay@rev.ai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Amount of Rev.ai API credits remaining in seconds<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_seconds")]
        public int? BalanceSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of developer account<br/>
        /// Example: jay@rev.ai
        /// </param>
        /// <param name="balanceSeconds">
        /// Amount of Rev.ai API credits remaining in seconds<br/>
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Account(
            string? email,
            int? balanceSeconds)
        {
            this.Email = email;
            this.BalanceSeconds = balanceSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        public Account()
        {
        }
    }
}