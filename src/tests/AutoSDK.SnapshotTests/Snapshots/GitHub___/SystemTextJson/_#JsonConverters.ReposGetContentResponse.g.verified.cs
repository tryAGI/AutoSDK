//HintName: JsonConverters.ReposGetContentResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ReposGetContentResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposGetContentResponse>
    {
        /// <inheritdoc />
        public override global::G.ReposGetContentResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentFile? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentFile).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentSymlink? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSymlink).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentSubmodule? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSubmodule).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ReposGetContentResponse(
                value1,
                value2,
                value3,
                value4
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentFile).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSymlink).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSubmodule).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetContentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSymlink?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSymlink).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSubmodule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSubmodule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
        }
    }
}