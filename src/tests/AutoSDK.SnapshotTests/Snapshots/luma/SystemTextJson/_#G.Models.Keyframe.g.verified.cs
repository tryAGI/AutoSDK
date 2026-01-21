//HintName: G.Models.Keyframe.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A keyframe can be either a Generation reference, an Image, or a Video
    /// </summary>
    public readonly partial struct Keyframe : global::System.IEquatable<Keyframe>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.KeyframeDiscriminatorType? Type { get; }

        /// <summary>
        /// The generation reference object<br/>
        /// Example: {"type":"generation","id":"123e4567-e89b-12d3-a456-426614174002"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationReference? Generation { get; init; }
#else
        public global::G.GenerationReference? Generation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        /// The image object<br/>
        /// Example: {"type":"image","url":"https://example.com/image.jpg"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageReference? Image { get; init; }
#else
        public global::G.ImageReference? Image { get; }
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
        public static implicit operator Keyframe(global::G.GenerationReference value) => new Keyframe((global::G.GenerationReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationReference?(Keyframe @this) => @this.Generation;

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(global::G.GenerationReference? value)
        {
            Generation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Keyframe(global::G.ImageReference value) => new Keyframe((global::G.ImageReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageReference?(Keyframe @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(global::G.ImageReference? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(
            global::G.KeyframeDiscriminatorType? type,
            global::G.GenerationReference? generation,
            global::G.ImageReference? image
            )
        {
            Type = type;

            Generation = generation;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Generation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generation?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGeneration && !IsImage || !IsGeneration && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerationReference?, TResult>? generation = null,
            global::System.Func<global::G.ImageReference?, TResult>? image = null,
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
            global::System.Action<global::G.GenerationReference?>? generation = null,
            global::System.Action<global::G.ImageReference?>? image = null,
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
                Generation,
                typeof(global::G.GenerationReference),
                Image,
                typeof(global::G.ImageReference),
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
        public bool Equals(Keyframe other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationReference?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageReference?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Keyframe obj1, Keyframe obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Keyframe>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Keyframe obj1, Keyframe obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Keyframe o && Equals(o);
        }
    }
}
