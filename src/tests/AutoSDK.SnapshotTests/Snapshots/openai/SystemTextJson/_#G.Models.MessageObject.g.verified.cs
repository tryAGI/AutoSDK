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
        /// If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? AssistantId { get; set; }

        /// <summary>
        /// A list of files attached to the message, and the tools they were added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MessageObjectAttachment>? Attachments { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// The content of the message in array of text and/or images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject, global::G.MessageContentRefusalObject>> Content { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was marked as incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? IncompleteAt { get; set; }

        /// <summary>
        /// On an incomplete message, details about why the message is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageObjectIncompleteDetails? IncompleteDetails { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The object type, which is always `thread.message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageObjectObjectJsonConverter))]
        public global::G.MessageObjectObject Object { get; set; }

        /// <summary>
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageObjectRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageObjectRole Role { get; set; }

        /// <summary>
        /// The ID of the [run](/docs/api-reference/runs) associated with the creation of this message. Value is `null` when messages are created manually using the create message or create thread endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RunId { get; set; }

        /// <summary>
        /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageObjectStatus Status { get; set; }

        /// <summary>
        /// The [thread](/docs/api-reference/threads) ID that this message belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObject" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message.
        /// </param>
        /// <param name="attachments">
        /// A list of files attached to the message, and the tools they were added to.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the message was completed.
        /// </param>
        /// <param name="content">
        /// The content of the message in array of text and/or images.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the message was created.
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="incompleteAt">
        /// The Unix timestamp (in seconds) for when the message was marked as incomplete.
        /// </param>
        /// <param name="incompleteDetails">
        /// On an incomplete message, details about why the message is incomplete.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.message`.
        /// </param>
        /// <param name="role">
        /// The entity that produced the message. One of `user` or `assistant`.
        /// </param>
        /// <param name="runId">
        /// The ID of the [run](/docs/api-reference/runs) associated with the creation of this message. Value is `null` when messages are created manually using the create message or create thread endpoints.
        /// </param>
        /// <param name="status">
        /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
        /// </param>
        /// <param name="threadId">
        /// The [thread](/docs/api-reference/threads) ID that this message belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageObject(
            string? assistantId,
            global::System.Collections.Generic.IList<global::G.MessageObjectAttachment>? attachments,
            global::System.DateTimeOffset? completedAt,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject, global::G.MessageContentRefusalObject>> content,
            global::System.DateTimeOffset createdAt,
            string id,
            global::System.DateTimeOffset? incompleteAt,
            global::G.MessageObjectIncompleteDetails? incompleteDetails,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.MessageObjectRole role,
            string? runId,
            global::G.MessageObjectStatus status,
            string threadId,
            global::G.MessageObjectObject @object)
        {
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
            this.CompletedAt = completedAt;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IncompleteAt = incompleteAt;
            this.IncompleteDetails = incompleteDetails ?? throw new global::System.ArgumentNullException(nameof(incompleteDetails));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Role = role;
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.Status = status;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
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