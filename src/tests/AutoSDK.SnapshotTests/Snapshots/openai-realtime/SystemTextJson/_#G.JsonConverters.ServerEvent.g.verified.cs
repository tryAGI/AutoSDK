//HintName: G.JsonConverters.ServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ServerEvent>
    {
        /// <inheritdoc />
        public override global::G.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ErrorPayload? error = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ErrorPayload)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SessionCreatedPayload? sessionCreated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SessionCreatedPayload)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SessionUpdatedPayload? sessionUpdated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionUpdatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SessionUpdatedPayload)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationCreatedPayload? conversationCreated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationCreatedPayload)}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationItemCreatedPayload? conversationItemCreated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationItemCreatedPayload)}");
                conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationItemInputAudioTranscriptionCompletedPayload? conversationItemInputAudioTranscriptionCompleted = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemInputAudioTranscriptionCompletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemInputAudioTranscriptionCompletedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationItemInputAudioTranscriptionCompletedPayload)}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationItemInputAudioTranscriptionFailedPayload? conversationItemInputAudioTranscriptionFailed = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemInputAudioTranscriptionFailedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemInputAudioTranscriptionFailedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationItemInputAudioTranscriptionFailedPayload)}");
                conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationItemTruncatedPayload? conversationItemTruncated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemTruncatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemTruncatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationItemTruncatedPayload)}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationItemDeletedPayload? conversationItemDeleted = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemDeletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemDeletedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationItemDeletedPayload)}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InputAudioBufferCommittedPayload? inputAudioBufferCommitted = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.InputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferCommittedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferCommittedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputAudioBufferCommittedPayload)}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InputAudioBufferClearedPayload? inputAudioBufferCleared = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.InputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferClearedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferClearedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputAudioBufferClearedPayload)}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InputAudioBufferSpeechStartedPayload? inputAudioBufferSpeechStarted = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.InputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferSpeechStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferSpeechStartedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputAudioBufferSpeechStartedPayload)}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InputAudioBufferSpeechStoppedPayload? inputAudioBufferSpeechStopped = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.InputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferSpeechStoppedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferSpeechStoppedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputAudioBufferSpeechStoppedPayload)}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCreatedPayload? responseCreated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCreatedPayload)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseDonePayload? responseDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseDonePayload)}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseOutputItemAddedPayload? responseOutputItemAdded = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseOutputItemAddedPayload)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseOutputItemDonePayload? responseOutputItemDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseOutputItemDonePayload)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseContentPartAddedPayload? responseContentPartAdded = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseContentPartAddedPayload)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseContentPartDonePayload? responseContentPartDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseContentPartDonePayload)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseTextDeltaPayload? responseTextDelta = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseTextDeltaPayload)}");
                responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseTextDonePayload? responseTextDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseTextDonePayload)}");
                responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioTranscriptDeltaPayload? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioTranscriptDeltaPayload)}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioTranscriptDonePayload? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioTranscriptDonePayload)}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioDeltaPayload? responseAudioDelta = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioDeltaPayload)}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioDonePayload? responseAudioDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioDonePayload)}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFunctionCallArgumentsDeltaPayload? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFunctionCallArgumentsDeltaPayload)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFunctionCallArgumentsDonePayload? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFunctionCallArgumentsDonePayload)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RateLimitsUpdatedPayload? rateLimitsUpdated = default;
            if (discriminator?.Type == global::G.ServerEventDiscriminatorType.RateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsUpdatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RateLimitsUpdatedPayload)}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ServerEvent(
                discriminator?.Type,
                error,

                sessionCreated,

                sessionUpdated,

                conversationCreated,

                conversationItemCreated,

                conversationItemInputAudioTranscriptionCompleted,

                conversationItemInputAudioTranscriptionFailed,

                conversationItemTruncated,

                conversationItemDeleted,

                inputAudioBufferCommitted,

                inputAudioBufferCleared,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                responseCreated,

                responseDone,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseTextDelta,

                responseTextDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseAudioDelta,

                responseAudioDone,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                rateLimitsUpdated
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErrorPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SessionCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionUpdatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SessionUpdatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeInfo);
            }
            else if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationItemCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemInputAudioTranscriptionCompletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemInputAudioTranscriptionCompletedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationItemInputAudioTranscriptionCompletedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemInputAudioTranscriptionFailedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemInputAudioTranscriptionFailedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationItemInputAudioTranscriptionFailedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemTruncatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemTruncatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationItemTruncatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationItemDeletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationItemDeletedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationItemDeletedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferCommittedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferCommittedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputAudioBufferCommittedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferClearedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferClearedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputAudioBufferClearedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferSpeechStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferSpeechStartedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputAudioBufferSpeechStartedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputAudioBufferSpeechStoppedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputAudioBufferSpeechStoppedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputAudioBufferSpeechStoppedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta, typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsUpdatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsUpdatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeInfo);
            }
        }
    }
}