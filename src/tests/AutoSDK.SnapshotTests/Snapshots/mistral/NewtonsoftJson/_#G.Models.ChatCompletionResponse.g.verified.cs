//HintName: G.Models.ChatCompletionResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionResponse : global::System.IEquatable<ChatCompletionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionResponseBase? Base { get; init; }
#else
        public global::G.ChatCompletionResponseBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionResponseChatCompletionResponse1? Response1 { get; init; }
#else
        public global::G.ChatCompletionResponseChatCompletionResponse1? Response1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response1))]
#endif
        public bool IsResponse1 => Response1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponse(global::G.ChatCompletionResponseBase value) => new ChatCompletionResponse((global::G.ChatCompletionResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionResponseBase?(ChatCompletionResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponse(global::G.ChatCompletionResponseBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponse(global::G.ChatCompletionResponseChatCompletionResponse1 value) => new ChatCompletionResponse((global::G.ChatCompletionResponseChatCompletionResponse1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionResponseChatCompletionResponse1?(ChatCompletionResponse @this) => @this.Response1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponse(global::G.ChatCompletionResponseChatCompletionResponse1? value)
        {
            Response1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponse(
            global::G.ChatCompletionResponseBase? @base,
            global::G.ChatCompletionResponseChatCompletionResponse1? response1
            )
        {
            Base = @base;
            Response1 = response1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Response1 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Response1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsResponse1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionResponseBase?, TResult>? @base = null,
            global::System.Func<global::G.ChatCompletionResponseChatCompletionResponse1?, TResult>? response1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsResponse1 && response1 != null)
            {
                return response1(Response1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionResponseBase?>? @base = null,
            global::System.Action<global::G.ChatCompletionResponseChatCompletionResponse1?>? response1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsResponse1)
            {
                response1?.Invoke(Response1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.ChatCompletionResponseBase),
                Response1,
                typeof(global::G.ChatCompletionResponseChatCompletionResponse1),
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
        public bool Equals(ChatCompletionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionResponseBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionResponseChatCompletionResponse1?>.Default.Equals(Response1, other.Response1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionResponse obj1, ChatCompletionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionResponse obj1, ChatCompletionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionResponse o && Equals(o);
        }
    }
}
