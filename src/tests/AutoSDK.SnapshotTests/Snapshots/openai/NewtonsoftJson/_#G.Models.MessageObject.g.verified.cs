﻿//HintName: G.Models.MessageObject.g.cs

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
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

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
        public global::System.DateTimeOffset? CompletedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was marked as incomplete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? IncompleteAt { get; set; } = default!;

        /// <summary>
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageObjectRole Role { get; set; } = default!;

        /// <summary>
        /// The content of the message in array of text and/or images.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject, global::G.MessageContentRefusalObject>> Content { get; set; } = default!;

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
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.message`.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the message was created.
        /// </param>
        /// <param name="threadId">
        /// The [thread](/docs/api-reference/threads) ID that this message belongs to.
        /// </param>
        /// <param name="status">
        /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
        /// </param>
        /// <param name="incompleteDetails">
        /// On an incomplete message, details about why the message is incomplete.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the message was completed.
        /// </param>
        /// <param name="incompleteAt">
        /// The Unix timestamp (in seconds) for when the message was marked as incomplete.
        /// </param>
        /// <param name="role">
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </param>
        /// <param name="content">
        /// The content of the message in array of text and/or images.
        /// </param>
        /// <param name="assistantId">
        /// If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message.
        /// </param>
        /// <param name="runId">
        /// The ID of the [run](/docs/api-reference/runs) associated with the creation of this message. Value is `null` when messages are created manually using the create message or create thread endpoints.
        /// </param>
        /// <param name="attachments">
        /// A list of files attached to the message, and the tools they were added to.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public MessageObject(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            global::G.MessageObjectStatus status,
            global::G.MessageObjectIncompleteDetails? incompleteDetails,
            global::System.DateTimeOffset? completedAt,
            global::System.DateTimeOffset? incompleteAt,
            global::G.MessageObjectRole role,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject, global::G.MessageContentRefusalObject>> content,
            string? assistantId,
            string? runId,
            global::System.Collections.Generic.IList<global::G.MessageObjectAttachment>? attachments,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.MessageObjectObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Status = status;
            this.IncompleteDetails = incompleteDetails ?? throw new global::System.ArgumentNullException(nameof(incompleteDetails));
            this.CompletedAt = completedAt;
            this.IncompleteAt = incompleteAt;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObject" /> class.
        /// </summary>
        public MessageObject()
        {
        }
    }
}