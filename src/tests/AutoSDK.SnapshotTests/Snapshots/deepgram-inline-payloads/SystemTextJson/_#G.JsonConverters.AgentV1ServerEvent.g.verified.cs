//HintName: G.JsonConverters.AgentV1ServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::G.AgentV1ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentV1ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentV1ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentV1ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AgentStarted? agentStarted = default;
            if (discriminator?.Type == global::G.AgentV1ServerEventDiscriminatorType.AgentStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentStarted)}");
                agentStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AgentThinking? agentThinking = default;
            if (discriminator?.Type == global::G.AgentV1ServerEventDiscriminatorType.AgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentThinking> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentThinking)}");
                agentThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentV1ServerEvent(
                discriminator?.Type,
                agentStarted,

                agentThinking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgentStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentStarted, typeInfo);
            }
            else if (value.IsAgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentThinking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentThinking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinking, typeInfo);
            }
        }
    }
}