//HintName: G.Models.ContentVariant2Item3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item3 : global::System.IEquatable<ContentVariant2Item3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptCachingBetaRequestTextBlock? Text { get; init; }
#else
        public global::G.PromptCachingBetaRequestTextBlock? Text { get; }
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
        public static implicit operator ContentVariant2Item3(global::G.PromptCachingBetaRequestTextBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCachingBetaRequestTextBlock?(ContentVariant2Item3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::G.PromptCachingBetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptCachingBetaRequestImageBlock? Image { get; init; }
#else
        public global::G.PromptCachingBetaRequestImageBlock? Image { get; }
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
        public static implicit operator ContentVariant2Item3(global::G.PromptCachingBetaRequestImageBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCachingBetaRequestImageBlock?(ContentVariant2Item3 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::G.PromptCachingBetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptCachingBetaRequestToolUseBlock? ToolUse { get; init; }
#else
        public global::G.PromptCachingBetaRequestToolUseBlock? ToolUse { get; }
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
        public static implicit operator ContentVariant2Item3(global::G.PromptCachingBetaRequestToolUseBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCachingBetaRequestToolUseBlock?(ContentVariant2Item3 @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::G.PromptCachingBetaRequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptCachingBetaRequestToolResultBlock? ToolResult { get; init; }
#else
        public global::G.PromptCachingBetaRequestToolResultBlock? ToolResult { get; }
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
        public static implicit operator ContentVariant2Item3(global::G.PromptCachingBetaRequestToolResultBlock value) => new ContentVariant2Item3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCachingBetaRequestToolResultBlock?(ContentVariant2Item3 @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(global::G.PromptCachingBetaRequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item3(
            global::G.PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType? type,
            global::G.PromptCachingBetaRequestTextBlock? text,
            global::G.PromptCachingBetaRequestImageBlock? image,
            global::G.PromptCachingBetaRequestToolUseBlock? toolUse,
            global::G.PromptCachingBetaRequestToolResultBlock? toolResult
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolUse = toolUse;
            ToolResult = toolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            return IsText && !IsImage && !IsToolUse && !IsToolResult || !IsText && IsImage && !IsToolUse && !IsToolResult || !IsText && !IsImage && IsToolUse && !IsToolResult || !IsText && !IsImage && !IsToolUse && IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptCachingBetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::G.PromptCachingBetaRequestImageBlock?, TResult>? image = null,
            global::System.Func<global::G.PromptCachingBetaRequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::G.PromptCachingBetaRequestToolResultBlock?, TResult>? toolResult = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptCachingBetaRequestTextBlock?>? text = null,
            global::System.Action<global::G.PromptCachingBetaRequestImageBlock?>? image = null,
            global::System.Action<global::G.PromptCachingBetaRequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::G.PromptCachingBetaRequestToolResultBlock?>? toolResult = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.PromptCachingBetaRequestTextBlock),
                Image,
                typeof(global::G.PromptCachingBetaRequestImageBlock),
                ToolUse,
                typeof(global::G.PromptCachingBetaRequestToolUseBlock),
                ToolResult,
                typeof(global::G.PromptCachingBetaRequestToolResultBlock),
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
        public bool Equals(ContentVariant2Item3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptCachingBetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptCachingBetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptCachingBetaRequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptCachingBetaRequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item3 obj1, ContentVariant2Item3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item3 obj1, ContentVariant2Item3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item3 o && Equals(o);
        }
    }
}
