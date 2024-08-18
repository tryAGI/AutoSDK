//HintName: G.Models.MessageObject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a message within a [thread](/docs/api-reference/threads).
    /// </summary>
    public sealed partial class MessageObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.message`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.MessageObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// The [thread](/docs/api-reference/threads) ID that this message belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// On an incomplete message, details about why the message is incomplete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObjectIncompleteDetails? IncompleteDetails { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? CompletedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was marked as incomplete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? IncompleteAt { get; set; } = default!;

        /// <summary>
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObjectRole Role { get; set; } = default!;

        /// <summary>
        /// The content of the message in array of text and/or images.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject, global::G.MessageContentRefusalObject>> Content { get; set; } = default!;

        /// <summary>
        /// If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? AssistantId { get; set; } = default!;

        /// <summary>
        /// The ID of the [run](/docs/api-reference/runs) associated with the creation of this message. Value is `null` when messages are created manually using the create message or create thread endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RunId { get; set; } = default!;

        /// <summary>
        /// A list of files attached to the message, and the tools they were added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attachments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MessageObjectAttachment>? Attachments { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObjectMetadata? Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}