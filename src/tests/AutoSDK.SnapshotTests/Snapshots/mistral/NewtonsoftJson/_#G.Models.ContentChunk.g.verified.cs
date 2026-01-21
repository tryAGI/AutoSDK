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
#if NET6_0_OR_GREATER
        public global::G.DocumentURLChunk? DocumentUrl { get; init; }
#else
        public global::G.DocumentURLChunk? DocumentUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentUrl))]
#endif
        public bool IsDocumentUrl => DocumentUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReferenceChunk? Reference { get; init; }
#else
        public global::G.ReferenceChunk? Reference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reference))]
#endif
        public bool IsReference => Reference != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::G.TextChunk value) => new ContentChunk((global::G.TextChunk?)value);

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
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::G.ImageURLChunk value) => new ContentChunk((global::G.ImageURLChunk?)value);

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
        public static implicit operator ContentChunk(global::G.DocumentURLChunk value) => new ContentChunk((global::G.DocumentURLChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DocumentURLChunk?(ContentChunk @this) => @this.DocumentUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::G.DocumentURLChunk? value)
        {
            DocumentUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::G.ReferenceChunk value) => new ContentChunk((global::G.ReferenceChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReferenceChunk?(ContentChunk @this) => @this.Reference;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::G.ReferenceChunk? value)
        {
            Reference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(
            global::G.ContentChunkDiscriminatorType? type,
            global::G.TextChunk? text,
            global::G.ImageURLChunk? imageUrl,
            global::G.DocumentURLChunk? documentUrl,
            global::G.ReferenceChunk? reference
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            DocumentUrl = documentUrl;
            Reference = reference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Reference as object ??
            DocumentUrl as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            DocumentUrl?.ToString() ??
            Reference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsDocumentUrl && !IsReference || !IsText && IsImageUrl && !IsDocumentUrl && !IsReference || !IsText && !IsImageUrl && IsDocumentUrl && !IsReference || !IsText && !IsImageUrl && !IsDocumentUrl && IsReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextChunk?, TResult>? text = null,
            global::System.Func<global::G.ImageURLChunk?, TResult>? imageUrl = null,
            global::System.Func<global::G.DocumentURLChunk?, TResult>? documentUrl = null,
            global::System.Func<global::G.ReferenceChunk?, TResult>? reference = null,
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
            else if (IsDocumentUrl && documentUrl != null)
            {
                return documentUrl(DocumentUrl!);
            }
            else if (IsReference && reference != null)
            {
                return reference(Reference!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextChunk?>? text = null,
            global::System.Action<global::G.ImageURLChunk?>? imageUrl = null,
            global::System.Action<global::G.DocumentURLChunk?>? documentUrl = null,
            global::System.Action<global::G.ReferenceChunk?>? reference = null,
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
            else if (IsDocumentUrl)
            {
                documentUrl?.Invoke(DocumentUrl!);
            }
            else if (IsReference)
            {
                reference?.Invoke(Reference!);
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
                DocumentUrl,
                typeof(global::G.DocumentURLChunk),
                Reference,
                typeof(global::G.ReferenceChunk),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ImageURLChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DocumentURLChunk?>.Default.Equals(DocumentUrl, other.DocumentUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReferenceChunk?>.Default.Equals(Reference, other.Reference) 
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
