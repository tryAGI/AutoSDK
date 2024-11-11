//HintName: G.Models.ErrorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An error event in a streaming conversation.
    /// </summary>
    public sealed partial class ErrorEvent
    {
        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventType Type { get; set; } = default!;

        /// <summary>
        /// An error object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Error Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        /// <param name="error">
        /// An error object.
        /// </param>
        public ErrorEvent(
            global::G.MessageStreamEventType type,
            global::G.Error error)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        public ErrorEvent()
        {
        }
    }
}