//HintName: G.JsonConverters.Asset.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AssetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Asset>
    {
        /// <inheritdoc />
        public override global::G.Asset Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.VideoAsset? video = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VideoAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VideoAsset)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageAsset? image = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageAsset)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextAsset? text = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextAsset)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RichTextAsset? richText = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.RichText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RichTextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RichTextAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RichTextAsset)}");
                richText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AudioAsset? audio = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AudioAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AudioAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AudioAsset)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LumaAsset? luma = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Luma)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LumaAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LumaAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LumaAsset)}");
                luma = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CaptionAsset? caption = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Caption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CaptionAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CaptionAsset)}");
                caption = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RichCaptionAsset? richCaption = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.RichCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RichCaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RichCaptionAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RichCaptionAsset)}");
                richCaption = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HtmlAsset? html = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Html)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HtmlAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HtmlAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HtmlAsset)}");
                html = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TitleAsset? title = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Title)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TitleAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TitleAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TitleAsset)}");
                title = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ShapeAsset? shape = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Shape)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShapeAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShapeAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShapeAsset)}");
                shape = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgAsset? svg = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.Svg)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgAsset)}");
                svg = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextToImageAsset? textToImage = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.TextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToImageAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextToImageAsset)}");
                textToImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageToVideoAsset? imageToVideo = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.ImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageToVideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageToVideoAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageToVideoAsset)}");
                imageToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextToSpeechAsset? textToSpeech = default;
            if (discriminator?.Type == global::G.AssetDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextToSpeechAsset)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Asset(
                discriminator?.Type,
                video,

                image,

                text,

                richText,

                audio,

                luma,

                caption,

                richCaption,

                html,

                title,

                shape,

                svg,

                textToImage,

                imageToVideo,

                textToSpeech
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Asset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VideoAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VideoAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsRichText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RichTextAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RichTextAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RichTextAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RichText!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AudioAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AudioAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AudioAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsLuma)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LumaAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LumaAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LumaAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Luma!, typeInfo);
            }
            else if (value.IsCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CaptionAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CaptionAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Caption!, typeInfo);
            }
            else if (value.IsRichCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RichCaptionAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RichCaptionAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RichCaptionAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RichCaption!, typeInfo);
            }
            else if (value.IsHtml)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HtmlAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HtmlAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HtmlAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Html!, typeInfo);
            }
            else if (value.IsTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TitleAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TitleAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TitleAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Title!, typeInfo);
            }
            else if (value.IsShape)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShapeAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShapeAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShapeAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shape!, typeInfo);
            }
            else if (value.IsSvg)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Svg!, typeInfo);
            }
            else if (value.IsTextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToImageAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToImageAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToImageAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToImage!, typeInfo);
            }
            else if (value.IsImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageToVideoAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageToVideoAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageToVideoAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageToVideo!, typeInfo);
            }
            else if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech!, typeInfo);
            }
        }
    }
}