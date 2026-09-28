//HintName: G.Models.BetaInputContentBlock.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaInputContentBlock : global::System.IEquatable<BetaInputContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaInputContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestTextBlock? Text { get; init; }
#else
        public global::G.BetaRequestTextBlock? Text { get; }
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestTextBlock PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestImageBlock? Image { get; init; }
#else
        public global::G.BetaRequestImageBlock? Image { get; }
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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestImageBlock PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestToolUseBlock? ToolUse { get; init; }
#else
        public global::G.BetaRequestToolUseBlock? ToolUse { get; }
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
        public bool TryPickToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestToolUseBlock? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestToolUseBlock PickToolUse() => ToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestToolResultBlock? ToolResult { get; init; }
#else
        public global::G.BetaRequestToolResultBlock? ToolResult { get; }
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
        public bool TryPickToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestToolResultBlock? value)
        {
            value = ToolResult;
            return IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestToolResultBlock PickToolResult() => ToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestDocumentBlock? Document { get; init; }
#else
        public global::G.BetaRequestDocumentBlock? Document { get; }
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
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestDocumentBlock? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestDocumentBlock PickDocument() => Document is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestThinkingBlock? Thinking { get; init; }
#else
        public global::G.BetaRequestThinkingBlock? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestThinkingBlock? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestThinkingBlock PickThinking() => Thinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaRequestRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::G.BetaRequestRedactedThinkingBlock? RedactedThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedThinking))]
#endif
        public bool IsRedactedThinking => RedactedThinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRedactedThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaRequestRedactedThinkingBlock? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestRedactedThinkingBlock PickRedactedThinking() => RedactedThinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestTextBlock value) => new BetaInputContentBlock((global::G.BetaRequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestTextBlock?(BetaInputContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromText(global::G.BetaRequestTextBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestImageBlock value) => new BetaInputContentBlock((global::G.BetaRequestImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestImageBlock?(BetaInputContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromImage(global::G.BetaRequestImageBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestToolUseBlock value) => new BetaInputContentBlock((global::G.BetaRequestToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestToolUseBlock?(BetaInputContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolUse(global::G.BetaRequestToolUseBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestToolResultBlock value) => new BetaInputContentBlock((global::G.BetaRequestToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestToolResultBlock?(BetaInputContentBlock @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromToolResult(global::G.BetaRequestToolResultBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestDocumentBlock value) => new BetaInputContentBlock((global::G.BetaRequestDocumentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestDocumentBlock?(BetaInputContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromDocument(global::G.BetaRequestDocumentBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestThinkingBlock value) => new BetaInputContentBlock((global::G.BetaRequestThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestThinkingBlock?(BetaInputContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromThinking(global::G.BetaRequestThinkingBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::G.BetaRequestRedactedThinkingBlock value) => new BetaInputContentBlock((global::G.BetaRequestRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaRequestRedactedThinkingBlock?(BetaInputContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::G.BetaRequestRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaInputContentBlock FromRedactedThinking(global::G.BetaRequestRedactedThinkingBlock? value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(
            global::G.BetaInputContentBlockDiscriminatorType? type,
            global::G.BetaRequestTextBlock? text,
            global::G.BetaRequestImageBlock? image,
            global::G.BetaRequestToolUseBlock? toolUse,
            global::G.BetaRequestToolResultBlock? toolResult,
            global::G.BetaRequestDocumentBlock? document,
            global::G.BetaRequestThinkingBlock? thinking,
            global::G.BetaRequestRedactedThinkingBlock? redactedThinking
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolUse = toolUse;
            ToolResult = toolResult;
            Document = document;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedThinking as object ??
            Thinking as object ??
            Document as object ??
            ToolResult as object ??
            ToolUse as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            ToolUse?.ToString() ??
            ToolResult?.ToString() ??
            Document?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolUse && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && IsImage && !IsToolUse && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && IsToolUse && !IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && IsToolResult && !IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsToolResult && IsDocument && !IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsToolResult && !IsDocument && IsThinking && !IsRedactedThinking || !IsText && !IsImage && !IsToolUse && !IsToolResult && !IsDocument && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaRequestTextBlock, TResult>? text = null,
            global::System.Func<global::G.BetaRequestImageBlock, TResult>? image = null,
            global::System.Func<global::G.BetaRequestToolUseBlock, TResult>? toolUse = null,
            global::System.Func<global::G.BetaRequestToolResultBlock, TResult>? toolResult = null,
            global::System.Func<global::G.BetaRequestDocumentBlock, TResult>? document = null,
            global::System.Func<global::G.BetaRequestThinkingBlock, TResult>? thinking = null,
            global::System.Func<global::G.BetaRequestRedactedThinkingBlock, TResult>? redactedThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }
            else if (ToolUse is { } __value2 && toolUse != null)
            {
                return toolUse(__value2);
            }
            else if (ToolResult is { } __value3 && toolResult != null)
            {
                return toolResult(__value3);
            }
            else if (Document is { } __value4 && document != null)
            {
                return document(__value4);
            }
            else if (Thinking is { } __value5 && thinking != null)
            {
                return thinking(__value5);
            }
            else if (RedactedThinking is { } __value6 && redactedThinking != null)
            {
                return redactedThinking(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaRequestTextBlock>? text = null,

            global::System.Action<global::G.BetaRequestImageBlock>? image = null,

            global::System.Action<global::G.BetaRequestToolUseBlock>? toolUse = null,

            global::System.Action<global::G.BetaRequestToolResultBlock>? toolResult = null,

            global::System.Action<global::G.BetaRequestDocumentBlock>? document = null,

            global::System.Action<global::G.BetaRequestThinkingBlock>? thinking = null,

            global::System.Action<global::G.BetaRequestRedactedThinkingBlock>? redactedThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (ToolUse is { } __value2)
            {
                toolUse?.Invoke(__value2);
            }
            else if (ToolResult is { } __value3)
            {
                toolResult?.Invoke(__value3);
            }
            else if (Document is { } __value4)
            {
                document?.Invoke(__value4);
            }
            else if (Thinking is { } __value5)
            {
                thinking?.Invoke(__value5);
            }
            else if (RedactedThinking is { } __value6)
            {
                redactedThinking?.Invoke(__value6);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.BetaRequestTextBlock>? text = null,
            global::System.Action<global::G.BetaRequestImageBlock>? image = null,
            global::System.Action<global::G.BetaRequestToolUseBlock>? toolUse = null,
            global::System.Action<global::G.BetaRequestToolResultBlock>? toolResult = null,
            global::System.Action<global::G.BetaRequestDocumentBlock>? document = null,
            global::System.Action<global::G.BetaRequestThinkingBlock>? thinking = null,
            global::System.Action<global::G.BetaRequestRedactedThinkingBlock>? redactedThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (ToolUse is { } __value2)
            {
                toolUse?.Invoke(__value2);
            }
            else if (ToolResult is { } __value3)
            {
                toolResult?.Invoke(__value3);
            }
            else if (Document is { } __value4)
            {
                document?.Invoke(__value4);
            }
            else if (Thinking is { } __value5)
            {
                thinking?.Invoke(__value5);
            }
            else if (RedactedThinking is { } __value6)
            {
                redactedThinking?.Invoke(__value6);
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
                typeof(global::G.BetaRequestTextBlock),
                Image,
                typeof(global::G.BetaRequestImageBlock),
                ToolUse,
                typeof(global::G.BetaRequestToolUseBlock),
                ToolResult,
                typeof(global::G.BetaRequestToolResultBlock),
                Document,
                typeof(global::G.BetaRequestDocumentBlock),
                Thinking,
                typeof(global::G.BetaRequestThinkingBlock),
                RedactedThinking,
                typeof(global::G.BetaRequestRedactedThinkingBlock),
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
        public bool Equals(BetaInputContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestDocumentBlock?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaRequestRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaInputContentBlock obj1, BetaInputContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaInputContentBlock obj1, BetaInputContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputContentBlock o && Equals(o);
        }
    }
}
