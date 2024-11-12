//HintName: G.Models.EmbeddingInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingInput : global::System.IEquatable<EmbeddingInput>
    {
        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextEmbeddingInput? Text { get; init; }
#else
        public global::G.TextEmbeddingInput? Text { get; }
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
        public static implicit operator EmbeddingInput(global::G.TextEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextEmbeddingInput?(EmbeddingInput @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.TextEmbeddingInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageEmbeddingInput? Image { get; init; }
#else
        public global::G.ImageEmbeddingInput? Image { get; }
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
        public static implicit operator EmbeddingInput(global::G.ImageEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageEmbeddingInput?(EmbeddingInput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.ImageEmbeddingInput? value)
        {
            Image = value;
        }

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MixedEmbeddingInput? Mixed { get; init; }
#else
        public global::G.MixedEmbeddingInput? Mixed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mixed))]
#endif
        public bool IsMixed => Mixed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.MixedEmbeddingInput value) => new EmbeddingInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MixedEmbeddingInput?(EmbeddingInput @this) => @this.Mixed;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.MixedEmbeddingInput? value)
        {
            Mixed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(
            global::G.TextEmbeddingInput? text,
            global::G.ImageEmbeddingInput? image,
            global::G.MixedEmbeddingInput? mixed
            )
        {
            Text = text;
            Image = image;
            Mixed = mixed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mixed as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsImage || IsMixed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextEmbeddingInput?, TResult>? text = null,
            global::System.Func<global::G.ImageEmbeddingInput?, TResult>? image = null,
            global::System.Func<global::G.MixedEmbeddingInput?, TResult>? mixed = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsMixed && mixed != null)
            {
                return mixed(Mixed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextEmbeddingInput?>? text = null,
            global::System.Action<global::G.ImageEmbeddingInput?>? image = null,
            global::System.Action<global::G.MixedEmbeddingInput?>? mixed = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsMixed)
            {
                mixed?.Invoke(Mixed!);
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
                typeof(global::G.TextEmbeddingInput),
                Image,
                typeof(global::G.ImageEmbeddingInput),
                Mixed,
                typeof(global::G.MixedEmbeddingInput),
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
        public bool Equals(EmbeddingInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextEmbeddingInput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageEmbeddingInput?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MixedEmbeddingInput?>.Default.Equals(Mixed, other.Mixed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingInput obj1, EmbeddingInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingInput obj1, EmbeddingInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingInput o && Equals(o);
        }
    }
}
