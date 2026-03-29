//HintName: G.Models.CompositeContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A union type that can contain either text or image content fragments. This enables chat messages to include mixed content types, allowing users to send both text and images in a single message. Note: Image fragments are only supported with the Palmyra X5 model.
    /// </summary>
    public readonly partial struct CompositeContent : global::System.IEquatable<CompositeContent>
    {
        /// <summary>
        /// Represents a text content fragment within a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextFragment? Text { get; init; }
#else
        public global::G.TextFragment? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// Represents an image content fragment within a chat message. Note: This content type is only supported with the Palmyra X5 model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageFragment? Image { get; init; }
#else
        public global::G.ImageFragment? Image { get; }
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
        public static implicit operator CompositeContent(global::G.TextFragment value) => new CompositeContent((global::G.TextFragment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextFragment?(CompositeContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public CompositeContent(global::G.TextFragment? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompositeContent(global::G.ImageFragment value) => new CompositeContent((global::G.ImageFragment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageFragment?(CompositeContent @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public CompositeContent(global::G.ImageFragment? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompositeContent(
            global::G.TextFragment? text,
            global::G.ImageFragment? image
            )
        {
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
            global::System.Func<global::G.TextFragment?, TResult>? text = null,
            global::System.Func<global::G.ImageFragment?, TResult>? image = null,
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
            global::System.Action<global::G.TextFragment?>? text = null,
            global::System.Action<global::G.ImageFragment?>? image = null,
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
                typeof(global::G.TextFragment),
                Image,
                typeof(global::G.ImageFragment),
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
        public bool Equals(CompositeContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextFragment?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageFragment?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompositeContent obj1, CompositeContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompositeContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompositeContent obj1, CompositeContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompositeContent o && Equals(o);
        }
    }
}
