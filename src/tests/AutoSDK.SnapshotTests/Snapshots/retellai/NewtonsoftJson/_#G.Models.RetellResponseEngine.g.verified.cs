//HintName: G.Models.RetellResponseEngine.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response engine for test cases. Custom LLM is not supported.
    /// </summary>
    public readonly partial struct RetellResponseEngine : global::System.IEquatable<RetellResponseEngine>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseEngineRetellLm? Lm { get; init; }
#else
        public global::G.ResponseEngineRetellLm? Lm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lm))]
#endif
        public bool IsLm => Lm != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseEngineConversationFlow? ConversationFlow { get; init; }
#else
        public global::G.ResponseEngineConversationFlow? ConversationFlow { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlow))]
#endif
        public bool IsConversationFlow => ConversationFlow != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellResponseEngine(global::G.ResponseEngineRetellLm value) => new RetellResponseEngine((global::G.ResponseEngineRetellLm?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseEngineRetellLm?(RetellResponseEngine @this) => @this.Lm;

        /// <summary>
        /// 
        /// </summary>
        public RetellResponseEngine(global::G.ResponseEngineRetellLm? value)
        {
            Lm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellResponseEngine(global::G.ResponseEngineConversationFlow value) => new RetellResponseEngine((global::G.ResponseEngineConversationFlow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseEngineConversationFlow?(RetellResponseEngine @this) => @this.ConversationFlow;

        /// <summary>
        /// 
        /// </summary>
        public RetellResponseEngine(global::G.ResponseEngineConversationFlow? value)
        {
            ConversationFlow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetellResponseEngine(
            global::G.ResponseEngineRetellLm? lm,
            global::G.ResponseEngineConversationFlow? conversationFlow
            )
        {
            Lm = lm;
            ConversationFlow = conversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlow as object ??
            Lm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Lm?.ToString() ??
            ConversationFlow?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLm && !IsConversationFlow || !IsLm && IsConversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseEngineRetellLm?, TResult>? lm = null,
            global::System.Func<global::G.ResponseEngineConversationFlow?, TResult>? conversationFlow = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLm && lm != null)
            {
                return lm(Lm!);
            }
            else if (IsConversationFlow && conversationFlow != null)
            {
                return conversationFlow(ConversationFlow!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseEngineRetellLm?>? lm = null,
            global::System.Action<global::G.ResponseEngineConversationFlow?>? conversationFlow = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLm)
            {
                lm?.Invoke(Lm!);
            }
            else if (IsConversationFlow)
            {
                conversationFlow?.Invoke(ConversationFlow!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Lm,
                typeof(global::G.ResponseEngineRetellLm),
                ConversationFlow,
                typeof(global::G.ResponseEngineConversationFlow),
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
        public bool Equals(RetellResponseEngine other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseEngineRetellLm?>.Default.Equals(Lm, other.Lm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseEngineConversationFlow?>.Default.Equals(ConversationFlow, other.ConversationFlow) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RetellResponseEngine obj1, RetellResponseEngine obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RetellResponseEngine>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RetellResponseEngine obj1, RetellResponseEngine obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RetellResponseEngine o && Equals(o);
        }
    }
}
