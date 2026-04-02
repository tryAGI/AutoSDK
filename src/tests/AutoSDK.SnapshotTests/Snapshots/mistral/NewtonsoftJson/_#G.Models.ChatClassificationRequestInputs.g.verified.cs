//HintName: G.Models.ChatClassificationRequestInputs.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Chat to classify
    /// </summary>
    public readonly partial struct ChatClassificationRequestInputs : global::System.IEquatable<ChatClassificationRequestInputs>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InstructRequest? InstructRequest { get; init; }
#else
        public global::G.InstructRequest? InstructRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InstructRequest))]
#endif
        public bool IsInstructRequest => InstructRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.InstructRequest>? ChatClassificationRequestInputsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.InstructRequest>? ChatClassificationRequestInputsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatClassificationRequestInputsVariant2))]
#endif
        public bool IsChatClassificationRequestInputsVariant2 => ChatClassificationRequestInputsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatClassificationRequestInputs(global::G.InstructRequest value) => new ChatClassificationRequestInputs((global::G.InstructRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InstructRequest?(ChatClassificationRequestInputs @this) => @this.InstructRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatClassificationRequestInputs(global::G.InstructRequest? value)
        {
            InstructRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatClassificationRequestInputs(
            global::G.InstructRequest? instructRequest,
            global::System.Collections.Generic.IList<global::G.InstructRequest>? chatClassificationRequestInputsVariant2
            )
        {
            InstructRequest = instructRequest;
            ChatClassificationRequestInputsVariant2 = chatClassificationRequestInputsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatClassificationRequestInputsVariant2 as object ??
            InstructRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InstructRequest?.ToString() ??
            ChatClassificationRequestInputsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInstructRequest || IsChatClassificationRequestInputsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InstructRequest?, TResult>? instructRequest = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.InstructRequest>?, TResult>? chatClassificationRequestInputsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInstructRequest && instructRequest != null)
            {
                return instructRequest(InstructRequest!);
            }
            else if (IsChatClassificationRequestInputsVariant2 && chatClassificationRequestInputsVariant2 != null)
            {
                return chatClassificationRequestInputsVariant2(ChatClassificationRequestInputsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InstructRequest?>? instructRequest = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.InstructRequest>?>? chatClassificationRequestInputsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInstructRequest)
            {
                instructRequest?.Invoke(InstructRequest!);
            }
            else if (IsChatClassificationRequestInputsVariant2)
            {
                chatClassificationRequestInputsVariant2?.Invoke(ChatClassificationRequestInputsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InstructRequest,
                typeof(global::G.InstructRequest),
                ChatClassificationRequestInputsVariant2,
                typeof(global::System.Collections.Generic.IList<global::G.InstructRequest>),
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
        public bool Equals(ChatClassificationRequestInputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InstructRequest?>.Default.Equals(InstructRequest, other.InstructRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.InstructRequest>?>.Default.Equals(ChatClassificationRequestInputsVariant2, other.ChatClassificationRequestInputsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatClassificationRequestInputs obj1, ChatClassificationRequestInputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatClassificationRequestInputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatClassificationRequestInputs obj1, ChatClassificationRequestInputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatClassificationRequestInputs o && Equals(o);
        }
    }
}
