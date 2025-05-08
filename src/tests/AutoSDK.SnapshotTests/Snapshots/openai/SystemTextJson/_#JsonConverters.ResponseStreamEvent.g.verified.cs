//HintName: JsonConverters.ResponseStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.ResponseStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ResponseAudioDeltaEvent? audioDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
                audioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseAudioDoneEvent? audioDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
                audioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseAudioTranscriptDeltaEvent? audioTranscriptDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
                audioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseAudioTranscriptDoneEvent? audioTranscriptDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
                audioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCodeInterpreterCallCodeDeltaEvent? codeInterpreterCallDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                codeInterpreterCallDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCodeInterpreterCallCodeDoneEvent? codeInterpreterCallDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                codeInterpreterCallDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCodeInterpreterCallCompletedEvent? codeInterpreterCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                codeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCodeInterpreterCallInProgressEvent? codeInterpreterCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                codeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCodeInterpreterCallInterpretingEvent? codeInterpreterCallInterpreting = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                codeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCompletedEvent? completed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseContentPartAddedEvent? contentPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
                contentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseContentPartDoneEvent? contentPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
                contentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseCreatedEvent? created = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
                created = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseErrorEvent? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFileSearchCallCompletedEvent? fileSearchCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                fileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFileSearchCallInProgressEvent? fileSearchCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                fileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFileSearchCallSearchingEvent? fileSearchCallSearching = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                fileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFunctionCallArgumentsDeltaEvent? functionCallArgumentsDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                functionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFunctionCallArgumentsDoneEvent? functionCallArgumentsDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
                functionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseInProgressEvent? inProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                inProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFailedEvent? failed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseIncompleteEvent? incomplete = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                incomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseOutputItemAddedEvent? outputItemAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
                outputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseOutputItemDoneEvent? outputItemDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
                outputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseReasoningSummaryPartAddedEvent? reasoningSummaryPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                reasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseReasoningSummaryPartDoneEvent? reasoningSummaryPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                reasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseReasoningSummaryTextDeltaEvent? reasoningSummaryTextDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                reasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseReasoningSummaryTextDoneEvent? reasoningSummaryTextDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                reasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseRefusalDeltaEvent? refusalDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                refusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseRefusalDoneEvent? refusalDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                refusalDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseTextAnnotationDeltaEvent? textAnnotationDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextAnnotationDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextAnnotationDeltaEvent).Name}");
                textAnnotationDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseTextDeltaEvent? textDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseTextDoneEvent? textDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                textDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseWebSearchCallCompletedEvent? webSearchCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                webSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseWebSearchCallInProgressEvent? webSearchCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                webSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseWebSearchCallSearchingEvent? webSearchCallSearching = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                webSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ResponseStreamEvent(
                audioDelta,
                audioDone,
                audioTranscriptDelta,
                audioTranscriptDone,
                codeInterpreterCallDelta,
                codeInterpreterCallDone,
                codeInterpreterCallCompleted,
                codeInterpreterCallInProgress,
                codeInterpreterCallInterpreting,
                completed,
                contentPartAdded,
                contentPartDone,
                created,
                error,
                fileSearchCallCompleted,
                fileSearchCallInProgress,
                fileSearchCallSearching,
                functionCallArgumentsDelta,
                functionCallArgumentsDone,
                inProgress,
                failed,
                incomplete,
                outputItemAdded,
                outputItemDone,
                reasoningSummaryPartAdded,
                reasoningSummaryPartDone,
                reasoningSummaryTextDelta,
                reasoningSummaryTextDone,
                refusalDelta,
                refusalDone,
                textAnnotationDelta,
                textDelta,
                textDone,
                webSearchCallCompleted,
                webSearchCallInProgress,
                webSearchCallSearching
                );

            if (audioDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioTranscriptDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioTranscriptDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallInterpreting != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (completed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (created != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchCallSearching != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionCallArgumentsDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionCallArgumentsDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (failed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (incomplete != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputItemAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputItemDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryTextDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryTextDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (refusalDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (refusalDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textAnnotationDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextAnnotationDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextAnnotationDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchCallSearching != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioDelta, typeInfo);
            }
            else if (value.IsAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioDone, typeInfo);
            }
            else if (value.IsAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioTranscriptDelta, typeInfo);
            }
            else if (value.IsAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioTranscriptDone, typeInfo);
            }
            else if (value.IsCodeInterpreterCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallDelta, typeInfo);
            }
            else if (value.IsCodeInterpreterCallDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallDone, typeInfo);
            }
            else if (value.IsCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallCompleted, typeInfo);
            }
            else if (value.IsCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallInProgress, typeInfo);
            }
            else if (value.IsCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallInterpreting, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed, typeInfo);
            }
            else if (value.IsContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartAdded, typeInfo);
            }
            else if (value.IsContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartDone, typeInfo);
            }
            else if (value.IsCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Created, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCallCompleted, typeInfo);
            }
            else if (value.IsFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCallInProgress, typeInfo);
            }
            else if (value.IsFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCallSearching, typeInfo);
            }
            else if (value.IsFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InProgress, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
            else if (value.IsIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Incomplete, typeInfo);
            }
            else if (value.IsOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemAdded, typeInfo);
            }
            else if (value.IsOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemDone, typeInfo);
            }
            else if (value.IsReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryPartAdded, typeInfo);
            }
            else if (value.IsReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryPartDone, typeInfo);
            }
            else if (value.IsReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryTextDelta, typeInfo);
            }
            else if (value.IsReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryTextDone, typeInfo);
            }
            else if (value.IsRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefusalDelta, typeInfo);
            }
            else if (value.IsRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefusalDone, typeInfo);
            }
            else if (value.IsTextAnnotationDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextAnnotationDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextAnnotationDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextAnnotationDelta, typeInfo);
            }
            else if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeInfo);
            }
            else if (value.IsTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDone, typeInfo);
            }
            else if (value.IsWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCallCompleted, typeInfo);
            }
            else if (value.IsWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCallInProgress, typeInfo);
            }
            else if (value.IsWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCallSearching, typeInfo);
            }
        }
    }
}