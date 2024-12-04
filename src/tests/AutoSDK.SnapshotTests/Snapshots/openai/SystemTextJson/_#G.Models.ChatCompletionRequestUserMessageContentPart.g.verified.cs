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
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestUserMessageContentPartDiscriminatorType? Type { get; }

        /// <summary>
        /// Learn about [text inputs](/docs/guides/text-generation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartText? Text { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartText? Text { get; }
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
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestUserMessageContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        /// Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartImage? ImageUrl { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartImage? ImageUrl { get; }
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
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestUserMessageContentPart @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// Learn about [audio inputs](/docs/guides/audio).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestMessageContentPartAudio? InputAudio { get; init; }
#else
        public global::G.ChatCompletionRequestMessageContentPartAudio? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartAudio value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestMessageContentPartAudio?(ChatCompletionRequestUserMessageContentPart @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::G.ChatCompletionRequestMessageContentPartAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(
            global::G.ChatCompletionRequestUserMessageContentPartDiscriminatorType? type,
            global::G.ChatCompletionRequestMessageContentPartText? text,
            global::G.ChatCompletionRequestMessageContentPartImage? imageUrl,
            global::G.ChatCompletionRequestMessageContentPartAudio? inputAudio
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            InputAudio = inputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputAudio as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsInputAudio || !IsText && IsImageUrl && !IsInputAudio || !IsText && !IsImageUrl && IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartText?, TResult>? text = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartImage?, TResult>? imageUrl = null,
            global::System.Func<global::G.ChatCompletionRequestMessageContentPartAudio?, TResult>? inputAudio = null,
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
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartText?>? text = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartImage?>? imageUrl = null,
            global::System.Action<global::G.ChatCompletionRequestMessageContentPartAudio?>? inputAudio = null,
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
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
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
                typeof(global::G.ChatCompletionRequestMessageContentPartText),
                ImageUrl,
                typeof(global::G.ChatCompletionRequestMessageContentPartImage),
                InputAudio,
                typeof(global::G.ChatCompletionRequestMessageContentPartAudio),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestMessageContentPartAudio?>.Default.Equals(InputAudio, other.InputAudio) 
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
