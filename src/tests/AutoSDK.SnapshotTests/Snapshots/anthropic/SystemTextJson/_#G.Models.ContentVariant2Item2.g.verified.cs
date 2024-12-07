//HintName: G.Models.ContentVariant2Item2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item2 : global::System.IEquatable<ContentVariant2Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessageContentVariant2ItemDiscriminatorType? Type { get; }

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
        public static implicit operator ContentVariant2Item2(global::G.RequestTextBlock value) => new ContentVariant2Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestTextBlock?(ContentVariant2Item2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::G.RequestTextBlock? value)
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
        public static implicit operator ContentVariant2Item2(global::G.RequestImageBlock value) => new ContentVariant2Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestImageBlock?(ContentVariant2Item2 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::G.RequestImageBlock? value)
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
        public static implicit operator ContentVariant2Item2(global::G.RequestToolUseBlock value) => new ContentVariant2Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestToolUseBlock?(ContentVariant2Item2 @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::G.RequestToolUseBlock? value)
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
        public static implicit operator ContentVariant2Item2(global::G.RequestToolResultBlock value) => new ContentVariant2Item2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestToolResultBlock?(ContentVariant2Item2 @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(global::G.RequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item2(
            global::G.InputMessageContentVariant2ItemDiscriminatorType? type,
            global::G.RequestTextBlock? text,
            global::G.RequestImageBlock? image,
            global::G.RequestToolUseBlock? toolUse,
            global::G.RequestToolResultBlock? toolResult
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
            global::System.Func<global::G.RequestTextBlock?, TResult>? text = null,
            global::System.Func<global::G.RequestImageBlock?, TResult>? image = null,
            global::System.Func<global::G.RequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::G.RequestToolResultBlock?, TResult>? toolResult = null,
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
            global::System.Action<global::G.RequestTextBlock?>? text = null,
            global::System.Action<global::G.RequestImageBlock?>? image = null,
            global::System.Action<global::G.RequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::G.RequestToolResultBlock?>? toolResult = null,
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
                typeof(global::G.RequestTextBlock),
                Image,
                typeof(global::G.RequestImageBlock),
                ToolUse,
                typeof(global::G.RequestToolUseBlock),
                ToolResult,
                typeof(global::G.RequestToolResultBlock),
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
        public bool Equals(ContentVariant2Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item2 obj1, ContentVariant2Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item2 obj1, ContentVariant2Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item2 o && Equals(o);
        }
    }
}
