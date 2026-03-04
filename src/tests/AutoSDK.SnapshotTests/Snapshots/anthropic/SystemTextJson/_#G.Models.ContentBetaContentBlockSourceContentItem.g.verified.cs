//HintName: G.Models.ContentBetaContentBlockSourceContentItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentBetaContentBlockSourceContentItem : global::System.IEquatable<ContentBetaContentBlockSourceContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? Type { get; }

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
        public static implicit operator ContentBetaContentBlockSourceContentItem(global::G.BetaRequestTextBlock value) => new ContentBetaContentBlockSourceContentItem((global::G.BetaRequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestTextBlock?(ContentBetaContentBlockSourceContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBetaContentBlockSourceContentItem(global::G.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBetaContentBlockSourceContentItem(global::G.BetaRequestImageBlock value) => new ContentBetaContentBlockSourceContentItem((global::G.BetaRequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestImageBlock?(ContentBetaContentBlockSourceContentItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentBetaContentBlockSourceContentItem(global::G.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentBetaContentBlockSourceContentItem(
            global::G.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? type,
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
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() 
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
        public bool Equals(ContentBetaContentBlockSourceContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentBetaContentBlockSourceContentItem obj1, ContentBetaContentBlockSourceContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBetaContentBlockSourceContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentBetaContentBlockSourceContentItem obj1, ContentBetaContentBlockSourceContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBetaContentBlockSourceContentItem o && Equals(o);
        }
    }
}
