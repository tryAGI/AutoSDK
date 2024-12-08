//HintName: G.Models.ContentVariant2Item.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestTextBlock? Text { get; init; }
#else
        public global::G.BetaRequestTextBlock? Text { get; }
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
        public static implicit operator ContentVariant2Item(global::G.BetaRequestTextBlock value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestTextBlock?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestImageBlock? Image { get; init; }
#else
        public global::G.BetaRequestImageBlock? Image { get; }
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
        public static implicit operator ContentVariant2Item(global::G.BetaRequestImageBlock value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestImageBlock?(ContentVariant2Item @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::G.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? type,
            global::G.BetaRequestTextBlock? text,
            global::G.BetaRequestImageBlock? image
            )
        {
            Type = type;

            Text = text;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage || !IsText && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::G.BetaRequestImageBlock?, TResult>? image = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaRequestTextBlock?>? text = null,
            global::System.Action<global::G.BetaRequestImageBlock?>? image = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.BetaRequestTextBlock),
                Image,
                typeof(global::G.BetaRequestImageBlock),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
