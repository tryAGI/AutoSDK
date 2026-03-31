//HintName: G.Models.TelephonyParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The telephony parameters associated with the call when the call is made via a phone. More details can also be returned depending on the provider.
    /// </summary>
    public sealed partial class TelephonyParams
    {
        /// <summary>
        /// The phone number of the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// The phone number of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyParams" /> class.
        /// </summary>
        /// <param name="to">
        /// The phone number of the caller.
        /// </param>
        /// <param name="from">
        /// The phone number of the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelephonyParams(
            string to,
            string from)
        {
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyParams" /> class.
        /// </summary>
        public TelephonyParams()
        {
        }
    }
}