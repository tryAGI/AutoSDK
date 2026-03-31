//HintName: G.JsonConverters.CreateInputRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateInputRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateInputRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateInputRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInputRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInputRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInputRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateInputMessageRequest? inputMessage = default;
            if (discriminator?.Type == global::G.CreateInputRequestDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInputMessageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInputMessageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInputMessageRequest)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateInterruptRequest? interrupt = default;
            if (discriminator?.Type == global::G.CreateInputRequestDiscriminatorType.Interrupt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInterruptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInterruptRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInterruptRequest)}");
                interrupt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCompactRequest? compact = default;
            if (discriminator?.Type == global::G.CreateInputRequestDiscriminatorType.Compact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCompactRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCompactRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCompactRequest)}");
                compact = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateInputRequest(
                discriminator?.Type,
                inputMessage,

                interrupt,

                compact
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateInputRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInputMessageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInputMessageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateInputMessageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage!.Value, typeInfo);
            }
            else if (value.IsInterrupt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInterruptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInterruptRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateInterruptRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Interrupt!.Value, typeInfo);
            }
            else if (value.IsCompact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCompactRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCompactRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCompactRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compact!.Value, typeInfo);
            }
        }
    }
}