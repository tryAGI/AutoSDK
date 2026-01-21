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
        /// The generation request object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationRequest? Generation { get; init; }
#else
        public global::G.GenerationRequest? Generation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        /// The image generation request object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageGenerationRequest? ImageGeneration { get; init; }
#else
        public global::G.ImageGenerationRequest? ImageGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGeneration))]
#endif
        public bool IsImageGeneration => ImageGeneration != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request(global::G.GenerationRequest value) => new Request((global::G.GenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequest?(Request @this) => @this.Generation;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::G.GenerationRequest? value)
        {
            Generation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request(global::G.ImageGenerationRequest value) => new Request((global::G.ImageGenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenerationRequest?(Request @this) => @this.ImageGeneration;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::G.ImageGenerationRequest? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Request(
            global::G.GenerationRequest? generation,
            global::G.ImageGenerationRequest? imageGeneration
            )
        {
            Generation = generation;
            ImageGeneration = imageGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageGeneration as object ??
            Generation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generation?.ToString() ??
            ImageGeneration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGeneration && !IsImageGeneration || !IsGeneration && IsImageGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerationRequest?, TResult>? generation = null,
            global::System.Func<global::G.ImageGenerationRequest?, TResult>? imageGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration && generation != null)
            {
                return generation(Generation!);
            }
            else if (IsImageGeneration && imageGeneration != null)
            {
                return imageGeneration(ImageGeneration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerationRequest?>? generation = null,
            global::System.Action<global::G.ImageGenerationRequest?>? imageGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration)
            {
                generation?.Invoke(Generation!);
            }
            else if (IsImageGeneration)
            {
                imageGeneration?.Invoke(ImageGeneration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Generation,
                typeof(global::G.GenerationRequest),
                ImageGeneration,
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
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequest?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenerationRequest?>.Default.Equals(ImageGeneration, other.ImageGeneration) 
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
