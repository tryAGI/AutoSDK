//HintName: G.JsonConverters.Content6.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Content6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Content6>
    {
        /// <inheritdoc />
        public override global::G.Content6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.InputContent? inputContent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputContent).Name}");
                inputContent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            readerCopy = reader;
            global::G.OutputContent? outputContent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputContent).Name}");
                outputContent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            var __value = new global::G.Content6(
                inputContent,

                outputContent
                );

            if (inputContent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputContent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Content6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputContent, typeInfo);
            }
            else if (value.IsOutputContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputContent, typeInfo);
            }
        }
    }
}