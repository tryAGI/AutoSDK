//HintName: G.Models.Request.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The request of the generation
    /// </summary>
    public readonly partial struct Request : global::System.IEquatable<Request>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GenerationRequestDiscriminatorGenerationType? GenerationType { get; }

        /// <summary>
        /// The generation request object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationRequest? Video { get; init; }
#else
        public global::G.GenerationRequest? Video { get; }
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
        public static implicit operator Request(global::G.GenerationRequest value) => new Request(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequest?(Request @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::G.GenerationRequest? value)
        {
            Video = value;
        }

        /// <summary>
        /// The image generation request object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageGenerationRequest? Image { get; init; }
#else
        public global::G.ImageGenerationRequest? Image { get; }
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
        public static implicit operator Request(global::G.ImageGenerationRequest value) => new Request(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenerationRequest?(Request @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::G.ImageGenerationRequest? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Request(
            global::G.GenerationRequestDiscriminatorGenerationType? generationType,
            global::G.GenerationRequest? video,
            global::G.ImageGenerationRequest? image
            )
        {
            GenerationType = generationType;

            Video = video;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Video as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsImage || !IsVideo && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerationRequest?, TResult>? video = null,
            global::System.Func<global::G.ImageGenerationRequest?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
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
            global::System.Action<global::G.GenerationRequest?>? video = null,
            global::System.Action<global::G.ImageGenerationRequest?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
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
                Video,
                typeof(global::G.GenerationRequest),
                Image,
                typeof(global::G.ImageGenerationRequest),
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
        public bool Equals(Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequest?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenerationRequest?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request obj1, Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request obj1, Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request o && Equals(o);
        }
    }
}
