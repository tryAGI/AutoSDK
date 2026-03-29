//HintName: G.Models.ChatContentItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Content part for chat completion messages
    /// </summary>
    public readonly partial struct ChatContentItems : global::System.IEquatable<ChatContentItems>
    {
        /// <summary>
        /// Text content part
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentText? ChatContentText { get; init; }
#else
        public global::G.ChatContentText? ChatContentText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentText))]
#endif
        public bool IsChatContentText => ChatContentText != null;

        /// <summary>
        /// Image content part for vision models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentImage? ChatContentImage { get; init; }
#else
        public global::G.ChatContentImage? ChatContentImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentImage))]
#endif
        public bool IsChatContentImage => ChatContentImage != null;

        /// <summary>
        /// Audio input content part. Supported audio formats vary by provider.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentAudio? ChatContentAudio { get; init; }
#else
        public global::G.ChatContentAudio? ChatContentAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentAudio))]
#endif
        public bool IsChatContentAudio => ChatContentAudio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentItems3? ChatContentItems3 { get; init; }
#else
        public global::G.ChatContentItems3? ChatContentItems3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentItems3))]
#endif
        public bool IsChatContentItems3 => ChatContentItems3 != null;

        /// <summary>
        /// File content part for document processing
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentFile? ChatContentFile { get; init; }
#else
        public global::G.ChatContentFile? ChatContentFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentFile))]
#endif
        public bool IsChatContentFile => ChatContentFile != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::G.ChatContentText value) => new ChatContentItems((global::G.ChatContentText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentText?(ChatContentItems @this) => @this.ChatContentText;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::G.ChatContentText? value)
        {
            ChatContentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::G.ChatContentImage value) => new ChatContentItems((global::G.ChatContentImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentImage?(ChatContentItems @this) => @this.ChatContentImage;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::G.ChatContentImage? value)
        {
            ChatContentImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::G.ChatContentAudio value) => new ChatContentItems((global::G.ChatContentAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentAudio?(ChatContentItems @this) => @this.ChatContentAudio;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::G.ChatContentAudio? value)
        {
            ChatContentAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::G.ChatContentItems3 value) => new ChatContentItems((global::G.ChatContentItems3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentItems3?(ChatContentItems @this) => @this.ChatContentItems3;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::G.ChatContentItems3? value)
        {
            ChatContentItems3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::G.ChatContentFile value) => new ChatContentItems((global::G.ChatContentFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentFile?(ChatContentItems @this) => @this.ChatContentFile;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::G.ChatContentFile? value)
        {
            ChatContentFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(
            global::G.ChatContentText? chatContentText,
            global::G.ChatContentImage? chatContentImage,
            global::G.ChatContentAudio? chatContentAudio,
            global::G.ChatContentItems3? chatContentItems3,
            global::G.ChatContentFile? chatContentFile
            )
        {
            ChatContentText = chatContentText;
            ChatContentImage = chatContentImage;
            ChatContentAudio = chatContentAudio;
            ChatContentItems3 = chatContentItems3;
            ChatContentFile = chatContentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatContentFile as object ??
            ChatContentItems3 as object ??
            ChatContentAudio as object ??
            ChatContentImage as object ??
            ChatContentText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatContentText?.ToString() ??
            ChatContentImage?.ToString() ??
            ChatContentAudio?.ToString() ??
            ChatContentItems3?.ToString() ??
            ChatContentFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatContentText && !IsChatContentImage && !IsChatContentAudio && !IsChatContentItems3 && !IsChatContentFile || !IsChatContentText && IsChatContentImage && !IsChatContentAudio && !IsChatContentItems3 && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && IsChatContentAudio && !IsChatContentItems3 && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && !IsChatContentAudio && IsChatContentItems3 && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && !IsChatContentAudio && !IsChatContentItems3 && IsChatContentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatContentText?, TResult>? chatContentText = null,
            global::System.Func<global::G.ChatContentImage?, TResult>? chatContentImage = null,
            global::System.Func<global::G.ChatContentAudio?, TResult>? chatContentAudio = null,
            global::System.Func<global::G.ChatContentItems3?, TResult>? chatContentItems3 = null,
            global::System.Func<global::G.ChatContentFile?, TResult>? chatContentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatContentText && chatContentText != null)
            {
                return chatContentText(ChatContentText!);
            }
            else if (IsChatContentImage && chatContentImage != null)
            {
                return chatContentImage(ChatContentImage!);
            }
            else if (IsChatContentAudio && chatContentAudio != null)
            {
                return chatContentAudio(ChatContentAudio!);
            }
            else if (IsChatContentItems3 && chatContentItems3 != null)
            {
                return chatContentItems3(ChatContentItems3!);
            }
            else if (IsChatContentFile && chatContentFile != null)
            {
                return chatContentFile(ChatContentFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatContentText?>? chatContentText = null,
            global::System.Action<global::G.ChatContentImage?>? chatContentImage = null,
            global::System.Action<global::G.ChatContentAudio?>? chatContentAudio = null,
            global::System.Action<global::G.ChatContentItems3?>? chatContentItems3 = null,
            global::System.Action<global::G.ChatContentFile?>? chatContentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatContentText)
            {
                chatContentText?.Invoke(ChatContentText!);
            }
            else if (IsChatContentImage)
            {
                chatContentImage?.Invoke(ChatContentImage!);
            }
            else if (IsChatContentAudio)
            {
                chatContentAudio?.Invoke(ChatContentAudio!);
            }
            else if (IsChatContentItems3)
            {
                chatContentItems3?.Invoke(ChatContentItems3!);
            }
            else if (IsChatContentFile)
            {
                chatContentFile?.Invoke(ChatContentFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatContentText,
                typeof(global::G.ChatContentText),
                ChatContentImage,
                typeof(global::G.ChatContentImage),
                ChatContentAudio,
                typeof(global::G.ChatContentAudio),
                ChatContentItems3,
                typeof(global::G.ChatContentItems3),
                ChatContentFile,
                typeof(global::G.ChatContentFile),
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
        public bool Equals(ChatContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentText?>.Default.Equals(ChatContentText, other.ChatContentText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentImage?>.Default.Equals(ChatContentImage, other.ChatContentImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentAudio?>.Default.Equals(ChatContentAudio, other.ChatContentAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentItems3?>.Default.Equals(ChatContentItems3, other.ChatContentItems3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentFile?>.Default.Equals(ChatContentFile, other.ChatContentFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentItems obj1, ChatContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentItems obj1, ChatContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentItems o && Equals(o);
        }
    }
}
