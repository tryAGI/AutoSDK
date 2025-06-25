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

            var
            readerCopy = reader;
            global::G.RealtimeServerEventConversationCreated? conversationCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationCreated).Name}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemCreated? conversationItemCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemDeleted? conversationItemDeleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventConversationItemTruncated? conversationItemTruncated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventError? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseAudioDelta? responseAudioDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseAudioDone? responseAudioDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseAudioTranscriptDelta? responseAudioTranscriptDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseAudioTranscriptDone? responseAudioTranscriptDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseContentPartDone? responseContentPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseCreated? responseCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseDone? responseDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseTextDelta? responseTextDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventResponseTextDone? responseTextDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventSessionCreated? sessionCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventSessionUpdated? sessionUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventTranscriptionSessionUpdated? transcriptionSessionUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                transcriptionSessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RealtimeServerEvent(
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

            if (conversationCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemDeleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionFailed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemRetrieved != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemTruncated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCleared != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCommitted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferSpeechStarted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferSpeechStopped != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (rateLimitsUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioTranscriptDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioTranscriptDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseContentPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseContentPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseFunctionCallArgumentsDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseFunctionCallArgumentsDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputItemAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputItemDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseTextDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseTextDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (transcriptionSessionUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferStarted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferStopped != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferCleared != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeInfo);
            }
            else if (value.IsConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta, typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeInfo);
            }
            else if (value.IsTranscriptionSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSessionUpdated, typeInfo);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted, typeInfo);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped, typeInfo);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared, typeInfo);
            }
        }
    }
}