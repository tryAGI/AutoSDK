//HintName: G.Models.EventSubSubscriptionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The subscription's parameter values. This is a string-encoded JSON object whose contents are determined by the subscription type.
    /// </summary>
    public sealed partial class EventSubSubscriptionCondition
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSubSubscriptionCondition" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EventSubSubscriptionCondition(
 )
        {
        }
    }
}