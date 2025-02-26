//HintName: G.Models.Source.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestDocumentBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaBase64PDFSource? Base64 { get; init; }
#else
        public global::G.BetaBase64PDFSource? Base64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.BetaBase64PDFSource value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaBase64PDFSource?(Source @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.BetaBase64PDFSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaPlainTextSource? Text { get; init; }
#else
        public global::G.BetaPlainTextSource? Text { get; }
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
        public static implicit operator Source(global::G.BetaPlainTextSource value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaPlainTextSource?(Source @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.BetaPlainTextSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaContentBlockSource? Content { get; init; }
#else
        public global::G.BetaContentBlockSource? Content { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Content))]
#endif
        public bool IsContent => Content != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.BetaContentBlockSource value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaContentBlockSource?(Source @this) => @this.Content;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.BetaContentBlockSource? value)
        {
            Content = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::G.BetaRequestDocumentBlockSourceDiscriminatorType? type,
            global::G.BetaBase64PDFSource? base64,
            global::G.BetaPlainTextSource? text,
            global::G.BetaContentBlockSource? content
            )
        {
            Type = type;

            Base64 = base64;
            Text = text;
            Content = content;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Content as object ??
            Text as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsText && !IsContent || !IsBase64 && IsText && !IsContent || !IsBase64 && !IsText && IsContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaBase64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::G.BetaPlainTextSource?, TResult>? text = null,
            global::System.Func<global::G.BetaContentBlockSource?, TResult>? content = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64 && base64 != null)
            {
                return base64(Base64!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsContent && content != null)
            {
                return content(Content!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaBase64PDFSource?>? base64 = null,
            global::System.Action<global::G.BetaPlainTextSource?>? text = null,
            global::System.Action<global::G.BetaContentBlockSource?>? content = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsContent)
            {
                content?.Invoke(Content!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::G.BetaBase64PDFSource),
                Text,
                typeof(global::G.BetaPlainTextSource),
                Content,
                typeof(global::G.BetaContentBlockSource),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaBase64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaPlainTextSource?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaContentBlockSource?>.Default.Equals(Content, other.Content) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
