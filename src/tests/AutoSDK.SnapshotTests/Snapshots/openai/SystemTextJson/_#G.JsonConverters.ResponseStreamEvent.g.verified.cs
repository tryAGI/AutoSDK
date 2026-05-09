//HintName: G.JsonConverters.ResponseStreamEvent.g.cs
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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResponseAudioDeltaEvent? responseAudioDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioDeltaEvent)}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioDoneEvent? responseAudioDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioDoneEvent)}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioTranscriptDeltaEvent)}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseAudioTranscriptDoneEvent)}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent)}");
                responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCodeInterpreterCallCodeDoneEvent)}");
                responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCodeInterpreterCallCompletedEvent)}");
                responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCodeInterpreterCallInProgressEvent)}");
                responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCodeInterpreterCallInterpretingEvent)}");
                responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCompletedEvent? responseCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCompletedEvent)}");
                responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseContentPartAddedEvent? responseContentPartAdded = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseContentPartAddedEvent)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseContentPartDoneEvent? responseContentPartDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseContentPartDoneEvent)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseCreatedEvent? responseCreated = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseCreatedEvent)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseErrorEvent? error = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFileSearchCallCompletedEvent)}");
                responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFileSearchCallInProgressEvent)}");
                responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFileSearchCallSearchingEvent)}");
                responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFunctionCallArgumentsDeltaEvent)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFunctionCallArgumentsDoneEvent)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseInProgressEvent? responseInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseInProgressEvent)}");
                responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseFailedEvent? responseFailed = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseFailedEvent)}");
                responseFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseIncompleteEvent? responseIncomplete = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseIncompleteEvent)}");
                responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseOutputItemAddedEvent? responseOutputItemAdded = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseOutputItemAddedEvent)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseOutputItemDoneEvent? responseOutputItemDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseOutputItemDoneEvent)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningSummaryPartAddedEvent)}");
                responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningSummaryPartDoneEvent)}");
                responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningSummaryTextDeltaEvent)}");
                responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningSummaryTextDoneEvent)}");
                responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseRefusalDeltaEvent? responseRefusalDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseRefusalDeltaEvent)}");
                responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseRefusalDoneEvent? responseRefusalDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseRefusalDoneEvent)}");
                responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseTextDeltaEvent? responseOutputTextDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseTextDeltaEvent)}");
                responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseTextDoneEvent? responseOutputTextDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseTextDoneEvent)}");
                responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseWebSearchCallCompletedEvent)}");
                responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseWebSearchCallInProgressEvent)}");
                responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseWebSearchCallSearchingEvent)}");
                responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseImageGenCallCompletedEvent? responseImageGenerationCallCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseImageGenCallCompletedEvent)}");
                responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseImageGenCallGeneratingEvent? responseImageGenerationCallGenerating = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallGeneratingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseImageGenCallGeneratingEvent)}");
                responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseImageGenCallInProgressEvent? responseImageGenerationCallInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseImageGenCallInProgressEvent)}");
                responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallPartialImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallPartialImageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseImageGenCallPartialImageEvent)}");
                responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPCallArgumentsDeltaEvent? responseMcpCallArgumentsDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPCallArgumentsDeltaEvent)}");
                responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPCallArgumentsDoneEvent? responseMcpCallArgumentsDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPCallArgumentsDoneEvent)}");
                responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPCallCompletedEvent? responseMcpCallCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPCallCompletedEvent)}");
                responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPCallFailedEvent? responseMcpCallFailed = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPCallFailedEvent)}");
                responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPCallInProgressEvent? responseMcpCallInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPCallInProgressEvent)}");
                responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPListToolsCompletedEvent? responseMcpListToolsCompleted = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPListToolsCompletedEvent)}");
                responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPListToolsFailedEvent? responseMcpListToolsFailed = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpListToolsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPListToolsFailedEvent)}");
                responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseMCPListToolsInProgressEvent? responseMcpListToolsInProgress = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseMcpListToolsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseMCPListToolsInProgressEvent)}");
                responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseOutputTextAnnotationAddedEvent? responseOutputTextAnnotationAdded = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputTextAnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputTextAnnotationAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseOutputTextAnnotationAddedEvent)}");
                responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseQueuedEvent? responseQueued = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseQueuedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseQueuedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseQueuedEvent)}");
                responseQueued = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningDeltaEvent? responseReasoningDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningDeltaEvent)}");
                responseReasoningDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningDoneEvent? responseReasoningDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningDoneEvent)}");
                responseReasoningDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningSummaryDeltaEvent? responseReasoningSummaryDelta = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningSummaryDeltaEvent)}");
                responseReasoningSummaryDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResponseReasoningSummaryDoneEvent? responseReasoningSummaryDone = default;
            if (discriminator?.Type == global::G.ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseReasoningSummaryDoneEvent)}");
                responseReasoningSummaryDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResponseStreamEvent(
                discriminator?.Type,
                responseAudioDelta,

                responseAudioDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseCodeInterpreterCallCodeDelta,

                responseCodeInterpreterCallCodeDone,

                responseCodeInterpreterCallCompleted,

                responseCodeInterpreterCallInProgress,

                responseCodeInterpreterCallInterpreting,

                responseCompleted,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                error,

                responseFileSearchCallCompleted,

                responseFileSearchCallInProgress,

                responseFileSearchCallSearching,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseInProgress,

                responseFailed,

                responseIncomplete,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseReasoningSummaryPartAdded,

                responseReasoningSummaryPartDone,

                responseReasoningSummaryTextDelta,

                responseReasoningSummaryTextDone,

                responseRefusalDelta,

                responseRefusalDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseWebSearchCallCompleted,

                responseWebSearchCallInProgress,

                responseWebSearchCallSearching,

                responseImageGenerationCallCompleted,

                responseImageGenerationCallGenerating,

                responseImageGenerationCallInProgress,

                responseImageGenerationCallPartialImage,

                responseMcpCallArgumentsDelta,

                responseMcpCallArgumentsDone,

                responseMcpCallCompleted,

                responseMcpCallFailed,

                responseMcpCallInProgress,

                responseMcpListToolsCompleted,

                responseMcpListToolsFailed,

                responseMcpListToolsInProgress,

                responseOutputTextAnnotationAdded,

                responseQueued,

                responseReasoningDelta,

                responseReasoningDone,

                responseReasoningSummaryDelta,

                responseReasoningSummaryDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta!, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDelta!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDone!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCompleted!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInProgress!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInterpreting!, typeInfo);
            }
            else if (value.IsResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompleted!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallCompleted!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInProgress!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallSearching!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInProgress!, typeInfo);
            }
            else if (value.IsResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFailed!, typeInfo);
            }
            else if (value.IsResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseIncomplete!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartAdded!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartDone!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDelta!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDone!, typeInfo);
            }
            else if (value.IsResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta!, typeInfo);
            }
            else if (value.IsResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone!, typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta!, typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallCompleted!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInProgress!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallSearching!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallCompleted!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallGeneratingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallGeneratingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallGenerating!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallInProgress!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallPartialImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallPartialImageEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallPartialImageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallPartialImage!, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted!, typeInfo);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed!, typeInfo);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress!, typeInfo);
            }
            else if (value.IsResponseMcpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsCompleted!, typeInfo);
            }
            else if (value.IsResponseMcpListToolsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsFailed!, typeInfo);
            }
            else if (value.IsResponseMcpListToolsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsInProgress!, typeInfo);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputTextAnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputTextAnnotationAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputTextAnnotationAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded!, typeInfo);
            }
            else if (value.IsResponseQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseQueuedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseQueuedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseQueuedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseQueued!, typeInfo);
            }
            else if (value.IsResponseReasoningDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningDelta!, typeInfo);
            }
            else if (value.IsResponseReasoningDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningDone!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryDelta!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryDone!, typeInfo);
            }
        }
    }
}