//HintName: G.JsonConverters.AgentStreamedResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentStreamedResponse>
    {
        /// <inheritdoc />
        public override global::G.AgentStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.InputMessageEvent? inputMessage = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputMessageEvent)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamingAgentOutput? streamingAgentOutput = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StreamingAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingAgentOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingAgentOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamingAgentOutput)}");
                streamingAgentOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamingAgentOutputEnd? streamingAgentOutputEnd = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingAgentOutputEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingAgentOutputEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamingAgentOutputEnd)}");
                streamingAgentOutputEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamingThinking? streamingThinking = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StreamingThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingThinking> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamingThinking)}");
                streamingThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamingThinkingEnd? streamingThinkingEnd = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StreamingThinkingEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingThinkingEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingThinkingEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamingThinkingEnd)}");
                streamingThinkingEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolInputEvent? toolInput = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.ToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolInputEvent)}");
                toolInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolOutputEvent? toolOutput = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.ToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolOutputEvent)}");
                toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StructuredOutputEvent? structuredOutput = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StructuredOutputEvent)}");
                structuredOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContextLimitExceededEvent? contextLimitExceeded = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.ContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContextLimitExceededEvent)}");
                contextLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StepTransitionLimitExceededEvent)}");
                stepTransitionLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SessionInterruptedEvent? sessionInterrupted = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.SessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SessionInterruptedEvent)}");
                sessionInterrupted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageReadEvent? imageRead = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageReadEvent)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StepTransitionEvent? stepTransition = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.StepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StepTransitionEvent)}");
                stepTransition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContextConsumedEvent? contextConsumed = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.ContextConsumed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextConsumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextConsumedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContextConsumedEvent)}");
                contextConsumed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CompactionStartedEvent? compactionStarted = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.CompactionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompactionStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompactionStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompactionStartedEvent)}");
                compactionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CompactionEvent? compaction = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.Compaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompactionEvent)}");
                compaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamError? error = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StreamResponseEnd? end = default;
            if (discriminator?.Type == global::G.AgentStreamedResponseDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StreamResponseEnd)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentStreamedResponse(
                discriminator?.Type,
                inputMessage,

                streamingAgentOutput,

                streamingAgentOutputEnd,

                streamingThinking,

                streamingThinkingEnd,

                toolInput,

                toolOutput,

                structuredOutput,

                contextLimitExceeded,

                stepTransitionLimitExceeded,

                sessionInterrupted,

                imageRead,

                stepTransition,

                contextConsumed,

                compactionStarted,

                compaction,

                error,

                end
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage, typeInfo);
            }
            else if (value.IsStreamingAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingAgentOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingAgentOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamingAgentOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingAgentOutput, typeInfo);
            }
            else if (value.IsStreamingAgentOutputEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingAgentOutputEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingAgentOutputEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamingAgentOutputEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingAgentOutputEnd, typeInfo);
            }
            else if (value.IsStreamingThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingThinking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamingThinking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingThinking, typeInfo);
            }
            else if (value.IsStreamingThinkingEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamingThinkingEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamingThinkingEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamingThinkingEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingThinkingEnd, typeInfo);
            }
            else if (value.IsToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolInputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolInput, typeInfo);
            }
            else if (value.IsToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolOutput, typeInfo);
            }
            else if (value.IsStructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StructuredOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredOutput, typeInfo);
            }
            else if (value.IsContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContextLimitExceededEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextLimitExceeded, typeInfo);
            }
            else if (value.IsStepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StepTransitionLimitExceededEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransitionLimitExceeded, typeInfo);
            }
            else if (value.IsSessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SessionInterruptedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInterrupted, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageReadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead, typeInfo);
            }
            else if (value.IsStepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StepTransitionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransition, typeInfo);
            }
            else if (value.IsContextConsumed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextConsumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextConsumedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContextConsumedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextConsumed, typeInfo);
            }
            else if (value.IsCompactionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompactionStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompactionStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompactionStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompactionStarted, typeInfo);
            }
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompactionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamResponseEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamResponseEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
        }
    }
}