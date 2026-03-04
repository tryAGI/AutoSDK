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
        /// The input to the API for text embedding. OpenAI compatible<br/>
        /// Example: {"model":"jina-embeddings-v2-base-en","input":["Hello, world!"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextEmbeddingInput? TextEmbeddingInput { get; init; }
#else
        public global::G.TextEmbeddingInput? TextEmbeddingInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEmbeddingInput))]
#endif
        public bool IsTextEmbeddingInput => TextEmbeddingInput != null;

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible<br/>
        /// Example: {"model":"clip","input":["bytes or URL"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageEmbeddingInput? ImageEmbeddingInput { get; init; }
#else
        public global::G.ImageEmbeddingInput? ImageEmbeddingInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageEmbeddingInput))]
#endif
        public bool IsImageEmbeddingInput => ImageEmbeddingInput != null;

        /// <summary>
        /// The input to the API for text embedding. OpenAI compatible<br/>
        /// Example: {"model":"clip","input":["bytes or URL"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MixedEmbeddingInput? MixedEmbeddingInput { get; init; }
#else
        public global::G.MixedEmbeddingInput? MixedEmbeddingInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MixedEmbeddingInput))]
#endif
        public bool IsMixedEmbeddingInput => MixedEmbeddingInput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.TextEmbeddingInput value) => new EmbeddingInput((global::G.TextEmbeddingInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextEmbeddingInput?(EmbeddingInput @this) => @this.TextEmbeddingInput;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.TextEmbeddingInput? value)
        {
            TextEmbeddingInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.ImageEmbeddingInput value) => new EmbeddingInput((global::G.ImageEmbeddingInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageEmbeddingInput?(EmbeddingInput @this) => @this.ImageEmbeddingInput;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.ImageEmbeddingInput? value)
        {
            ImageEmbeddingInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingInput(global::G.MixedEmbeddingInput value) => new EmbeddingInput((global::G.MixedEmbeddingInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MixedEmbeddingInput?(EmbeddingInput @this) => @this.MixedEmbeddingInput;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(global::G.MixedEmbeddingInput? value)
        {
            MixedEmbeddingInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingInput(
            global::G.TextEmbeddingInput? textEmbeddingInput,
            global::G.ImageEmbeddingInput? imageEmbeddingInput,
            global::G.MixedEmbeddingInput? mixedEmbeddingInput
            )
        {
            TextEmbeddingInput = textEmbeddingInput;
            ImageEmbeddingInput = imageEmbeddingInput;
            MixedEmbeddingInput = mixedEmbeddingInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MixedEmbeddingInput as object ??
            ImageEmbeddingInput as object ??
            TextEmbeddingInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextEmbeddingInput?.ToString() ??
            ImageEmbeddingInput?.ToString() ??
            MixedEmbeddingInput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextEmbeddingInput || IsImageEmbeddingInput || IsMixedEmbeddingInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextEmbeddingInput?, TResult>? textEmbeddingInput = null,
            global::System.Func<global::G.ImageEmbeddingInput?, TResult>? imageEmbeddingInput = null,
            global::System.Func<global::G.MixedEmbeddingInput?, TResult>? mixedEmbeddingInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextEmbeddingInput && textEmbeddingInput != null)
            {
                return textEmbeddingInput(TextEmbeddingInput!);
            }
            else if (IsImageEmbeddingInput && imageEmbeddingInput != null)
            {
                return imageEmbeddingInput(ImageEmbeddingInput!);
            }
            else if (IsMixedEmbeddingInput && mixedEmbeddingInput != null)
            {
                return mixedEmbeddingInput(MixedEmbeddingInput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextEmbeddingInput?>? textEmbeddingInput = null,
            global::System.Action<global::G.ImageEmbeddingInput?>? imageEmbeddingInput = null,
            global::System.Action<global::G.MixedEmbeddingInput?>? mixedEmbeddingInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextEmbeddingInput)
            {
                textEmbeddingInput?.Invoke(TextEmbeddingInput!);
            }
            else if (IsImageEmbeddingInput)
            {
                imageEmbeddingInput?.Invoke(ImageEmbeddingInput!);
            }
            else if (IsMixedEmbeddingInput)
            {
                mixedEmbeddingInput?.Invoke(MixedEmbeddingInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextEmbeddingInput,
                typeof(global::G.TextEmbeddingInput),
                ImageEmbeddingInput,
                typeof(global::G.ImageEmbeddingInput),
                MixedEmbeddingInput,
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
                global::System.Collections.Generic.EqualityComparer<global::G.TextEmbeddingInput?>.Default.Equals(TextEmbeddingInput, other.TextEmbeddingInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageEmbeddingInput?>.Default.Equals(ImageEmbeddingInput, other.ImageEmbeddingInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MixedEmbeddingInput?>.Default.Equals(MixedEmbeddingInput, other.MixedEmbeddingInput) 
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
