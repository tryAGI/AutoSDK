//HintName: G.Models.ConversationFlowResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationFlowResponse : global::System.IEquatable<ConversationFlowResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationFlow? ConversationFlow { get; init; }
#else
        public global::G.ConversationFlow? ConversationFlow { get; }
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
        public bool TryPickConversationFlow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationFlow? value)
        {
            value = ConversationFlow;
            return IsConversationFlow;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationFlow PickConversationFlow() => ConversationFlow is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationFlow' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationFlowResponseVariant2? ConversationFlowResponseVariant2 { get; init; }
#else
        public global::G.ConversationFlowResponseVariant2? ConversationFlowResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlowResponseVariant2))]
#endif
        public bool IsConversationFlowResponseVariant2 => ConversationFlowResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConversationFlowResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationFlowResponseVariant2? value)
        {
            value = ConversationFlowResponseVariant2;
            return IsConversationFlowResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationFlowResponseVariant2 PickConversationFlowResponseVariant2() => ConversationFlowResponseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationFlowResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowResponse(global::G.ConversationFlow value) => new ConversationFlowResponse((global::G.ConversationFlow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationFlow?(ConversationFlowResponse @this) => @this.ConversationFlow;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowResponse(global::G.ConversationFlow? value)
        {
            ConversationFlow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConversationFlowResponse FromConversationFlow(global::G.ConversationFlow? value) => new ConversationFlowResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowResponse(global::G.ConversationFlowResponseVariant2 value) => new ConversationFlowResponse((global::G.ConversationFlowResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationFlowResponseVariant2?(ConversationFlowResponse @this) => @this.ConversationFlowResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowResponse(global::G.ConversationFlowResponseVariant2? value)
        {
            ConversationFlowResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConversationFlowResponse FromConversationFlowResponseVariant2(global::G.ConversationFlowResponseVariant2? value) => new ConversationFlowResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowResponse(
            global::G.ConversationFlow? conversationFlow,
            global::G.ConversationFlowResponseVariant2? conversationFlowResponseVariant2
            )
        {
            ConversationFlow = conversationFlow;
            ConversationFlowResponseVariant2 = conversationFlowResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlowResponseVariant2 as object ??
            ConversationFlow as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationFlow?.ToString() ??
            ConversationFlowResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationFlow && IsConversationFlowResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConversationFlow?, TResult>? conversationFlow = null,
            global::System.Func<global::G.ConversationFlowResponseVariant2, TResult>? conversationFlowResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationFlow is { } __value0 && conversationFlow != null)
            {
                return conversationFlow(__value0);
            }
            else if (ConversationFlowResponseVariant2 is { } __value1 && conversationFlowResponseVariant2 != null)
            {
                return conversationFlowResponseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationFlow?>? conversationFlow = null,

            global::System.Action<global::G.ConversationFlowResponseVariant2>? conversationFlowResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationFlow is { } __value0)
            {
                conversationFlow?.Invoke(__value0);
            }
            else if (ConversationFlowResponseVariant2 is { } __value1)
            {
                conversationFlowResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ConversationFlow?>? conversationFlow = null,
            global::System.Action<global::G.ConversationFlowResponseVariant2>? conversationFlowResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationFlow is { } __value0)
            {
                conversationFlow?.Invoke(__value0);
            }
            else if (ConversationFlowResponseVariant2 is { } __value1)
            {
                conversationFlowResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationFlow,
                typeof(global::G.ConversationFlow),
                ConversationFlowResponseVariant2,
                typeof(global::G.ConversationFlowResponseVariant2),
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
        public bool Equals(ConversationFlowResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationFlow?>.Default.Equals(ConversationFlow, other.ConversationFlow) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationFlowResponseVariant2?>.Default.Equals(ConversationFlowResponseVariant2, other.ConversationFlowResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationFlowResponse obj1, ConversationFlowResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationFlowResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationFlowResponse obj1, ConversationFlowResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationFlowResponse o && Equals(o);
        }
    }
}
