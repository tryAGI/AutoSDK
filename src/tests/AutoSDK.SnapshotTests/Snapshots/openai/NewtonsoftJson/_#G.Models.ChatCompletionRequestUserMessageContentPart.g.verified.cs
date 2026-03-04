//HintName: G.Models.ChatCompletionRequestUserMessageContentPart.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestUserMessageContentPart : global::System.IEquatable<ChatCompletionRequestUserMessageContentPart>
    {
        /// <summary>
        /// Learn about [text inputs](/docs/guides/text-generation).
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
        /// Learn about [image inputs](/docs/guides/vision).
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
        /// Learn about [audio inputs](/docs/guides/audio).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartAudio? AudioContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartAudio? AudioContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioContentPart))]
#endif
        public bool IsAudioContentPart => AudioContentPart != null;

        /// <summary>
        /// Learn about [file inputs](/docs/guides/text) for text generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartFile? FileContentPart { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartFile? FileContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileContentPart))]
#endif
        public bool IsFileContentPart => FileContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestUserMessageContentPart((global::G.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestUserMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestUserMessageContentPart((global::G.ChatCompletionRequestMessageContentPartImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestUserMessageContentPart @this) => @this.ImageContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartAudio value) => new ChatCompletionRequestUserMessageContentPart((global::G.ChatCompletionRequestMessageContentPartAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartAudio?(ChatCompletionRequestUserMessageContentPart @this) => @this.AudioContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartAudio? value)
        {
            AudioContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartFile value) => new ChatCompletionRequestUserMessageContentPart((global::G.ChatCompletionRequestMessageContentPartFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartFile?(ChatCompletionRequestUserMessageContentPart @this) => @this.FileContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartFile? value)
        {
            FileContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(
            global::G.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::G.ChatCompletionRequestMessageContentPartImage? imageContentPart,
            global::G.ChatCompletionRequestMessageContentPartAudio? audioContentPart,
            global::G.ChatCompletionRequestMessageContentPartFile? fileContentPart
            )
        {
            TextContentPart = textContentPart;
            ImageContentPart = imageContentPart;
            AudioContentPart = audioContentPart;
            FileContentPart = fileContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileContentPart as object ??
            AudioContentPart as object ??
            ImageContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ImageContentPart?.ToString() ??
            AudioContentPart?.ToString() ??
            FileContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsImageContentPart && !IsAudioContentPart && !IsFileContentPart || !IsTextContentPart && IsImageContentPart && !IsAudioContentPart && !IsFileContentPart || !IsTextContentPart && !IsImageContentPart && IsAudioContentPart && !IsFileContentPart || !IsTextContentPart && !IsImageContentPart && !IsAudioContentPart && IsFileContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartImage?, TResult>? imageContentPart = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartAudio?, TResult>? audioContentPart = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartFile?, TResult>? fileContentPart = null,
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
            else if (IsAudioContentPart && audioContentPart != null)
            {
                return audioContentPart(AudioContentPart!);
            }
            else if (IsFileContentPart && fileContentPart != null)
            {
                return fileContentPart(FileContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartImage?>? imageContentPart = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartAudio?>? audioContentPart = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartFile?>? fileContentPart = null,
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
            else if (IsAudioContentPart)
            {
                audioContentPart?.Invoke(AudioContentPart!);
            }
            else if (IsFileContentPart)
            {
                fileContentPart?.Invoke(FileContentPart!);
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
                AudioContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartAudio),
                FileContentPart,
                typeof(global::G.ChatCompletionRequestMessageContentPartFile),
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
        public bool Equals(ChatCompletionRequestUserMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageContentPart, other.ImageContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartAudio?>.Default.Equals(AudioContentPart, other.AudioContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartFile?>.Default.Equals(FileContentPart, other.FileContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestUserMessageContentPart obj1, ChatCompletionRequestUserMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestUserMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestUserMessageContentPart obj1, ChatCompletionRequestUserMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestUserMessageContentPart o && Equals(o);
        }
    }
}
