//HintName: G.Models.PromptBlockData.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptBlockData : global::System.IEquatable<PromptBlockData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptBlockDataChat? Chat { get; init; }
#else
        public global::G.PromptBlockDataChat? Chat { get; }
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
#if NET6_0_OR_GREATER
        public global::G.PromptBlockDataCompletion? Completion { get; init; }
#else
        public global::G.PromptBlockDataCompletion? Completion { get; }
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
        public static implicit operator PromptBlockData(global::G.PromptBlockDataChat value) => new PromptBlockData((global::G.PromptBlockDataChat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptBlockDataChat?(PromptBlockData @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public PromptBlockData(global::G.PromptBlockDataChat? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptBlockData(global::G.PromptBlockDataCompletion value) => new PromptBlockData((global::G.PromptBlockDataCompletion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptBlockDataCompletion?(PromptBlockData @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public PromptBlockData(global::G.PromptBlockDataCompletion? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptBlockData(
            global::G.PromptBlockDataChat? chat,
            global::G.PromptBlockDataCompletion? completion
            )
        {
            Chat = chat;
            Completion = completion;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Completion as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            Completion?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat || IsCompletion;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptBlockDataChat?, TResult>? chat = null,
            global::System.Func<global::G.PromptBlockDataCompletion?, TResult>? completion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptBlockDataChat?>? chat = null,
            global::System.Action<global::G.PromptBlockDataCompletion?>? completion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::G.PromptBlockDataChat),
                Completion,
                typeof(global::G.PromptBlockDataCompletion),
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
        public bool Equals(PromptBlockData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptBlockDataChat?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptBlockDataCompletion?>.Default.Equals(Completion, other.Completion) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptBlockData obj1, PromptBlockData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptBlockData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptBlockData obj1, PromptBlockData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptBlockData o && Equals(o);
        }
    }
}
