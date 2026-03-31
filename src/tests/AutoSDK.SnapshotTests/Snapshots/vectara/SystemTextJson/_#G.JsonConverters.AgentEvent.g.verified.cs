//HintName: G.JsonConverters.AgentEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentEvent>
    {
        /// <inheritdoc />
        public override global::G.AgentEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.InputMessageEvent? inputMessage = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InputMessageEvent)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SkillLoadEvent? skillLoad = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.SkillLoad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkillLoadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkillLoadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SkillLoadEvent)}");
                skillLoad = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ArtifactUploadEvent? artifactUpload = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.ArtifactUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactUploadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactUploadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ArtifactUploadEvent)}");
                artifactUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolInputEvent? toolInput = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.ToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolInputEvent)}");
                toolInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolOutputEvent? toolOutput = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.ToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolOutputEvent)}");
                toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ThinkingEvent? thinking = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ThinkingEvent)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AgentOutputEvent? agentOutput = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.AgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentOutputEvent)}");
                agentOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StructuredOutputEvent? structuredOutput = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.StructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StructuredOutputEvent)}");
                structuredOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContextLimitExceededEvent? contextLimitExceeded = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.ContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContextLimitExceededEvent)}");
                contextLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.StepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StepTransitionLimitExceededEvent)}");
                stepTransitionLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SessionInterruptedEvent? sessionInterrupted = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.SessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SessionInterruptedEvent)}");
                sessionInterrupted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageReadEvent? imageRead = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageReadEvent)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StepTransitionEvent? stepTransition = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.StepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StepTransitionEvent)}");
                stepTransition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CompactionEvent? compaction = default;
            if (discriminator?.Type == global::G.AgentEventDiscriminatorType.Compaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompactionEvent)}");
                compaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentEvent(
                discriminator?.Type,
                inputMessage,

                skillLoad,

                artifactUpload,

                toolInput,

                toolOutput,

                thinking,

                agentOutput,

                structuredOutput,

                contextLimitExceeded,

                stepTransitionLimitExceeded,

                sessionInterrupted,

                imageRead,

                stepTransition,

                compaction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage!.Value, typeInfo);
            }
            else if (value.IsSkillLoad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkillLoadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkillLoadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SkillLoadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkillLoad!.Value, typeInfo);
            }
            else if (value.IsArtifactUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactUploadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactUploadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactUploadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactUpload!.Value, typeInfo);
            }
            else if (value.IsToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolInputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolInput!.Value, typeInfo);
            }
            else if (value.IsToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolOutput!.Value, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThinkingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!.Value, typeInfo);
            }
            else if (value.IsAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentOutput!.Value, typeInfo);
            }
            else if (value.IsStructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StructuredOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredOutput!.Value, typeInfo);
            }
            else if (value.IsContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContextLimitExceededEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextLimitExceeded!.Value, typeInfo);
            }
            else if (value.IsStepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StepTransitionLimitExceededEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransitionLimitExceeded!.Value, typeInfo);
            }
            else if (value.IsSessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SessionInterruptedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInterrupted!.Value, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageReadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead!.Value, typeInfo);
            }
            else if (value.IsStepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StepTransitionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransition!.Value, typeInfo);
            }
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompactionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction!.Value, typeInfo);
            }
        }
    }
}