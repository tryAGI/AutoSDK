//HintName: G.Models.PostApiSubscriptionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an error when attempting to update the API subscription.<br/>
    /// Example: {"messages":["messages","messages"]}
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiSubscriptionError" /> class.
        /// </summary>
        /// <param name="messages">
        /// Error messages about what the error could be.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostApiSubscriptionError(
            global::System.Collections.Generic.IList<string>? messages)
        {
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiSubscriptionError" /> class.
        /// </summary>
        public PostApiSubscriptionError()
        {
        }
    }
}