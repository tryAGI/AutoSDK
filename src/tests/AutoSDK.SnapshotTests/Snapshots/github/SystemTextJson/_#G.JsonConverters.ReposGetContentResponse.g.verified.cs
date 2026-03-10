//HintName: G.JsonConverters.ReposGetContentResponse.g.cs
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
            global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? contentDirectory = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>).Name}");
                contentDirectory = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentFile? file = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentFile).Name}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentSymlink? symlink = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSymlink).Name}");
                symlink = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ContentSubmodule? submodule = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSubmodule).Name}");
                submodule = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.ReposGetContentResponse(
                contentDirectory,

                file,

                symlink,

                submodule
                );

            if (contentDirectory != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (file != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentFile).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (symlink != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSymlink).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (submodule != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSubmodule).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetContentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsContentDirectory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDirectory, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsSymlink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSymlink?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSymlink).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Symlink, typeInfo);
            }
            else if (value.IsSubmodule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContentSubmodule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContentSubmodule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Submodule, typeInfo);
            }
        }
    }
}