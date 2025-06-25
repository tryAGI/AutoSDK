//HintName: G.Models.ReferrerTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Referrer Traffic
    /// </summary>
    public sealed partial class ReferrerTraffic
    {
        /// <summary>
        /// Example: Google
        /// </summary>
        /// <example>Google</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referrer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Referrer { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniques")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uniques { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferrerTraffic" /> class.
        /// </summary>
        /// <param name="referrer">
        /// Example: Google
        /// </param>
        /// <param name="count">
        /// Example: 4
        /// </param>
        /// <param name="uniques">
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferrerTraffic(
            string referrer,
            int count,
            int uniques)
        {
            this.Referrer = referrer ?? throw new global::System.ArgumentNullException(nameof(referrer));
            this.Count = count;
            this.Uniques = uniques;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferrerTraffic" /> class.
        /// </summary>
        public ReferrerTraffic()
        {
        }
    }
}