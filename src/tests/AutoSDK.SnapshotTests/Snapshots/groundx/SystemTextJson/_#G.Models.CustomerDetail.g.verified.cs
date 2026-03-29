//HintName: G.Models.CustomerDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Account information for the user
    /// </summary>
    public sealed partial class CustomerDetail
    {
        /// <summary>
        /// Email associated with the account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Given name associated with the account, if known
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        public string? First { get; set; }

        /// <summary>
        /// Family name associated with the account, if known
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last")]
        public string? Last { get; set; }

        /// <summary>
        /// Subscription information for the user, including current usage and limits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::G.SubscriptionDetail? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetail" /> class.
        /// </summary>
        /// <param name="email">
        /// Email associated with the account
        /// </param>
        /// <param name="first">
        /// Given name associated with the account, if known
        /// </param>
        /// <param name="last">
        /// Family name associated with the account, if known
        /// </param>
        /// <param name="subscription">
        /// Subscription information for the user, including current usage and limits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerDetail(
            string? email,
            string? first,
            string? last,
            global::G.SubscriptionDetail? subscription)
        {
            this.Email = email;
            this.First = first;
            this.Last = last;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetail" /> class.
        /// </summary>
        public CustomerDetail()
        {
        }
    }
}