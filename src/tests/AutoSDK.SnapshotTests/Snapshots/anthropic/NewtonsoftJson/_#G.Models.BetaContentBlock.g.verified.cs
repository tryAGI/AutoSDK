//HintName: G.Models.BetaContentBlock.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaContentBlock : global::System.IEquatable<BetaContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaContentBlockDiscriminatorType? Type { get; }

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
        public static implicit operator BetaContentBlock(global::G.BetaResponseTextBlock value) => new BetaContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseTextBlock?(BetaContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::G.BetaResponseTextBlock? value)
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
        public static implicit operator BetaContentBlock(global::G.BetaResponseToolUseBlock value) => new BetaContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaResponseToolUseBlock?(BetaContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(global::G.BetaResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaContentBlock(
            global::G.BetaContentBlockDiscriminatorType? type,
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
        public bool Equals(BetaContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaContentBlock obj1, BetaContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaContentBlock obj1, BetaContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaContentBlock o && Equals(o);
        }
    }
}
