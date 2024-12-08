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
        public ContentBlock(
            global::G.BetaContentBlockStartEventContentBlockDiscriminatorType? type,
            global::G.BetaResponseTextBlock? text,
            global::G.BetaResponseToolUseBlock? toolUse
            )
        {
            Type = type;

            Text = text;
            ToolUse = toolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolUse as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolUse || !IsText && IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::G.BetaResponseToolUseBlock?, TResult>? toolUse = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaResponseTextBlock?>? text = null,
            global::System.Action<global::G.BetaResponseToolUseBlock?>? toolUse = null,
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
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) 
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
