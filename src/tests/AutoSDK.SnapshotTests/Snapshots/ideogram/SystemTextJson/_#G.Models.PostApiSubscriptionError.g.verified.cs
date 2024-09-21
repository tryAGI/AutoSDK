//HintName: G.Models.PostApiSubscriptionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an error when attempting to update the API subscription.
    /// </summary>
    public sealed partial class PostApiSubscriptionError
    {
        /// <summary>
        /// Error messages about what the error could be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}