//HintName: G.Models.ToolContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A content block which contains information about the content of a tool result
    /// </summary>
    public readonly partial struct ToolContent : global::System.IEquatable<ToolContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Text content of the message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContent? Text { get; init; }
#else
        public global::G.TextContent? Text { get; }
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
        public static implicit operator ToolContent(global::G.TextContent value) => new ToolContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContent?(ToolContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ToolContent(global::G.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// Document content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DocumentContent? Document { get; init; }
#else
        public global::G.DocumentContent? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolContent(global::G.DocumentContent value) => new ToolContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DocumentContent?(ToolContent @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public ToolContent(global::G.DocumentContent? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolContent(
            global::G.ToolContentDiscriminatorType? type,
            global::G.TextContent? text,
            global::G.DocumentContent? document
            )
        {
            Type = type;

            Text = text;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Document?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsDocument || !IsText && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContent?, TResult>? text = null,
            global::System.Func<global::G.DocumentContent?, TResult>? document = null,
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
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextContent?>? text = null,
            global::System.Action<global::G.DocumentContent?>? document = null,
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
            else if (IsDocument)
            {
                document?.Invoke(Document!);
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
                typeof(global::G.TextContent),
                Document,
                typeof(global::G.DocumentContent),
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
        public bool Equals(ToolContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DocumentContent?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolContent obj1, ToolContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolContent obj1, ToolContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolContent o && Equals(o);
        }
    }
}
