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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaResponseTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseTextBlock PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaResponseToolUseBlock? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseToolUseBlock PickToolUse() => ToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

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
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaResponseThinkingBlock? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseThinkingBlock PickThinking() => Thinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

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
        public bool TryPickRedactedThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaResponseRedactedThinkingBlock? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaResponseRedactedThinkingBlock PickRedactedThinking() => RedactedThinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock2(global::G.BetaResponseTextBlock value) => new ContentBlock2((global::G.BetaResponseTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseTextBlock?(ContentBlock2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.BetaResponseTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentBlock2 FromText(global::G.BetaResponseTextBlock? value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock2(global::G.BetaResponseToolUseBlock value) => new ContentBlock2((global::G.BetaResponseToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseToolUseBlock?(ContentBlock2 @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.BetaResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentBlock2 FromToolUse(global::G.BetaResponseToolUseBlock? value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock2(global::G.BetaResponseThinkingBlock value) => new ContentBlock2((global::G.BetaResponseThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseThinkingBlock?(ContentBlock2 @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.BetaResponseThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentBlock2 FromThinking(global::G.BetaResponseThinkingBlock? value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock2(global::G.BetaResponseRedactedThinkingBlock value) => new ContentBlock2((global::G.BetaResponseRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseRedactedThinkingBlock?(ContentBlock2 @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(global::G.BetaResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentBlock2 FromRedactedThinking(global::G.BetaResponseRedactedThinkingBlock? value) => new ContentBlock2(value);

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock2(
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
            global::System.Func<global::G.BetaResponseTextBlock, TResult>? text = null,
            global::System.Func<global::G.BetaResponseToolUseBlock, TResult>? toolUse = null,
            global::System.Func<global::G.BetaResponseThinkingBlock, TResult>? thinking = null,
            global::System.Func<global::G.BetaResponseRedactedThinkingBlock, TResult>? redactedThinking = null,
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
            else if (ToolUse is { } __value1 && toolUse != null)
            {
                return toolUse(__value1);
            }
            else if (Thinking is { } __value2 && thinking != null)
            {
                return thinking(__value2);
            }
            else if (RedactedThinking is { } __value3 && redactedThinking != null)
            {
                return redactedThinking(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaResponseTextBlock>? text = null,

            global::System.Action<global::G.BetaResponseToolUseBlock>? toolUse = null,

            global::System.Action<global::G.BetaResponseThinkingBlock>? thinking = null,

            global::System.Action<global::G.BetaResponseRedactedThinkingBlock>? redactedThinking = null,
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
            else if (ToolUse is { } __value1)
            {
                toolUse?.Invoke(__value1);
            }
            else if (Thinking is { } __value2)
            {
                thinking?.Invoke(__value2);
            }
            else if (RedactedThinking is { } __value3)
            {
                redactedThinking?.Invoke(__value3);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.BetaResponseTextBlock>? text = null,
            global::System.Action<global::G.BetaResponseToolUseBlock>? toolUse = null,
            global::System.Action<global::G.BetaResponseThinkingBlock>? thinking = null,
            global::System.Action<global::G.BetaResponseRedactedThinkingBlock>? redactedThinking = null,
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
            else if (ToolUse is { } __value1)
            {
                toolUse?.Invoke(__value1);
            }
            else if (Thinking is { } __value2)
            {
                thinking?.Invoke(__value2);
            }
            else if (RedactedThinking is { } __value3)
            {
                redactedThinking?.Invoke(__value3);
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
        public bool Equals(ContentBlock2 other)
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
