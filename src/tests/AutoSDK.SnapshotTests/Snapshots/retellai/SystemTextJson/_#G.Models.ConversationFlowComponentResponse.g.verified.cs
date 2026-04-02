//HintName: G.Models.ConversationFlowComponentResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationFlowComponentResponse : global::System.IEquatable<ConversationFlowComponentResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateConversationFlowComponentRequest? CreateRequest { get; init; }
#else
        public global::G.CreateConversationFlowComponentRequest? CreateRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateRequest))]
#endif
        public bool IsCreateRequest => CreateRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationFlowComponentResponseVariant2? ConversationFlowComponentResponseVariant2 { get; init; }
#else
        public global::G.ConversationFlowComponentResponseVariant2? ConversationFlowComponentResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationFlowComponentResponseVariant2))]
#endif
        public bool IsConversationFlowComponentResponseVariant2 => ConversationFlowComponentResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowComponentResponse(global::G.CreateConversationFlowComponentRequest value) => new ConversationFlowComponentResponse((global::G.CreateConversationFlowComponentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateConversationFlowComponentRequest?(ConversationFlowComponentResponse @this) => @this.CreateRequest;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowComponentResponse(global::G.CreateConversationFlowComponentRequest? value)
        {
            CreateRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowComponentResponse(global::G.ConversationFlowComponentResponseVariant2 value) => new ConversationFlowComponentResponse((global::G.ConversationFlowComponentResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationFlowComponentResponseVariant2?(ConversationFlowComponentResponse @this) => @this.ConversationFlowComponentResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowComponentResponse(global::G.ConversationFlowComponentResponseVariant2? value)
        {
            ConversationFlowComponentResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowComponentResponse(
            global::G.CreateConversationFlowComponentRequest? createRequest,
            global::G.ConversationFlowComponentResponseVariant2? conversationFlowComponentResponseVariant2
            )
        {
            CreateRequest = createRequest;
            ConversationFlowComponentResponseVariant2 = conversationFlowComponentResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationFlowComponentResponseVariant2 as object ??
            CreateRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateRequest?.ToString() ??
            ConversationFlowComponentResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateRequest && IsConversationFlowComponentResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateConversationFlowComponentRequest?, TResult>? createRequest = null,
            global::System.Func<global::G.ConversationFlowComponentResponseVariant2?, TResult>? conversationFlowComponentResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateRequest && createRequest != null)
            {
                return createRequest(CreateRequest!);
            }
            else if (IsConversationFlowComponentResponseVariant2 && conversationFlowComponentResponseVariant2 != null)
            {
                return conversationFlowComponentResponseVariant2(ConversationFlowComponentResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateConversationFlowComponentRequest?>? createRequest = null,
            global::System.Action<global::G.ConversationFlowComponentResponseVariant2?>? conversationFlowComponentResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateRequest)
            {
                createRequest?.Invoke(CreateRequest!);
            }
            else if (IsConversationFlowComponentResponseVariant2)
            {
                conversationFlowComponentResponseVariant2?.Invoke(ConversationFlowComponentResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateRequest,
                typeof(global::G.CreateConversationFlowComponentRequest),
                ConversationFlowComponentResponseVariant2,
                typeof(global::G.ConversationFlowComponentResponseVariant2),
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
        public bool Equals(ConversationFlowComponentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateConversationFlowComponentRequest?>.Default.Equals(CreateRequest, other.CreateRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationFlowComponentResponseVariant2?>.Default.Equals(ConversationFlowComponentResponseVariant2, other.ConversationFlowComponentResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationFlowComponentResponse obj1, ConversationFlowComponentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationFlowComponentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationFlowComponentResponse obj1, ConversationFlowComponentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationFlowComponentResponse o && Equals(o);
        }
    }
}
