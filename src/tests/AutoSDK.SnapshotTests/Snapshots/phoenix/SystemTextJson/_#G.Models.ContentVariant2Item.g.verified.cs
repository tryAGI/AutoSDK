//HintName: G.Models.ContentVariant2Item.g.cs
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
        public global::G.PromptMessageContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContentPart? Text { get; init; }
#else
        public global::G.TextContentPart? Text { get; }
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
        public global::G.ToolCallContentPart? ToolCall { get; init; }
#else
        public global::G.ToolCallContentPart? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolResultContentPart? ToolResult { get; init; }
#else
        public global::G.ToolResultContentPart? ToolResult { get; }
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
        public static implicit operator ContentVariant2Item(global::G.TextContentPart value) => new ContentVariant2Item((global::G.TextContentPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContentPart?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.TextContentPart? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::G.ToolCallContentPart value) => new ContentVariant2Item((global::G.ToolCallContentPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallContentPart?(ContentVariant2Item @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.ToolCallContentPart? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::G.ToolResultContentPart value) => new ContentVariant2Item((global::G.ToolResultContentPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolResultContentPart?(ContentVariant2Item @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.ToolResultContentPart? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::G.PromptMessageContentVariant2ItemDiscriminatorType? type,
            global::G.TextContentPart? text,
            global::G.ToolCallContentPart? toolCall,
            global::G.ToolResultContentPart? toolResult
            )
        {
            Type = type;

            Text = text;
            ToolCall = toolCall;
            ToolResult = toolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolResult as object ??
            ToolCall as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolCall?.ToString() ??
            ToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolCall && !IsToolResult || !IsText && IsToolCall && !IsToolResult || !IsText && !IsToolCall && IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContentPart?, TResult>? text = null,
            global::System.Func<global::G.ToolCallContentPart?, TResult>? toolCall = null,
            global::System.Func<global::G.ToolResultContentPart?, TResult>? toolResult = null,
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
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextContentPart?>? text = null,
            global::System.Action<global::G.ToolCallContentPart?>? toolCall = null,
            global::System.Action<global::G.ToolResultContentPart?>? toolResult = null,
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
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
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
                typeof(global::G.TextContentPart),
                ToolCall,
                typeof(global::G.ToolCallContentPart),
                ToolResult,
                typeof(global::G.ToolResultContentPart),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContentPart?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallContentPart?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolResultContentPart?>.Default.Equals(ToolResult, other.ToolResult) 
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
