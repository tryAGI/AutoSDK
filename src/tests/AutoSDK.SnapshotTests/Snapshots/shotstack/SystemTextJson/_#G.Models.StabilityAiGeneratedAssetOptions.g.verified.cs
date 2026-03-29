//HintName: G.Models.StabilityAiGeneratedAssetOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using Stability AI provider AI services.<br/>
    /// The following AI generation services are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;&lt;a href="#tocs_stabilityaitexttoimageoptions"&gt;StabilityAiTextToImageOptions&lt;/a&gt;&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public readonly partial struct StabilityAiGeneratedAssetOptions : global::System.IEquatable<StabilityAiGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the Stability AI text-to-image service. Set a text prompt to generate an image from plus other engine and configuration options. The output will be generated as a JPG file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StabilityAiTextToImageOptions? TextToImage { get; init; }
#else
        public global::G.StabilityAiTextToImageOptions? TextToImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImage))]
#endif
        public bool IsTextToImage => TextToImage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StabilityAiGeneratedAssetOptions(global::G.StabilityAiTextToImageOptions value) => new StabilityAiGeneratedAssetOptions((global::G.StabilityAiTextToImageOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StabilityAiTextToImageOptions?(StabilityAiGeneratedAssetOptions @this) => @this.TextToImage;

        /// <summary>
        /// 
        /// </summary>
        public StabilityAiGeneratedAssetOptions(global::G.StabilityAiTextToImageOptions? value)
        {
            TextToImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StabilityAiGeneratedAssetOptions(
            global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType? type,
            global::G.StabilityAiTextToImageOptions? textToImage
            )
        {
            Type = type;

            TextToImage = textToImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToImage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToImage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StabilityAiTextToImageOptions?, TResult>? textToImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToImage && textToImage != null)
            {
                return textToImage(TextToImage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StabilityAiTextToImageOptions?>? textToImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToImage)
            {
                textToImage?.Invoke(TextToImage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToImage,
                typeof(global::G.StabilityAiTextToImageOptions),
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
        public bool Equals(StabilityAiGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StabilityAiTextToImageOptions?>.Default.Equals(TextToImage, other.TextToImage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StabilityAiGeneratedAssetOptions obj1, StabilityAiGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StabilityAiGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StabilityAiGeneratedAssetOptions obj1, StabilityAiGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StabilityAiGeneratedAssetOptions o && Equals(o);
        }
    }
}
