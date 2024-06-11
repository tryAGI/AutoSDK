//HintName: G.Models.MessageDeltaObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a message delta i.e. any changed fields on a message during streaming.
    /// </summary>
    public sealed partial class MessageDeltaObject
    {
        /// <summary>
        /// The identifier of the message, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.message.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDeltaObjectObject Object { get; set; } = default!;

        /// <summary>
        /// The delta containing the fields that have changed on the Message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDeltaObjectDelta Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}