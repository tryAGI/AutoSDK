//HintName: G.Models.ChatCompletionContentPart.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionContentPart : global::System.IEquatable<ChatCompletionContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionContentPartTextWithTitle? Text { get; init; }
#else
        public global::G.ChatCompletionContentPartTextWithTitle? Text { get; }
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
        public global::G.ChatCompletionContentPartImageWithTitle? ImageUrl { get; init; }
#else
        public global::G.ChatCompletionContentPartImageWithTitle? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionContentPartFileWithTitle? File { get; init; }
#else
        public global::G.ChatCompletionContentPartFileWithTitle? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionContentPart(global::G.ChatCompletionContentPartTextWithTitle value) => new ChatCompletionContentPart((global::G.ChatCompletionContentPartTextWithTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionContentPartTextWithTitle?(ChatCompletionContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(global::G.ChatCompletionContentPartTextWithTitle? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionContentPart(global::G.ChatCompletionContentPartImageWithTitle value) => new ChatCompletionContentPart((global::G.ChatCompletionContentPartImageWithTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionContentPartImageWithTitle?(ChatCompletionContentPart @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(global::G.ChatCompletionContentPartImageWithTitle? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionContentPart(global::G.ChatCompletionContentPartFileWithTitle value) => new ChatCompletionContentPart((global::G.ChatCompletionContentPartFileWithTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionContentPartFileWithTitle?(ChatCompletionContentPart @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(global::G.ChatCompletionContentPartFileWithTitle? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionContentPart(
            global::G.ChatCompletionContentPartTextWithTitle? text,
            global::G.ChatCompletionContentPartImageWithTitle? imageUrl,
            global::G.ChatCompletionContentPartFileWithTitle? file
            )
        {
            Text = text;
            ImageUrl = imageUrl;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsImageUrl || IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionContentPartTextWithTitle?, TResult>? text = null,
            global::System.Func<global::G.ChatCompletionContentPartImageWithTitle?, TResult>? imageUrl = null,
            global::System.Func<global::G.ChatCompletionContentPartFileWithTitle?, TResult>? file = null,
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
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionContentPartTextWithTitle?>? text = null,
            global::System.Action<global::G.ChatCompletionContentPartImageWithTitle?>? imageUrl = null,
            global::System.Action<global::G.ChatCompletionContentPartFileWithTitle?>? file = null,
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
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
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
                typeof(global::G.ChatCompletionContentPartTextWithTitle),
                ImageUrl,
                typeof(global::G.ChatCompletionContentPartImageWithTitle),
                File,
                typeof(global::G.ChatCompletionContentPartFileWithTitle),
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
        public bool Equals(ChatCompletionContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionContentPartTextWithTitle?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionContentPartImageWithTitle?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionContentPartFileWithTitle?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionContentPart obj1, ChatCompletionContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionContentPart obj1, ChatCompletionContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionContentPart o && Equals(o);
        }
    }
}
