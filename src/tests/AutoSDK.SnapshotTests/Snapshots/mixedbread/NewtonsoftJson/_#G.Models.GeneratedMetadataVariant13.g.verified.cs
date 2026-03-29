//HintName: G.Models.GeneratedMetadataVariant13.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GeneratedMetadataVariant13 : global::System.IEquatable<GeneratedMetadataVariant13>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.TextInputChunkGeneratedMetadataVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MarkdownChunkGeneratedMetadata? Markdown { get; init; }
#else
        public global::G.MarkdownChunkGeneratedMetadata? Markdown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Markdown))]
#endif
        public bool IsMarkdown => Markdown != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextChunkGeneratedMetadata? Text { get; init; }
#else
        public global::G.TextChunkGeneratedMetadata? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PDFChunkGeneratedMetadata? Pdf { get; init; }
#else
        public global::G.PDFChunkGeneratedMetadata? Pdf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pdf))]
#endif
        public bool IsPdf => Pdf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeChunkGeneratedMetadata? Code { get; init; }
#else
        public global::G.CodeChunkGeneratedMetadata? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AudioChunkGeneratedMetadata? Audio { get; init; }
#else
        public global::G.AudioChunkGeneratedMetadata? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VideoChunkGeneratedMetadata? Video { get; init; }
#else
        public global::G.VideoChunkGeneratedMetadata? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageChunkGeneratedMetadata? Image { get; init; }
#else
        public global::G.ImageChunkGeneratedMetadata? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.MarkdownChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.MarkdownChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MarkdownChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Markdown;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.MarkdownChunkGeneratedMetadata? value)
        {
            Markdown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.TextChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.TextChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.TextChunkGeneratedMetadata? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.PDFChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.PDFChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PDFChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Pdf;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.PDFChunkGeneratedMetadata? value)
        {
            Pdf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.CodeChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.CodeChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.CodeChunkGeneratedMetadata? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.AudioChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.AudioChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AudioChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.AudioChunkGeneratedMetadata? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.VideoChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.VideoChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VideoChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.VideoChunkGeneratedMetadata? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GeneratedMetadataVariant13(global::G.ImageChunkGeneratedMetadata value) => new GeneratedMetadataVariant13((global::G.ImageChunkGeneratedMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageChunkGeneratedMetadata?(GeneratedMetadataVariant13 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(global::G.ImageChunkGeneratedMetadata? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GeneratedMetadataVariant13(
            global::G.TextInputChunkGeneratedMetadataVariant1DiscriminatorType? type,
            global::G.MarkdownChunkGeneratedMetadata? markdown,
            global::G.TextChunkGeneratedMetadata? text,
            global::G.PDFChunkGeneratedMetadata? pdf,
            global::G.CodeChunkGeneratedMetadata? code,
            global::G.AudioChunkGeneratedMetadata? audio,
            global::G.VideoChunkGeneratedMetadata? video,
            global::G.ImageChunkGeneratedMetadata? image
            )
        {
            Type = type;

            Markdown = markdown;
            Text = text;
            Pdf = pdf;
            Code = code;
            Audio = audio;
            Video = video;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Video as object ??
            Audio as object ??
            Code as object ??
            Pdf as object ??
            Text as object ??
            Markdown as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Markdown?.ToString() ??
            Text?.ToString() ??
            Pdf?.ToString() ??
            Code?.ToString() ??
            Audio?.ToString() ??
            Video?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MarkdownChunkGeneratedMetadata?, TResult>? markdown = null,
            global::System.Func<global::G.TextChunkGeneratedMetadata?, TResult>? text = null,
            global::System.Func<global::G.PDFChunkGeneratedMetadata?, TResult>? pdf = null,
            global::System.Func<global::G.CodeChunkGeneratedMetadata?, TResult>? code = null,
            global::System.Func<global::G.AudioChunkGeneratedMetadata?, TResult>? audio = null,
            global::System.Func<global::G.VideoChunkGeneratedMetadata?, TResult>? video = null,
            global::System.Func<global::G.ImageChunkGeneratedMetadata?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMarkdown && markdown != null)
            {
                return markdown(Markdown!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsPdf && pdf != null)
            {
                return pdf(Pdf!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MarkdownChunkGeneratedMetadata?>? markdown = null,
            global::System.Action<global::G.TextChunkGeneratedMetadata?>? text = null,
            global::System.Action<global::G.PDFChunkGeneratedMetadata?>? pdf = null,
            global::System.Action<global::G.CodeChunkGeneratedMetadata?>? code = null,
            global::System.Action<global::G.AudioChunkGeneratedMetadata?>? audio = null,
            global::System.Action<global::G.VideoChunkGeneratedMetadata?>? video = null,
            global::System.Action<global::G.ImageChunkGeneratedMetadata?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMarkdown)
            {
                markdown?.Invoke(Markdown!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsPdf)
            {
                pdf?.Invoke(Pdf!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Markdown,
                typeof(global::G.MarkdownChunkGeneratedMetadata),
                Text,
                typeof(global::G.TextChunkGeneratedMetadata),
                Pdf,
                typeof(global::G.PDFChunkGeneratedMetadata),
                Code,
                typeof(global::G.CodeChunkGeneratedMetadata),
                Audio,
                typeof(global::G.AudioChunkGeneratedMetadata),
                Video,
                typeof(global::G.VideoChunkGeneratedMetadata),
                Image,
                typeof(global::G.ImageChunkGeneratedMetadata),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GeneratedMetadataVariant13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MarkdownChunkGeneratedMetadata?>.Default.Equals(Markdown, other.Markdown) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextChunkGeneratedMetadata?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PDFChunkGeneratedMetadata?>.Default.Equals(Pdf, other.Pdf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeChunkGeneratedMetadata?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AudioChunkGeneratedMetadata?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VideoChunkGeneratedMetadata?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageChunkGeneratedMetadata?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GeneratedMetadataVariant13 obj1, GeneratedMetadataVariant13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GeneratedMetadataVariant13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GeneratedMetadataVariant13 obj1, GeneratedMetadataVariant13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GeneratedMetadataVariant13 o && Equals(o);
        }
    }
}
