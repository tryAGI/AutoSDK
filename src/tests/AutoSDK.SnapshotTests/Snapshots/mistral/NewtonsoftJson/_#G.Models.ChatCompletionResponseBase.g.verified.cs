//HintName: G.Models.ChatCompletionResponseBase.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionResponseBase : global::System.IEquatable<ChatCompletionResponseBase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseBase? ResponseBase { get; init; }
#else
        public global::G.ResponseBase? ResponseBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBase))]
#endif
        public bool IsResponseBase => ResponseBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionResponseBaseChatCompletionResponseBase1? Base1 { get; init; }
#else
        public global::G.ChatCompletionResponseBaseChatCompletionResponseBase1? Base1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base1))]
#endif
        public bool IsBase1 => Base1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponseBase(global::G.ResponseBase value) => new ChatCompletionResponseBase((global::G.ResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseBase?(ChatCompletionResponseBase @this) => @this.ResponseBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponseBase(global::G.ResponseBase? value)
        {
            ResponseBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponseBase(global::G.ChatCompletionResponseBaseChatCompletionResponseBase1 value) => new ChatCompletionResponseBase((global::G.ChatCompletionResponseBaseChatCompletionResponseBase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionResponseBaseChatCompletionResponseBase1?(ChatCompletionResponseBase @this) => @this.Base1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponseBase(global::G.ChatCompletionResponseBaseChatCompletionResponseBase1? value)
        {
            Base1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponseBase(
            global::G.ResponseBase? responseBase,
            global::G.ChatCompletionResponseBaseChatCompletionResponseBase1? base1
            )
        {
            ResponseBase = responseBase;
            Base1 = base1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base1 as object ??
            ResponseBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseBase?.ToString() ??
            Base1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseBase && IsBase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseBase?, TResult>? responseBase = null,
            global::System.Func<global::G.ChatCompletionResponseBaseChatCompletionResponseBase1?, TResult>? base1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseBase && responseBase != null)
            {
                return responseBase(ResponseBase!);
            }
            else if (IsBase1 && base1 != null)
            {
                return base1(Base1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseBase?>? responseBase = null,
            global::System.Action<global::G.ChatCompletionResponseBaseChatCompletionResponseBase1?>? base1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseBase)
            {
                responseBase?.Invoke(ResponseBase!);
            }
            else if (IsBase1)
            {
                base1?.Invoke(Base1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseBase,
                typeof(global::G.ResponseBase),
                Base1,
                typeof(global::G.ChatCompletionResponseBaseChatCompletionResponseBase1),
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
        public bool Equals(ChatCompletionResponseBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseBase?>.Default.Equals(ResponseBase, other.ResponseBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionResponseBaseChatCompletionResponseBase1?>.Default.Equals(Base1, other.Base1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionResponseBase obj1, ChatCompletionResponseBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionResponseBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionResponseBase obj1, ChatCompletionResponseBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionResponseBase o && Equals(o);
        }
    }
}
