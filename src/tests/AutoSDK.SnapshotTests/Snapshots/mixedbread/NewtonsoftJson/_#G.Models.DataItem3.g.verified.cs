//HintName: G.Models.DataItem3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem3 : global::System.IEquatable<DataItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchResponseDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Scored text chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? Text { get; init; }
#else
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// Scored image chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// Scored audio chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? AudioUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl))]
#endif
        public bool IsAudioUrl => AudioUrl != null;

        /// <summary>
        /// Scored video chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? VideoUrl { get; }
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
        public static implicit operator DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk value) => new DataItem3((global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?(DataItem3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk value) => new DataItem3((global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?(DataItem3 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk value) => new DataItem3((global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?(DataItem3 @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk value) => new DataItem3((global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?(DataItem3 @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem3(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem3(
            global::G.VectorStoreSearchResponseDataItemDiscriminatorType? type,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? text,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? imageUrl,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? audioUrl,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? videoUrl
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
            global::System.Func<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?, TResult>? text = null,
            global::System.Func<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?, TResult>? imageUrl = null,
            global::System.Func<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?, TResult>? audioUrl = null,
            global::System.Func<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?, TResult>? videoUrl = null,
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
            global::System.Action<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?>? text = null,
            global::System.Action<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?>? imageUrl = null,
            global::System.Action<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?>? audioUrl = null,
            global::System.Action<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?>? videoUrl = null,
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
                typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk),
                ImageUrl,
                typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk),
                AudioUrl,
                typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk),
                VideoUrl,
                typeof(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk),
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
        public bool Equals(DataItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem3 obj1, DataItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem3 obj1, DataItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem3 o && Equals(o);
        }
    }
}
