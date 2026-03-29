//HintName: G.Models.PromptTemplate5.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The prompt template. Either a CompletionPrompt (type: 'completion') or ChatPrompt (type: 'chat').
    /// </summary>
    public readonly partial struct PromptTemplate5 : global::System.IEquatable<PromptTemplate5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptBlueprintPromptTemplateDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompletionPrompt? Completion { get; init; }
#else
        public global::G.CompletionPrompt? Completion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completion))]
#endif
        public bool IsCompletion => Completion != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatPrompt? Chat { get; init; }
#else
        public global::G.ChatPrompt? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptTemplate5(global::G.CompletionPrompt value) => new PromptTemplate5((global::G.CompletionPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompletionPrompt?(PromptTemplate5 @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplate5(global::G.CompletionPrompt? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptTemplate5(global::G.ChatPrompt value) => new PromptTemplate5((global::G.ChatPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatPrompt?(PromptTemplate5 @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplate5(global::G.ChatPrompt? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplate5(
            global::G.PromptBlueprintPromptTemplateDiscriminatorType? type,
            global::G.CompletionPrompt? completion,
            global::G.ChatPrompt? chat
            )
        {
            Type = type;

            Completion = completion;
            Chat = chat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Chat as object ??
            Completion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completion?.ToString() ??
            Chat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletion || IsChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CompletionPrompt?, TResult>? completion = null,
            global::System.Func<global::G.ChatPrompt?, TResult>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CompletionPrompt?>? completion = null,
            global::System.Action<global::G.ChatPrompt?>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completion,
                typeof(global::G.CompletionPrompt),
                Chat,
                typeof(global::G.ChatPrompt),
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
        public bool Equals(PromptTemplate5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CompletionPrompt?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatPrompt?>.Default.Equals(Chat, other.Chat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptTemplate5 obj1, PromptTemplate5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptTemplate5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptTemplate5 obj1, PromptTemplate5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptTemplate5 o && Equals(o);
        }
    }
}
