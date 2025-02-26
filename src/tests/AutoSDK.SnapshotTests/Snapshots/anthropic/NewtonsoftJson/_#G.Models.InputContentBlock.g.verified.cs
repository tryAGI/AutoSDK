//HintName: G.Models.InputContentBlock.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputContentBlock : global::System.IEquatable<InputContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputContentBlockDiscriminatorType? Type { get; }

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
        public static implicit operator InputContentBlock(global::G.RequestTextBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestTextBlock?(InputContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::G.RequestTextBlock? value)
        {
            Text = value;
        }

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
        public static implicit operator InputContentBlock(global::G.RequestImageBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestImageBlock?(InputContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::G.RequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestToolUseBlock? ToolUse { get; init; }
#else
        public global::G.RequestToolUseBlock? ToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::G.RequestToolUseBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestToolUseBlock?(InputContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::G.RequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestToolResultBlock? ToolResult { get; init; }
#else
        public global::G.RequestToolResultBlock? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContentBlock(global::G.RequestToolResultBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestToolResultBlock?(InputContentBlock @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::G.RequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestDocumentBlock? Document { get; init; }
#else
        public global::G.RequestDocumentBlock? Document { get; }
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
        public static implicit operator InputContentBlock(global::G.RequestDocumentBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestDocumentBlock?(InputContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::G.RequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(
            global::G.InputContentBlockDiscriminatorType? type,
            global::G.RequestTextBlock? text,
            global::G.RequestImageBlock? image,
            global::G.RequestToolUseBlock? toolUse,
            global::G.RequestToolResultBlock? toolResult,
            global::G.RequestDocumentBlock? document
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolUse = toolUse;
            ToolResult = toolResult;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            ToolResult as object ??
            ToolUse as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolUse && !IsToolResult && !IsDocument || !IsText && IsImage && !IsToolUse && !IsToolResult && !IsDocument || !IsText && !IsImage && IsToolUse && !IsToolResult && !IsDocument || !IsText && !IsImage && !IsToolUse && IsToolResult && !IsDocument || !IsText && !IsImage && !IsToolUse && !IsToolResult && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RequestTextBlock?, TResult>? text = null,
            global::System.Func<global::G.RequestImageBlock?, TResult>? image = null,
            global::System.Func<global::G.RequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::G.RequestToolResultBlock?, TResult>? toolResult = null,
            global::System.Func<global::G.RequestDocumentBlock?, TResult>? document = null,
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
            else if (IsToolUse && toolUse != null)
            {
                return toolUse(ToolUse!);
            }
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
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
            global::System.Action<global::G.RequestTextBlock?>? text = null,
            global::System.Action<global::G.RequestImageBlock?>? image = null,
            global::System.Action<global::G.RequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::G.RequestToolResultBlock?>? toolResult = null,
            global::System.Action<global::G.RequestDocumentBlock?>? document = null,
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
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
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
                typeof(global::G.RequestTextBlock),
                Image,
                typeof(global::G.RequestImageBlock),
                ToolUse,
                typeof(global::G.RequestToolUseBlock),
                ToolResult,
                typeof(global::G.RequestToolResultBlock),
                Document,
                typeof(global::G.RequestDocumentBlock),
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
        public bool Equals(InputContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestDocumentBlock?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputContentBlock obj1, InputContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputContentBlock obj1, InputContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContentBlock o && Equals(o);
        }
    }
}
