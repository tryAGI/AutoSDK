//HintName: G.Models.ShotstackGeneratedAssetOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using the native Shotstack provider AI services.
    /// </summary>
    public readonly partial struct ShotstackGeneratedAssetOptions : global::System.IEquatable<ShotstackGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ShotstackGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the Shotstack text-to-speech service. Set the text to be converted to speech and choose a voice to set the speaking style. The output will be generated as an MP3 audio file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShotstackTextToSpeechOptions? TextToSpeech { get; init; }
#else
        public global::G.ShotstackTextToSpeechOptions? TextToSpeech { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeech))]
#endif
        public bool IsTextToSpeech => TextToSpeech != null;

        /// <summary>
        /// Options for the Shotstack text-to-image service. Set a text prompt to generate an image from. The output will be  generated as a PNG file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShotstackTextToImageOptions? TextToImage { get; init; }
#else
        public global::G.ShotstackTextToImageOptions? TextToImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImage))]
#endif
        public bool IsTextToImage => TextToImage != null;

        /// <summary>
        /// Options for the Shotstack text-generator service. Set a text prompt that will be used to generate a new body of text. The output will be generated as a text (txt) file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShotstackTextGeneratorOptions? TextGenerator { get; init; }
#else
        public global::G.ShotstackTextGeneratorOptions? TextGenerator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGenerator))]
#endif
        public bool IsTextGenerator => TextGenerator != null;

        /// <summary>
        /// Options for the Shotstack image-to-video service. Set the URL of an image to convert in to a video. The output will be generated as an MP4 file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShotstackImageToVideoOptions? ImageToVideo { get; init; }
#else
        public global::G.ShotstackImageToVideoOptions? ImageToVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToVideo))]
#endif
        public bool IsImageToVideo => ImageToVideo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::G.ShotstackTextToSpeechOptions value) => new ShotstackGeneratedAssetOptions((global::G.ShotstackTextToSpeechOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShotstackTextToSpeechOptions?(ShotstackGeneratedAssetOptions @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::G.ShotstackTextToSpeechOptions? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::G.ShotstackTextToImageOptions value) => new ShotstackGeneratedAssetOptions((global::G.ShotstackTextToImageOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShotstackTextToImageOptions?(ShotstackGeneratedAssetOptions @this) => @this.TextToImage;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::G.ShotstackTextToImageOptions? value)
        {
            TextToImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::G.ShotstackTextGeneratorOptions value) => new ShotstackGeneratedAssetOptions((global::G.ShotstackTextGeneratorOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShotstackTextGeneratorOptions?(ShotstackGeneratedAssetOptions @this) => @this.TextGenerator;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::G.ShotstackTextGeneratorOptions? value)
        {
            TextGenerator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShotstackGeneratedAssetOptions(global::G.ShotstackImageToVideoOptions value) => new ShotstackGeneratedAssetOptions((global::G.ShotstackImageToVideoOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShotstackImageToVideoOptions?(ShotstackGeneratedAssetOptions @this) => @this.ImageToVideo;

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(global::G.ShotstackImageToVideoOptions? value)
        {
            ImageToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShotstackGeneratedAssetOptions(
            global::G.ShotstackGeneratedAssetOptionsDiscriminatorType? type,
            global::G.ShotstackTextToSpeechOptions? textToSpeech,
            global::G.ShotstackTextToImageOptions? textToImage,
            global::G.ShotstackTextGeneratorOptions? textGenerator,
            global::G.ShotstackImageToVideoOptions? imageToVideo
            )
        {
            Type = type;

            TextToSpeech = textToSpeech;
            TextToImage = textToImage;
            TextGenerator = textGenerator;
            ImageToVideo = imageToVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageToVideo as object ??
            TextGenerator as object ??
            TextToImage as object ??
            TextToSpeech as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToSpeech?.ToString() ??
            TextToImage?.ToString() ??
            TextGenerator?.ToString() ??
            ImageToVideo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToSpeech && !IsTextToImage && !IsTextGenerator && !IsImageToVideo || !IsTextToSpeech && IsTextToImage && !IsTextGenerator && !IsImageToVideo || !IsTextToSpeech && !IsTextToImage && IsTextGenerator && !IsImageToVideo || !IsTextToSpeech && !IsTextToImage && !IsTextGenerator && IsImageToVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ShotstackTextToSpeechOptions?, TResult>? textToSpeech = null,
            global::System.Func<global::G.ShotstackTextToImageOptions?, TResult>? textToImage = null,
            global::System.Func<global::G.ShotstackTextGeneratorOptions?, TResult>? textGenerator = null,
            global::System.Func<global::G.ShotstackImageToVideoOptions?, TResult>? imageToVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }
            else if (IsTextToImage && textToImage != null)
            {
                return textToImage(TextToImage!);
            }
            else if (IsTextGenerator && textGenerator != null)
            {
                return textGenerator(TextGenerator!);
            }
            else if (IsImageToVideo && imageToVideo != null)
            {
                return imageToVideo(ImageToVideo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ShotstackTextToSpeechOptions?>? textToSpeech = null,
            global::System.Action<global::G.ShotstackTextToImageOptions?>? textToImage = null,
            global::System.Action<global::G.ShotstackTextGeneratorOptions?>? textGenerator = null,
            global::System.Action<global::G.ShotstackImageToVideoOptions?>? imageToVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
            else if (IsTextToImage)
            {
                textToImage?.Invoke(TextToImage!);
            }
            else if (IsTextGenerator)
            {
                textGenerator?.Invoke(TextGenerator!);
            }
            else if (IsImageToVideo)
            {
                imageToVideo?.Invoke(ImageToVideo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToSpeech,
                typeof(global::G.ShotstackTextToSpeechOptions),
                TextToImage,
                typeof(global::G.ShotstackTextToImageOptions),
                TextGenerator,
                typeof(global::G.ShotstackTextGeneratorOptions),
                ImageToVideo,
                typeof(global::G.ShotstackImageToVideoOptions),
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
        public bool Equals(ShotstackGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ShotstackTextToSpeechOptions?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShotstackTextToImageOptions?>.Default.Equals(TextToImage, other.TextToImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShotstackTextGeneratorOptions?>.Default.Equals(TextGenerator, other.TextGenerator) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShotstackImageToVideoOptions?>.Default.Equals(ImageToVideo, other.ImageToVideo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShotstackGeneratedAssetOptions obj1, ShotstackGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShotstackGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShotstackGeneratedAssetOptions obj1, ShotstackGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShotstackGeneratedAssetOptions o && Equals(o);
        }
    }
}
