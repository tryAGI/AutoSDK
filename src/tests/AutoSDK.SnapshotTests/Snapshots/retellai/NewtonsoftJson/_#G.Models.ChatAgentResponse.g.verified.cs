//HintName: G.Models.ChatAgentResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatAgentResponse : global::System.IEquatable<ChatAgentResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatAgentResponseVariant1? ChatAgentResponseVariant1 { get; init; }
#else
        public global::G.ChatAgentResponseVariant1? ChatAgentResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAgentResponseVariant1))]
#endif
        public bool IsChatAgentResponseVariant1 => ChatAgentResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatAgentRequest? Request { get; init; }
#else
        public global::G.ChatAgentRequest? Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Request))]
#endif
        public bool IsRequest => Request != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatAgentResponseVariant3? ChatAgentResponseVariant3 { get; init; }
#else
        public global::G.ChatAgentResponseVariant3? ChatAgentResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAgentResponseVariant3))]
#endif
        public bool IsChatAgentResponseVariant3 => ChatAgentResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatAgentResponse(global::G.ChatAgentResponseVariant1 value) => new ChatAgentResponse((global::G.ChatAgentResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatAgentResponseVariant1?(ChatAgentResponse @this) => @this.ChatAgentResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatAgentResponse(global::G.ChatAgentResponseVariant1? value)
        {
            ChatAgentResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatAgentResponse(global::G.ChatAgentRequest value) => new ChatAgentResponse((global::G.ChatAgentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatAgentRequest?(ChatAgentResponse @this) => @this.Request;

        /// <summary>
        /// 
        /// </summary>
        public ChatAgentResponse(global::G.ChatAgentRequest? value)
        {
            Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatAgentResponse(global::G.ChatAgentResponseVariant3 value) => new ChatAgentResponse((global::G.ChatAgentResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatAgentResponseVariant3?(ChatAgentResponse @this) => @this.ChatAgentResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ChatAgentResponse(global::G.ChatAgentResponseVariant3? value)
        {
            ChatAgentResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatAgentResponse(
            global::G.ChatAgentResponseVariant1? chatAgentResponseVariant1,
            global::G.ChatAgentRequest? request,
            global::G.ChatAgentResponseVariant3? chatAgentResponseVariant3
            )
        {
            ChatAgentResponseVariant1 = chatAgentResponseVariant1;
            Request = request;
            ChatAgentResponseVariant3 = chatAgentResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatAgentResponseVariant3 as object ??
            Request as object ??
            ChatAgentResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatAgentResponseVariant1?.ToString() ??
            Request?.ToString() ??
            ChatAgentResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatAgentResponseVariant1 && IsRequest && IsChatAgentResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatAgentResponseVariant1?, TResult>? chatAgentResponseVariant1 = null,
            global::System.Func<global::G.ChatAgentRequest?, TResult>? request = null,
            global::System.Func<global::G.ChatAgentResponseVariant3?, TResult>? chatAgentResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatAgentResponseVariant1 && chatAgentResponseVariant1 != null)
            {
                return chatAgentResponseVariant1(ChatAgentResponseVariant1!);
            }
            else if (IsRequest && request != null)
            {
                return request(Request!);
            }
            else if (IsChatAgentResponseVariant3 && chatAgentResponseVariant3 != null)
            {
                return chatAgentResponseVariant3(ChatAgentResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatAgentResponseVariant1?>? chatAgentResponseVariant1 = null,
            global::System.Action<global::G.ChatAgentRequest?>? request = null,
            global::System.Action<global::G.ChatAgentResponseVariant3?>? chatAgentResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatAgentResponseVariant1)
            {
                chatAgentResponseVariant1?.Invoke(ChatAgentResponseVariant1!);
            }
            else if (IsRequest)
            {
                request?.Invoke(Request!);
            }
            else if (IsChatAgentResponseVariant3)
            {
                chatAgentResponseVariant3?.Invoke(ChatAgentResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatAgentResponseVariant1,
                typeof(global::G.ChatAgentResponseVariant1),
                Request,
                typeof(global::G.ChatAgentRequest),
                ChatAgentResponseVariant3,
                typeof(global::G.ChatAgentResponseVariant3),
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
        public bool Equals(ChatAgentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatAgentResponseVariant1?>.Default.Equals(ChatAgentResponseVariant1, other.ChatAgentResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatAgentRequest?>.Default.Equals(Request, other.Request) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatAgentResponseVariant3?>.Default.Equals(ChatAgentResponseVariant3, other.ChatAgentResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatAgentResponse obj1, ChatAgentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatAgentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatAgentResponse obj1, ChatAgentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatAgentResponse o && Equals(o);
        }
    }
}
