//HintName: G.JsonConverters.InputItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputItem>
    {
        /// <inheritdoc />
        public override global::G.InputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.EasyInputMessage? message = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessage).Name}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Item? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Item), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Item> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Item).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ItemReferenceParam? itemReference = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ItemReferenceParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ItemReferenceParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ItemReferenceParam).Name}");
                itemReference = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.InputItem(
                message,
                value2,
                itemReference
                );

            if (message != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Item), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Item> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Item).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (itemReference != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ItemReferenceParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ItemReferenceParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ItemReferenceParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Item), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Item> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Item).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsItemReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ItemReferenceParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ItemReferenceParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ItemReferenceParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ItemReference, typeInfo);
            }
        }
    }
}