//HintName: G.Models.Asset1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The asset itself.
    /// </summary>
    public readonly partial struct Asset1 : global::System.IEquatable<Asset1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssetAsset1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UploadedImage? UploadedImage { get; init; }
#else
        public global::G.UploadedImage? UploadedImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadedImage))]
#endif
        public bool IsUploadedImage => UploadedImage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UploadedAudio? UploadedAudio { get; init; }
#else
        public global::G.UploadedAudio? UploadedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadedAudio))]
#endif
        public bool IsUploadedAudio => UploadedAudio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UploadedVideo? UploadedVideo { get; init; }
#else
        public global::G.UploadedVideo? UploadedVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadedVideo))]
#endif
        public bool IsUploadedVideo => UploadedVideo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GeneratedAudio? GeneratedAudio { get; init; }
#else
        public global::G.GeneratedAudio? GeneratedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeneratedAudio))]
#endif
        public bool IsGeneratedAudio => GeneratedAudio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GeneratedImage? GeneratedImage { get; init; }
#else
        public global::G.GeneratedImage? GeneratedImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeneratedImage))]
#endif
        public bool IsGeneratedImage => GeneratedImage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GeneratedVideo? GeneratedVideo { get; init; }
#else
        public global::G.GeneratedVideo? GeneratedVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeneratedVideo))]
#endif
        public bool IsGeneratedVideo => GeneratedVideo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Voice? Voice { get; init; }
#else
        public global::G.Voice? Voice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Voice))]
#endif
        public bool IsVoice => Voice != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.UploadedImage value) => new Asset1((global::G.UploadedImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UploadedImage?(Asset1 @this) => @this.UploadedImage;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.UploadedImage? value)
        {
            UploadedImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.UploadedAudio value) => new Asset1((global::G.UploadedAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UploadedAudio?(Asset1 @this) => @this.UploadedAudio;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.UploadedAudio? value)
        {
            UploadedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.UploadedVideo value) => new Asset1((global::G.UploadedVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UploadedVideo?(Asset1 @this) => @this.UploadedVideo;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.UploadedVideo? value)
        {
            UploadedVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.GeneratedAudio value) => new Asset1((global::G.GeneratedAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeneratedAudio?(Asset1 @this) => @this.GeneratedAudio;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.GeneratedAudio? value)
        {
            GeneratedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.GeneratedImage value) => new Asset1((global::G.GeneratedImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeneratedImage?(Asset1 @this) => @this.GeneratedImage;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.GeneratedImage? value)
        {
            GeneratedImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.GeneratedVideo value) => new Asset1((global::G.GeneratedVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeneratedVideo?(Asset1 @this) => @this.GeneratedVideo;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.GeneratedVideo? value)
        {
            GeneratedVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::G.Voice value) => new Asset1((global::G.Voice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Voice?(Asset1 @this) => @this.Voice;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::G.Voice? value)
        {
            Voice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Asset1(
            global::G.AssetAsset1DiscriminatorType? type,
            global::G.UploadedImage? uploadedImage,
            global::G.UploadedAudio? uploadedAudio,
            global::G.UploadedVideo? uploadedVideo,
            global::G.GeneratedAudio? generatedAudio,
            global::G.GeneratedImage? generatedImage,
            global::G.GeneratedVideo? generatedVideo,
            global::G.Voice? voice
            )
        {
            Type = type;

            UploadedImage = uploadedImage;
            UploadedAudio = uploadedAudio;
            UploadedVideo = uploadedVideo;
            GeneratedAudio = generatedAudio;
            GeneratedImage = generatedImage;
            GeneratedVideo = generatedVideo;
            Voice = voice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Voice as object ??
            GeneratedVideo as object ??
            GeneratedImage as object ??
            GeneratedAudio as object ??
            UploadedVideo as object ??
            UploadedAudio as object ??
            UploadedImage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UploadedImage?.ToString() ??
            UploadedAudio?.ToString() ??
            UploadedVideo?.ToString() ??
            GeneratedAudio?.ToString() ??
            GeneratedImage?.ToString() ??
            GeneratedVideo?.ToString() ??
            Voice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && IsVoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UploadedImage?, TResult>? uploadedImage = null,
            global::System.Func<global::G.UploadedAudio?, TResult>? uploadedAudio = null,
            global::System.Func<global::G.UploadedVideo?, TResult>? uploadedVideo = null,
            global::System.Func<global::G.GeneratedAudio?, TResult>? generatedAudio = null,
            global::System.Func<global::G.GeneratedImage?, TResult>? generatedImage = null,
            global::System.Func<global::G.GeneratedVideo?, TResult>? generatedVideo = null,
            global::System.Func<global::G.Voice?, TResult>? voice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUploadedImage && uploadedImage != null)
            {
                return uploadedImage(UploadedImage!);
            }
            else if (IsUploadedAudio && uploadedAudio != null)
            {
                return uploadedAudio(UploadedAudio!);
            }
            else if (IsUploadedVideo && uploadedVideo != null)
            {
                return uploadedVideo(UploadedVideo!);
            }
            else if (IsGeneratedAudio && generatedAudio != null)
            {
                return generatedAudio(GeneratedAudio!);
            }
            else if (IsGeneratedImage && generatedImage != null)
            {
                return generatedImage(GeneratedImage!);
            }
            else if (IsGeneratedVideo && generatedVideo != null)
            {
                return generatedVideo(GeneratedVideo!);
            }
            else if (IsVoice && voice != null)
            {
                return voice(Voice!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UploadedImage?>? uploadedImage = null,
            global::System.Action<global::G.UploadedAudio?>? uploadedAudio = null,
            global::System.Action<global::G.UploadedVideo?>? uploadedVideo = null,
            global::System.Action<global::G.GeneratedAudio?>? generatedAudio = null,
            global::System.Action<global::G.GeneratedImage?>? generatedImage = null,
            global::System.Action<global::G.GeneratedVideo?>? generatedVideo = null,
            global::System.Action<global::G.Voice?>? voice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUploadedImage)
            {
                uploadedImage?.Invoke(UploadedImage!);
            }
            else if (IsUploadedAudio)
            {
                uploadedAudio?.Invoke(UploadedAudio!);
            }
            else if (IsUploadedVideo)
            {
                uploadedVideo?.Invoke(UploadedVideo!);
            }
            else if (IsGeneratedAudio)
            {
                generatedAudio?.Invoke(GeneratedAudio!);
            }
            else if (IsGeneratedImage)
            {
                generatedImage?.Invoke(GeneratedImage!);
            }
            else if (IsGeneratedVideo)
            {
                generatedVideo?.Invoke(GeneratedVideo!);
            }
            else if (IsVoice)
            {
                voice?.Invoke(Voice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UploadedImage,
                typeof(global::G.UploadedImage),
                UploadedAudio,
                typeof(global::G.UploadedAudio),
                UploadedVideo,
                typeof(global::G.UploadedVideo),
                GeneratedAudio,
                typeof(global::G.GeneratedAudio),
                GeneratedImage,
                typeof(global::G.GeneratedImage),
                GeneratedVideo,
                typeof(global::G.GeneratedVideo),
                Voice,
                typeof(global::G.Voice),
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
        public bool Equals(Asset1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UploadedImage?>.Default.Equals(UploadedImage, other.UploadedImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UploadedAudio?>.Default.Equals(UploadedAudio, other.UploadedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UploadedVideo?>.Default.Equals(UploadedVideo, other.UploadedVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeneratedAudio?>.Default.Equals(GeneratedAudio, other.GeneratedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeneratedImage?>.Default.Equals(GeneratedImage, other.GeneratedImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeneratedVideo?>.Default.Equals(GeneratedVideo, other.GeneratedVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Voice?>.Default.Equals(Voice, other.Voice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Asset1 obj1, Asset1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Asset1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Asset1 obj1, Asset1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Asset1 o && Equals(o);
        }
    }
}
