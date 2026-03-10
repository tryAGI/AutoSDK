//HintName: G.JsonConverters.SourceContextVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceContextVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SourceContextVariant1>
    {
        /// <inheritdoc />
        public override global::G.SourceContextVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SongSourceContext? musicExploreSong1 = default;
            if (discriminator?.SourceType == global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SongSourceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SongSourceContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SongSourceContext)}");
                musicExploreSong1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MusicExploreSongSourceContext? musicExploreSong2 = default;
            if (discriminator?.SourceType == global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MusicExploreSongSourceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MusicExploreSongSourceContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MusicExploreSongSourceContext)}");
                musicExploreSong2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SfxSourceContext? sfx = default;
            if (discriminator?.SourceType == global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Sfx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SfxSourceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SfxSourceContext> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SfxSourceContext)}");
                sfx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.SourceContextVariant1(
                discriminator?.SourceType,
                musicExploreSong1,

                musicExploreSong2,

                sfx
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SourceContextVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMusicExploreSong1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SongSourceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SongSourceContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SongSourceContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MusicExploreSong1, typeInfo);
            }
            else if (value.IsMusicExploreSong2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MusicExploreSongSourceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MusicExploreSongSourceContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MusicExploreSongSourceContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MusicExploreSong2, typeInfo);
            }
            else if (value.IsSfx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SfxSourceContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SfxSourceContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SfxSourceContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sfx, typeInfo);
            }
        }
    }
}