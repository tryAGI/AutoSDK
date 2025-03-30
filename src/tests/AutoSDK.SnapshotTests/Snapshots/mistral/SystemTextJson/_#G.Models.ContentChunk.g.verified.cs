//HintName: G.Models.ContentChunk.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentChunk : global::System.IEquatable<ContentChunk>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContentChunkDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextChunk? Text { get; init; }
#else
        public global::G.TextChunk? Text { get; }
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
        public static implicit operator ContentChunk(global::G.TextChunk value) => new ContentChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextChunk?(ContentChunk @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::G.TextChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// {"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageURLChunk? ImageUrl { get; init; }
#else
        public global::G.ImageURLChunk? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::G.ImageURLChunk value) => new ContentChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageURLChunk?(ContentChunk @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::G.ImageURLChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(
            global::G.ContentChunkDiscriminatorType? type,
            global::G.TextChunk? text,
            global::G.ImageURLChunk? imageUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl || !IsText && IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextChunk?, TResult>? text = null,
            global::System.Func<global::G.ImageURLChunk?, TResult>? imageUrl = null,
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
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextChunk?>? text = null,
            global::System.Action<global::G.ImageURLChunk?>? imageUrl = null,
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
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
                typeof(global::G.TextChunk),
                ImageUrl,
                typeof(global::G.ImageURLChunk),
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
        public bool Equals(ContentChunk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageURLChunk?>.Default.Equals(ImageUrl, other.ImageUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentChunk obj1, ContentChunk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentChunk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentChunk obj1, ContentChunk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentChunk o && Equals(o);
        }
    }
}
