﻿//HintName: G.JsonConverters.CodeInterpreterToolOutput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CodeInterpreterToolOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeInterpreterToolOutput>
    {
        /// <inheritdoc />
        public override global::G.CodeInterpreterToolOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.CodeInterpreterTextOutput? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTextOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTextOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTextOutput).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.CodeInterpreterFileOutput? file = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterFileOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterFileOutput).Name}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.CodeInterpreterToolOutput(
                text,
                file
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTextOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTextOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTextOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (file != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterFileOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterFileOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeInterpreterToolOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterTextOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterTextOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterTextOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeInterpreterFileOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeInterpreterFileOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
        }
    }
}