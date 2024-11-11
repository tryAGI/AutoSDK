//HintName: G.Models.ContentVariant2Item.g.cs
using System.Linq;
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
        public global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentImageFileObject? ImageFile { get; init; }
#else
        public global::G.MessageContentImageFileObject? ImageFile { get; }
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
        public static implicit operator ContentVariant2Item(global::G.MessageContentImageFileObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentImageFileObject?(ContentVariant2Item @this) => @this.ImageFile;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.MessageContentImageFileObject? value)
        {
            ImageFile = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentImageUrlObject? ImageUrl { get; init; }
#else
        public global::G.MessageContentImageUrlObject? ImageUrl { get; }
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
        public static implicit operator ContentVariant2Item(global::G.MessageContentImageUrlObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentImageUrlObject?(ContentVariant2Item @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.MessageContentImageUrlObject? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageRequestContentTextObject? Text { get; init; }
#else
        public global::G.MessageRequestContentTextObject? Text { get; }
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
        public static implicit operator ContentVariant2Item(global::G.MessageRequestContentTextObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageRequestContentTextObject?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.MessageRequestContentTextObject? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType? type,
            global::G.MessageContentImageFileObject? imageFile,
            global::G.MessageContentImageUrlObject? imageUrl,
            global::G.MessageRequestContentTextObject? text
            )
        {
            Type = type;

            ImageFile = imageFile;
            ImageUrl = imageUrl;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            ImageUrl as object ??
            ImageFile as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageFile && !IsImageUrl && !IsText || !IsImageFile && IsImageUrl && !IsText || !IsImageFile && !IsImageUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageContentImageFileObject?, TResult>? imageFile = null,
            global::System.Func<global::G.MessageContentImageUrlObject?, TResult>? imageUrl = null,
            global::System.Func<global::G.MessageRequestContentTextObject?, TResult>? text = null,
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
            else if (IsImageUrl && imageUrl != null)
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
            global::System.Action<global::G.MessageContentImageFileObject?>? imageFile = null,
            global::System.Action<global::G.MessageContentImageUrlObject?>? imageUrl = null,
            global::System.Action<global::G.MessageRequestContentTextObject?>? text = null,
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
            else if (IsImageUrl)
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
                ImageFile,
                typeof(global::G.MessageContentImageFileObject),
                ImageUrl,
                typeof(global::G.MessageContentImageUrlObject),
                Text,
                typeof(global::G.MessageRequestContentTextObject),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentImageFileObject?>.Default.Equals(ImageFile, other.ImageFile) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentImageUrlObject?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageRequestContentTextObject?>.Default.Equals(Text, other.Text) 
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
