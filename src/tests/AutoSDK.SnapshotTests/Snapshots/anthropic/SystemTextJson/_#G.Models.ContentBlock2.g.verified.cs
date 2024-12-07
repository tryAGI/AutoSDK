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
        public ContentBlock2(
            global::G.ContentBlockStartEventContentBlockDiscriminatorType? type,
            global::G.ResponseTextBlock? text,
            global::G.ResponseToolUseBlock? toolUse
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
            global::System.Func<global::G.ResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::G.ResponseToolUseBlock?, TResult>? toolUse = null,
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
            global::System.Action<global::G.ResponseTextBlock?>? text = null,
            global::System.Action<global::G.ResponseToolUseBlock?>? toolUse = null,
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
                typeof(global::G.ResponseTextBlock),
                ToolUse,
                typeof(global::G.ResponseToolUseBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) 
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
