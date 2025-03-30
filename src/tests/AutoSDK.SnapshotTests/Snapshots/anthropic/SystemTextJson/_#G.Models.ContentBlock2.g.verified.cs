//HintName: G.Models.ContentBlock2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentBlock2 : global::System.IEquatable<ContentBlock2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContentBlockStartEventContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextBlock? Text { get; init; }
#else
        public global::G.ResponseTextBlock? Text { get; }
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
        public static implicit operator ContentBlock2(global::G.ResponseTextBlock value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextBlock?(ContentBlock2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.ResponseTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseToolUseBlock? ToolUse { get; init; }
#else
        public global::G.ResponseToolUseBlock? ToolUse { get; }
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
        public static implicit operator ContentBlock2(global::G.ResponseToolUseBlock value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseToolUseBlock?(ContentBlock2 @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.ResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseThinkingBlock? Thinking { get; init; }
#else
        public global::G.ResponseThinkingBlock? Thinking { get; }
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
        public static implicit operator ContentBlock2(global::G.ResponseThinkingBlock value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseThinkingBlock?(ContentBlock2 @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.ResponseThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::G.ResponseRedactedThinkingBlock? RedactedThinking { get; }
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
        public static implicit operator ContentBlock2(global::G.ResponseRedactedThinkingBlock value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseRedactedThinkingBlock?(ContentBlock2 @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.ResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(
            global::G.ContentBlockStartEventContentBlockDiscriminatorType? type,
            global::G.ResponseTextBlock? text,
            global::G.ResponseToolUseBlock? toolUse,
            global::G.ResponseThinkingBlock? thinking,
            global::G.ResponseRedactedThinkingBlock? redactedThinking
            )
        {
            Type = type;

            Text = text;
            ToolUse = toolUse;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedThinking as object ??
            Thinking as object ??
            ToolUse as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolUse?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolUse && !IsThinking && !IsRedactedThinking || !IsText && IsToolUse && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::G.ResponseToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::G.ResponseThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::G.ResponseRedactedThinkingBlock?, TResult>? redactedThinking = null,
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
            else if (IsToolUse && toolUse != null)
            {
                return toolUse(ToolUse!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsRedactedThinking && redactedThinking != null)
            {
                return redactedThinking(RedactedThinking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseTextBlock?>? text = null,
            global::System.Action<global::G.ResponseToolUseBlock?>? toolUse = null,
            global::System.Action<global::G.ResponseThinkingBlock?>? thinking = null,
            global::System.Action<global::G.ResponseRedactedThinkingBlock?>? redactedThinking = null,
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
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsRedactedThinking)
            {
                redactedThinking?.Invoke(RedactedThinking!);
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
                typeof(global::G.ResponseTextBlock),
                ToolUse,
                typeof(global::G.ResponseToolUseBlock),
                Thinking,
                typeof(global::G.ResponseThinkingBlock),
                RedactedThinking,
                typeof(global::G.ResponseRedactedThinkingBlock),
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
        public bool Equals(ContentBlock2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentBlock2 obj1, ContentBlock2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBlock2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentBlock2 obj1, ContentBlock2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBlock2 o && Equals(o);
        }
    }
}
