//HintName: G.Models.ContentContentBlockSourceContentItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentContentBlockSourceContentItem : global::System.IEquatable<ContentContentBlockSourceContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestTextBlock? Text { get; init; }
#else
        public global::G.RequestTextBlock? Text { get; }
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
        public global::G.RequestImageBlock? Image { get; init; }
#else
        public global::G.RequestImageBlock? Image { get; }
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
        public static implicit operator ContentContentBlockSourceContentItem(global::G.RequestTextBlock value) => new ContentContentBlockSourceContentItem((global::G.RequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestTextBlock?(ContentContentBlockSourceContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentContentBlockSourceContentItem(global::G.RequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentContentBlockSourceContentItem(global::G.RequestImageBlock value) => new ContentContentBlockSourceContentItem((global::G.RequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestImageBlock?(ContentContentBlockSourceContentItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentContentBlockSourceContentItem(global::G.RequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentContentBlockSourceContentItem(
            global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType? type,
            global::G.RequestTextBlock? text,
            global::G.RequestImageBlock? image
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
            global::System.Func<global::G.RequestTextBlock?, TResult>? text = null,
            global::System.Func<global::G.RequestImageBlock?, TResult>? image = null,
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
            global::System.Action<global::G.RequestTextBlock?>? text = null,
            global::System.Action<global::G.RequestImageBlock?>? image = null,
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
                typeof(global::G.RequestTextBlock),
                Image,
                typeof(global::G.RequestImageBlock),
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
        public bool Equals(ContentContentBlockSourceContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestImageBlock?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentContentBlockSourceContentItem obj1, ContentContentBlockSourceContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentContentBlockSourceContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentContentBlockSourceContentItem obj1, ContentContentBlockSourceContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentContentBlockSourceContentItem o && Equals(o);
        }
    }
}
