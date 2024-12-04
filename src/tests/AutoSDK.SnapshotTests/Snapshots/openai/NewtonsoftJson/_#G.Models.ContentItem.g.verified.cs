//HintName: G.Models.ContentItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentImageFileObject? ImageFile { get; init; }
#else
        public global::G.MessageDeltaContentImageFileObject? ImageFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageFile))]
#endif
        public bool IsImageFile => ImageFile != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::G.MessageDeltaContentImageFileObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentImageFileObject?(ContentItem @this) => @this.ImageFile;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageDeltaContentImageFileObject? value)
        {
            ImageFile = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentTextObject? Text { get; init; }
#else
        public global::G.MessageDeltaContentTextObject? Text { get; }
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
        public static implicit operator ContentItem(global::G.MessageDeltaContentTextObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentTextObject?(ContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageDeltaContentTextObject? value)
        {
            Text = value;
        }

        /// <summary>
        /// The refusal content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentRefusalObject? Refusal { get; init; }
#else
        public global::G.MessageDeltaContentRefusalObject? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::G.MessageDeltaContentRefusalObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentRefusalObject?(ContentItem @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageDeltaContentRefusalObject? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentImageUrlObject? ImageUrl { get; init; }
#else
        public global::G.MessageDeltaContentImageUrlObject? ImageUrl { get; }
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
        public static implicit operator ContentItem(global::G.MessageDeltaContentImageUrlObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentImageUrlObject?(ContentItem @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageDeltaContentImageUrlObject? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(
            global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType? type,
            global::G.MessageDeltaContentImageFileObject? imageFile,
            global::G.MessageDeltaContentTextObject? text,
            global::G.MessageDeltaContentRefusalObject? refusal,
            global::G.MessageDeltaContentImageUrlObject? imageUrl
            )
        {
            Type = type;

            ImageFile = imageFile;
            Text = text;
            Refusal = refusal;
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Refusal as object ??
            Text as object ??
            ImageFile as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageFile && !IsText && !IsRefusal && !IsImageUrl || !IsImageFile && IsText && !IsRefusal && !IsImageUrl || !IsImageFile && !IsText && IsRefusal && !IsImageUrl || !IsImageFile && !IsText && !IsRefusal && IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageDeltaContentImageFileObject?, TResult>? imageFile = null,
            global::System.Func<global::G.MessageDeltaContentTextObject?, TResult>? text = null,
            global::System.Func<global::G.MessageDeltaContentRefusalObject?, TResult>? refusal = null,
            global::System.Func<global::G.MessageDeltaContentImageUrlObject?, TResult>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFile && imageFile != null)
            {
                return imageFile(ImageFile!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
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
            global::System.Action<global::G.MessageDeltaContentImageFileObject?>? imageFile = null,
            global::System.Action<global::G.MessageDeltaContentTextObject?>? text = null,
            global::System.Action<global::G.MessageDeltaContentRefusalObject?>? refusal = null,
            global::System.Action<global::G.MessageDeltaContentImageUrlObject?>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFile)
            {
                imageFile?.Invoke(ImageFile!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
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
                ImageFile,
                typeof(global::G.MessageDeltaContentImageFileObject),
                Text,
                typeof(global::G.MessageDeltaContentTextObject),
                Refusal,
                typeof(global::G.MessageDeltaContentRefusalObject),
                ImageUrl,
                typeof(global::G.MessageDeltaContentImageUrlObject),
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
        public bool Equals(ContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentImageFileObject?>.Default.Equals(ImageFile, other.ImageFile) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentTextObject?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentRefusalObject?>.Default.Equals(Refusal, other.Refusal) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentImageUrlObject?>.Default.Equals(ImageUrl, other.ImageUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
        }
    }
}
