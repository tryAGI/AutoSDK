//HintName: G.JsonConverters.RealtimeServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RealtimeServerEvent>
    {
        /// <inheritdoc />
        public override global::G.RealtimeServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RealtimeServerEventConversationCreated? conversationCreated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationCreated)}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemCreated? conversationItemCreated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemCreated)}");
                conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemDeleted? conversationItemDeleted = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemDeleted)}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted)}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta)}");
                conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed)}");
                conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemRetrieved)}");
                conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventConversationItemTruncated? conversationItemTruncated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventConversationItemTruncated)}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventError? error = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.InputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventInputAudioBufferCleared)}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventInputAudioBufferCommitted)}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted)}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped)}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.RateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventRateLimitsUpdated)}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseAudioDelta? responseAudioDelta = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseAudioDelta)}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseAudioDone? responseAudioDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseAudioDone)}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseAudioTranscriptDelta? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseAudioTranscriptDelta)}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseAudioTranscriptDone? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseAudioTranscriptDone)}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseContentPartAdded)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseContentPartDone? responseContentPartDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseContentPartDone)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseCreated? responseCreated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseCreated)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseDone? responseDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseDone)}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseOutputItemAdded)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseOutputItemDone)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseTextDelta? responseTextDelta = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseTextDelta)}");
                responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventResponseTextDone? responseTextDone = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.ResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventResponseTextDone)}");
                responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventSessionCreated? sessionCreated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventSessionCreated)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventSessionUpdated? sessionUpdated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventSessionUpdated)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventTranscriptionSessionUpdated? transcriptionSessionUpdated = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.TranscriptionSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventTranscriptionSessionUpdated)}");
                transcriptionSessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventOutputAudioBufferStarted)}");
                outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventOutputAudioBufferStopped)}");
                outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared = default;
            if (discriminator?.Type == global::G.RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RealtimeServerEventOutputAudioBufferCleared)}");
                outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.RealtimeServerEvent(
                discriminator?.Type,
                conversationCreated,

                conversationItemCreated,

                conversationItemDeleted,

                conversationItemInputAudioTranscriptionCompleted,

                conversationItemInputAudioTranscriptionDelta,

                conversationItemInputAudioTranscriptionFailed,

                conversationItemRetrieved,

                conversationItemTruncated,

                error,

                inputAudioBufferCleared,

                inputAudioBufferCommitted,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                rateLimitsUpdated,

                responseAudioDelta,

                responseAudioDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                responseDone,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseTextDelta,

                responseTextDone,

                sessionCreated,

                sessionUpdated,

                transcriptionSessionUpdated,

                outputAudioBufferStarted,

                outputAudioBufferStopped,

                outputAudioBufferCleared
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated!, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated!, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed!, typeInfo);
            }
            else if (value.IsConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved!, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared!, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted!, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted!, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped!, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated!, typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta!, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated!, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta!, typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone!, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsTranscriptionSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSessionUpdated!, typeInfo);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted!, typeInfo);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped!, typeInfo);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared!, typeInfo);
            }
        }
    }
}