//HintName: G.Models.ChunksVariant1Item3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChunksVariant1Item3 : global::System.IEquatable<ChunksVariant1Item3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.StoreFileChunksVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextInputChunk? Text { get; init; }
#else
        public global::G.TextInputChunk? Text { get; }
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
        public global::G.ImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::G.ImageUrlInputChunk? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::G.AudioUrlInputChunk? AudioUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl))]
#endif
        public bool IsAudioUrl => AudioUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::G.VideoUrlInputChunk? VideoUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUrl))]
#endif
        public bool IsVideoUrl => VideoUrl != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item3(global::G.TextInputChunk value) => new ChunksVariant1Item3((global::G.TextInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextInputChunk?(ChunksVariant1Item3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item3(global::G.TextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item3(global::G.ImageUrlInputChunk value) => new ChunksVariant1Item3((global::G.ImageUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageUrlInputChunk?(ChunksVariant1Item3 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item3(global::G.ImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item3(global::G.AudioUrlInputChunk value) => new ChunksVariant1Item3((global::G.AudioUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AudioUrlInputChunk?(ChunksVariant1Item3 @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item3(global::G.AudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunksVariant1Item3(global::G.VideoUrlInputChunk value) => new ChunksVariant1Item3((global::G.VideoUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VideoUrlInputChunk?(ChunksVariant1Item3 @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item3(global::G.VideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunksVariant1Item3(
            global::G.StoreFileChunksVariant1ItemDiscriminatorType? type,
            global::G.TextInputChunk? text,
            global::G.ImageUrlInputChunk? imageUrl,
            global::G.AudioUrlInputChunk? audioUrl,
            global::G.VideoUrlInputChunk? videoUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            AudioUrl = audioUrl;
            VideoUrl = videoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            AudioUrl as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            AudioUrl?.ToString() ??
            VideoUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsText && IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsText && !IsImageUrl && IsAudioUrl && !IsVideoUrl || !IsText && !IsImageUrl && !IsAudioUrl && IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextInputChunk?, TResult>? text = null,
            global::System.Func<global::G.ImageUrlInputChunk?, TResult>? imageUrl = null,
            global::System.Func<global::G.AudioUrlInputChunk?, TResult>? audioUrl = null,
            global::System.Func<global::G.VideoUrlInputChunk?, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsAudioUrl && audioUrl != null)
            {
                return audioUrl(AudioUrl!);
            }
            else if (IsVideoUrl && videoUrl != null)
            {
                return videoUrl(VideoUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextInputChunk?>? text = null,
            global::System.Action<global::G.ImageUrlInputChunk?>? imageUrl = null,
            global::System.Action<global::G.AudioUrlInputChunk?>? audioUrl = null,
            global::System.Action<global::G.VideoUrlInputChunk?>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
            else if (IsVideoUrl)
            {
                videoUrl?.Invoke(VideoUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.TextInputChunk),
                ImageUrl,
                typeof(global::G.ImageUrlInputChunk),
                AudioUrl,
                typeof(global::G.AudioUrlInputChunk),
                VideoUrl,
                typeof(global::G.VideoUrlInputChunk),
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
        public bool Equals(ChunksVariant1Item3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunksVariant1Item3 obj1, ChunksVariant1Item3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunksVariant1Item3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunksVariant1Item3 obj1, ChunksVariant1Item3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunksVariant1Item3 o && Equals(o);
        }
    }
}
