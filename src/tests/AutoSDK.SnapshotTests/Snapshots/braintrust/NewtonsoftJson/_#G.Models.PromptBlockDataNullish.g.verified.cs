//HintName: G.Models.PromptBlockDataNullish.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptBlockDataNullish : global::System.IEquatable<PromptBlockDataNullish>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptBlockDataNullishChat? Chat { get; init; }
#else
        public global::G.PromptBlockDataNullishChat? Chat { get; }
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
        public global::G.PromptBlockDataNullishCompletion? Completion { get; init; }
#else
        public global::G.PromptBlockDataNullishCompletion? Completion { get; }
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
        public object? PromptBlockDataNullishVariant3 { get; init; }
#else
        public object? PromptBlockDataNullishVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptBlockDataNullishVariant3))]
#endif
        public bool IsPromptBlockDataNullishVariant3 => PromptBlockDataNullishVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptBlockDataNullish(global::G.PromptBlockDataNullishChat value) => new PromptBlockDataNullish((global::G.PromptBlockDataNullishChat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptBlockDataNullishChat?(PromptBlockDataNullish @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public PromptBlockDataNullish(global::G.PromptBlockDataNullishChat? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptBlockDataNullish(global::G.PromptBlockDataNullishCompletion value) => new PromptBlockDataNullish((global::G.PromptBlockDataNullishCompletion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptBlockDataNullishCompletion?(PromptBlockDataNullish @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public PromptBlockDataNullish(global::G.PromptBlockDataNullishCompletion? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptBlockDataNullish(
            global::G.PromptBlockDataNullishChat? chat,
            global::G.PromptBlockDataNullishCompletion? completion,
            object? promptBlockDataNullishVariant3
            )
        {
            Chat = chat;
            Completion = completion;
            PromptBlockDataNullishVariant3 = promptBlockDataNullishVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PromptBlockDataNullishVariant3 as object ??
            Completion as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            Completion?.ToString() ??
            PromptBlockDataNullishVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat || IsCompletion || IsPromptBlockDataNullishVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptBlockDataNullishChat?, TResult>? chat = null,
            global::System.Func<global::G.PromptBlockDataNullishCompletion?, TResult>? completion = null,
            global::System.Func<object?, TResult>? promptBlockDataNullishVariant3 = null,
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
            else if (IsPromptBlockDataNullishVariant3 && promptBlockDataNullishVariant3 != null)
            {
                return promptBlockDataNullishVariant3(PromptBlockDataNullishVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptBlockDataNullishChat?>? chat = null,
            global::System.Action<global::G.PromptBlockDataNullishCompletion?>? completion = null,
            global::System.Action<object?>? promptBlockDataNullishVariant3 = null,
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
            else if (IsPromptBlockDataNullishVariant3)
            {
                promptBlockDataNullishVariant3?.Invoke(PromptBlockDataNullishVariant3!);
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
                typeof(global::G.PromptBlockDataNullishChat),
                Completion,
                typeof(global::G.PromptBlockDataNullishCompletion),
                PromptBlockDataNullishVariant3,
                typeof(object),
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
        public bool Equals(PromptBlockDataNullish other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptBlockDataNullishChat?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptBlockDataNullishCompletion?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(PromptBlockDataNullishVariant3, other.PromptBlockDataNullishVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptBlockDataNullish obj1, PromptBlockDataNullish obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptBlockDataNullish>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptBlockDataNullish obj1, PromptBlockDataNullish obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptBlockDataNullish o && Equals(o);
        }
    }
}
