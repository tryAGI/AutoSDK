//HintName: G.Models.ContentBlock.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentBlock : global::System.IEquatable<ContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaContentBlockStartEventContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponseTextBlock? Text { get; init; }
#else
        public global::G.BetaResponseTextBlock? Text { get; }
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
        public static implicit operator ContentBlock(global::G.BetaResponseTextBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseTextBlock?(ContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::G.BetaResponseTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponseToolUseBlock? ToolUse { get; init; }
#else
        public global::G.BetaResponseToolUseBlock? ToolUse { get; }
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
        public static implicit operator ContentBlock(global::G.BetaResponseToolUseBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseToolUseBlock?(ContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::G.BetaResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponseThinkingBlock? Thinking { get; init; }
#else
        public global::G.BetaResponseThinkingBlock? Thinking { get; }
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
        public static implicit operator ContentBlock(global::G.BetaResponseThinkingBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseThinkingBlock?(ContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::G.BetaResponseThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaResponseRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::G.BetaResponseRedactedThinkingBlock? RedactedThinking { get; }
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
        public static implicit operator ContentBlock(global::G.BetaResponseRedactedThinkingBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseRedactedThinkingBlock?(ContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::G.BetaResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(
            global::G.BetaContentBlockStartEventContentBlockDiscriminatorType? type,
            global::G.BetaResponseTextBlock? text,
            global::G.BetaResponseToolUseBlock? toolUse,
            global::G.BetaResponseThinkingBlock? thinking,
            global::G.BetaResponseRedactedThinkingBlock? redactedThinking
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
        public bool Validate()
        {
            return IsText && !IsToolUse && !IsThinking && !IsRedactedThinking || !IsText && IsToolUse && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::G.BetaResponseToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::G.BetaResponseThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::G.BetaResponseRedactedThinkingBlock?, TResult>? redactedThinking = null,
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
            global::System.Action<global::G.BetaResponseTextBlock?>? text = null,
            global::System.Action<global::G.BetaResponseToolUseBlock?>? toolUse = null,
            global::System.Action<global::G.BetaResponseThinkingBlock?>? thinking = null,
            global::System.Action<global::G.BetaResponseRedactedThinkingBlock?>? redactedThinking = null,
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
                typeof(global::G.BetaResponseTextBlock),
                ToolUse,
                typeof(global::G.BetaResponseToolUseBlock),
                Thinking,
                typeof(global::G.BetaResponseThinkingBlock),
                RedactedThinking,
                typeof(global::G.BetaResponseRedactedThinkingBlock),
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
        public bool Equals(ContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentBlock obj1, ContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentBlock obj1, ContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBlock o && Equals(o);
        }
    }
}
