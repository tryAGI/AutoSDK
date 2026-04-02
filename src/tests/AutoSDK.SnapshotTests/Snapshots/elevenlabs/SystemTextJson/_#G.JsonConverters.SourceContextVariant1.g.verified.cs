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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator>(ref readerCopy, options);

            global::G.SongSourceContext? musicExploreSong1 = default;
            if (discriminator?.SourceType == global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong)
            {
                musicExploreSong1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SongSourceContext>(ref reader, options);
            }
            global::G.MusicExploreSongSourceContext? musicExploreSong2 = default;
            if (discriminator?.SourceType == global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong)
            {
                musicExploreSong2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MusicExploreSongSourceContext>(ref reader, options);
            }
            global::G.SfxSourceContext? sfx = default;
            if (discriminator?.SourceType == global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Sfx)
            {
                sfx = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SfxSourceContext>(ref reader, options);
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

            if (value.IsMusicExploreSong1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MusicExploreSong1, typeof(global::G.SongSourceContext), options);
            }
            else if (value.IsMusicExploreSong2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MusicExploreSong2, typeof(global::G.MusicExploreSongSourceContext), options);
            }
            else if (value.IsSfx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sfx, typeof(global::G.SfxSourceContext), options);
            }
        }
    }
}