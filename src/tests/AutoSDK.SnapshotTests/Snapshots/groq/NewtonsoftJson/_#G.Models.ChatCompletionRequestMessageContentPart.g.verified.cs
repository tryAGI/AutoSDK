//HintName: G.Models.ChatCompletionRequestMessageContentPart.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessageContentPart : global::System.IEquatable<ChatCompletionRequestMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartText? TextContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartText? TextContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContentPart))]
#endif
        public bool IsTextContentPart => TextContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageContentPart))]
#endif
        public bool IsImageContentPart => ImageContentPart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartDocument? DocumentContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartDocument? DocumentContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentContentPart))]
#endif
        public bool IsDocumentContentPart => DocumentContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestMessageContentPart((global::G.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestMessageContentPart((global::G.ChatCompletionRequestMessageContentPartImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestMessageContentPart @this) => @this.ImageContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartDocument value) => new ChatCompletionRequestMessageContentPart((global::G.ChatCompletionRequestMessageContentPartDocument?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartDocument?(ChatCompletionRequestMessageContentPart @this) => @this.DocumentContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(global::G.ChatCompletionRequestMessageContentPartDocument? value)
        {
            DocumentContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentPart(
            global::G.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::G.ChatCompletionRequestMessageContentPartImage? imageContentPart,
            global::G.ChatCompletionRequestMessageContentPartDocument? documentContentPart
            )
        {
            TextContentPart = textContentPart;
            ImageContentPart = imageContentPart;
            DocumentContentPart = documentContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentContentPart as object ??
            ImageContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ImageContentPart?.ToString() ??
            DocumentContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsImageContentPart && !IsDocumentContentPart || !IsTextContentPart && IsImageContentPart && !IsDocumentContentPart || !IsTextContentPart && !IsImageContentPart && IsDocumentContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartImage?, TResult>? imageContentPart = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartDocument?, TResult>? documentContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart && textContentPart != null)
            {
                return textContentPart(TextContentPart!);
            }
            else if (IsImageContentPart && imageContentPart != null)
            {
                return imageContentPart(ImageContentPart!);
            }
            else if (IsDocumentContentPart && documentContentPart != null)
            {
                return documentContentPart(DocumentContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartImage?>? imageContentPart = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartDocument?>? documentContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
            }
            else if (IsDocumentContentPart)
            {
                documentContentPart?.Invoke(DocumentContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartText),
                ImageContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartImage),
                DocumentContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartDocument),
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
        public bool Equals(ChatCompletionRequestMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageContentPart, other.ImageContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartDocument?>.Default.Equals(DocumentContentPart, other.DocumentContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessageContentPart obj1, ChatCompletionRequestMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessageContentPart o && Equals(o);
        }
    }
}
