//HintName: G.Models.DataItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem2 : global::System.IEquatable<DataItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.StoreSearchResponseDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? Text { get; init; }
#else
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? Text { get; }
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
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? ImageUrl { get; }
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
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? AudioUrl { get; }
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
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? VideoUrl { get; }
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
        public static implicit operator DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk value) => new DataItem2((global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?(DataItem2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk value) => new DataItem2((global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?(DataItem2 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk value) => new DataItem2((global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?(DataItem2 @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk value) => new DataItem2((global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?(DataItem2 @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(
            global::G.StoreSearchResponseDataItemDiscriminatorType? type,
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk? text,
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk? imageUrl,
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk? audioUrl,
            global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk? videoUrl
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
            global::System.Func<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?, TResult>? text = null,
            global::System.Func<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?, TResult>? imageUrl = null,
            global::System.Func<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?, TResult>? audioUrl = null,
            global::System.Func<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?, TResult>? videoUrl = null,
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
            global::System.Action<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?>? text = null,
            global::System.Action<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?>? imageUrl = null,
            global::System.Action<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?>? audioUrl = null,
            global::System.Action<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?>? videoUrl = null,
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
                typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk),
                ImageUrl,
                typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk),
                AudioUrl,
                typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk),
                VideoUrl,
                typeof(global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk),
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
        public bool Equals(DataItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem2 obj1, DataItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem2 obj1, DataItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem2 o && Equals(o);
        }
    }
}
