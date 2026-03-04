//HintName: G.JsonConverters.CreateEvalItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateEvalItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateEvalItem>
    {
        /// <inheritdoc />
        public override global::G.CreateEvalItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.CreateEvalItemSimpleInputMessage? simpleInputMessage = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEvalItemSimpleInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEvalItemSimpleInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateEvalItemSimpleInputMessage).Name}");
                simpleInputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.EvalItem? evalMessageObject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalItem).Name}");
                evalMessageObject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.CreateEvalItem(
                simpleInputMessage,
                evalMessageObject
                );

            if (simpleInputMessage != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEvalItemSimpleInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEvalItemSimpleInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateEvalItemSimpleInputMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (evalMessageObject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalItem).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateEvalItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSimpleInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEvalItemSimpleInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEvalItemSimpleInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateEvalItemSimpleInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SimpleInputMessage, typeInfo);
            }
            else if (value.IsEvalMessageObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EvalMessageObject, typeInfo);
            }
        }
    }
}