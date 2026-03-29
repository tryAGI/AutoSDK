//HintName: G.Models.MultiModalQueryVariant2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to create embeddings for.
    /// </summary>
    public readonly partial struct MultiModalQueryVariant2 : global::System.IEquatable<MultiModalQueryVariant2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MultiModalQueryVariant2DiscriminatorType? Type { get; }

        /// <summary>
        /// Model for image input validation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageUrlInput2? ImageUrl { get; init; }
#else
        public global::G.ImageUrlInput2? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// Model for text input validation.<br/>
        /// Attributes:<br/>
        ///     type: Input type identifier, always "text"<br/>
        ///     text: The actual text content, with length and whitespace constraints
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextInput? Text { get; init; }
#else
        public global::G.TextInput? Text { get; }
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
        public static implicit operator MultiModalQueryVariant2(global::G.ImageUrlInput2 value) => new MultiModalQueryVariant2((global::G.ImageUrlInput2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageUrlInput2?(MultiModalQueryVariant2 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public MultiModalQueryVariant2(global::G.ImageUrlInput2? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultiModalQueryVariant2(global::G.TextInput value) => new MultiModalQueryVariant2((global::G.TextInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextInput?(MultiModalQueryVariant2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public MultiModalQueryVariant2(global::G.TextInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiModalQueryVariant2(
            global::G.MultiModalQueryVariant2DiscriminatorType? type,
            global::G.ImageUrlInput2? imageUrl,
            global::G.TextInput? text
            )
        {
            Type = type;

            ImageUrl = imageUrl;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            ImageUrl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageUrl?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageUrl && !IsText || !IsImageUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ImageUrlInput2?, TResult>? imageUrl = null,
            global::System.Func<global::G.TextInput?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ImageUrlInput2?>? imageUrl = null,
            global::System.Action<global::G.TextInput?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageUrl,
                typeof(global::G.ImageUrlInput2),
                Text,
                typeof(global::G.TextInput),
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
        public bool Equals(MultiModalQueryVariant2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ImageUrlInput2?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextInput?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MultiModalQueryVariant2 obj1, MultiModalQueryVariant2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MultiModalQueryVariant2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MultiModalQueryVariant2 obj1, MultiModalQueryVariant2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MultiModalQueryVariant2 o && Equals(o);
        }
    }
}
