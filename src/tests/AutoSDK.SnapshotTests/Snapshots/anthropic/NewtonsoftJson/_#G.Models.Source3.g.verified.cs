//HintName: G.Models.Source3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source3 : global::System.IEquatable<Source3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RequestDocumentBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Base64PDFSource? Base64 { get; init; }
#else
        public global::G.Base64PDFSource? Base64 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.PlainTextSource? Text { get; init; }
#else
        public global::G.PlainTextSource? Text { get; }
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
        public global::G.ContentBlockSource? Content { get; init; }
#else
        public global::G.ContentBlockSource? Content { get; }
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
#if NET6_0_OR_GREATER
        public global::G.URLPDFSource? Url { get; init; }
#else
        public global::G.URLPDFSource? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source3(global::G.Base64PDFSource value) => new Source3((global::G.Base64PDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Base64PDFSource?(Source3 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::G.Base64PDFSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source3(global::G.PlainTextSource value) => new Source3((global::G.PlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PlainTextSource?(Source3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::G.PlainTextSource? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source3(global::G.ContentBlockSource value) => new Source3((global::G.ContentBlockSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockSource?(Source3 @this) => @this.Content;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::G.ContentBlockSource? value)
        {
            Content = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source3(global::G.URLPDFSource value) => new Source3((global::G.URLPDFSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.URLPDFSource?(Source3 @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source3(global::G.URLPDFSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source3(
            global::G.RequestDocumentBlockSourceDiscriminatorType? type,
            global::G.Base64PDFSource? base64,
            global::G.PlainTextSource? text,
            global::G.ContentBlockSource? content,
            global::G.URLPDFSource? url
            )
        {
            Type = type;

            Base64 = base64;
            Text = text;
            Content = content;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            Content as object ??
            Text as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Text?.ToString() ??
            Content?.ToString() ??
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsText && !IsContent && !IsUrl || !IsBase64 && IsText && !IsContent && !IsUrl || !IsBase64 && !IsText && IsContent && !IsUrl || !IsBase64 && !IsText && !IsContent && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Base64PDFSource?, TResult>? base64 = null,
            global::System.Func<global::G.PlainTextSource?, TResult>? text = null,
            global::System.Func<global::G.ContentBlockSource?, TResult>? content = null,
            global::System.Func<global::G.URLPDFSource?, TResult>? url = null,
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
            else if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Base64PDFSource?>? base64 = null,
            global::System.Action<global::G.PlainTextSource?>? text = null,
            global::System.Action<global::G.ContentBlockSource?>? content = null,
            global::System.Action<global::G.URLPDFSource?>? url = null,
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
            else if (IsUrl)
            {
                url?.Invoke(Url!);
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
                typeof(global::G.Base64PDFSource),
                Text,
                typeof(global::G.PlainTextSource),
                Content,
                typeof(global::G.ContentBlockSource),
                Url,
                typeof(global::G.URLPDFSource),
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
        public bool Equals(Source3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Base64PDFSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PlainTextSource?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockSource?>.Default.Equals(Content, other.Content) &&
                global::System.Collections.Generic.EqualityComparer<global::G.URLPDFSource?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source3 obj1, Source3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source3 obj1, Source3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source3 o && Equals(o);
        }
    }
}
