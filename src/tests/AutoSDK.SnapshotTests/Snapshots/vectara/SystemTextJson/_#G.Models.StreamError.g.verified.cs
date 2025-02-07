//HintName: G.Models.StreamError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event signaling there was an error with the request.
    /// </summary>
    public sealed partial class StreamError
    {
        /// <summary>
        /// If the stream errors, an event with type `error` will<br/>
        /// be sent.<br/>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The error messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamError" /> class.
        /// </summary>
        /// <param name="type">
        /// If the stream errors, an event with type `error` will<br/>
        /// be sent.<br/>
        /// Default Value: error
        /// </param>
        /// <param name="messages">
        /// The error messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamError(
            string? type,
            global::System.Collections.Generic.IList<string>? messages)
        {
            this.Type = type;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamError" /> class.
        /// </summary>
        public StreamError()
        {
        }
    }
}