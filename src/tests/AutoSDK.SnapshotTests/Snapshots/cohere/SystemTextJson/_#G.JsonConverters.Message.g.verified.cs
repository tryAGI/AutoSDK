//HintName: G.JsonConverters.Message.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Message>
    {
        /// <inheritdoc />
        public override global::G.Message Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ChatMessage? cHATBOT = default;
            if (discriminator?.Role == global::G.MessageDiscriminatorRole.CHATBOT)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatMessage)}");
                cHATBOT = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolMessage? tOOL = default;
            if (discriminator?.Role == global::G.MessageDiscriminatorRole.TOOL)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolMessage)}");
                tOOL = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Message(
                discriminator?.Role,
                cHATBOT,
                tOOL
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Message value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCHATBOT)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CHATBOT, typeInfo);
            }
            else if (value.IsTOOL)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TOOL, typeInfo);
            }
        }
    }
}