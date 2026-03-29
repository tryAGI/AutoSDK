//HintName: G.Models.FineTuneChatCompletionRequestFunctionMessage.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FineTuneChatCompletionRequestFunctionMessage : global::System.IEquatable<FineTuneChatCompletionRequestFunctionMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FunctionMessage1 { get; init; }
#else
        public object? FunctionMessage1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionMessage1))]
#endif
        public bool IsFunctionMessage1 => FunctionMessage1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionRequestFunctionMessage? FunctionMessage2 { get; init; }
#else
        public global::G.ChatCompletionRequestFunctionMessage? FunctionMessage2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionMessage2))]
#endif
        public bool IsFunctionMessage2 => FunctionMessage2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FineTuneChatCompletionRequestFunctionMessage(global::G.ChatCompletionRequestFunctionMessage value) => new FineTuneChatCompletionRequestFunctionMessage((global::G.ChatCompletionRequestFunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionRequestFunctionMessage?(FineTuneChatCompletionRequestFunctionMessage @this) => @this.FunctionMessage2;

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestFunctionMessage(global::G.ChatCompletionRequestFunctionMessage? value)
        {
            FunctionMessage2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestFunctionMessage(
            object? functionMessage1,
            global::G.ChatCompletionRequestFunctionMessage? functionMessage2
            )
        {
            FunctionMessage1 = functionMessage1;
            FunctionMessage2 = functionMessage2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionMessage2 as object ??
            FunctionMessage1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionMessage1?.ToString() ??
            FunctionMessage2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionMessage1 && IsFunctionMessage2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? functionMessage1 = null,
            global::System.Func<global::G.ChatCompletionRequestFunctionMessage?, TResult>? functionMessage2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionMessage1 && functionMessage1 != null)
            {
                return functionMessage1(FunctionMessage1!);
            }
            else if (IsFunctionMessage2 && functionMessage2 != null)
            {
                return functionMessage2(FunctionMessage2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? functionMessage1 = null,
            global::System.Action<global::G.ChatCompletionRequestFunctionMessage?>? functionMessage2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionMessage1)
            {
                functionMessage1?.Invoke(FunctionMessage1!);
            }
            else if (IsFunctionMessage2)
            {
                functionMessage2?.Invoke(FunctionMessage2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionMessage1,
                typeof(object),
                FunctionMessage2,
                typeof(global::G.ChatCompletionRequestFunctionMessage),
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
        public bool Equals(FineTuneChatCompletionRequestFunctionMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FunctionMessage1, other.FunctionMessage1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionRequestFunctionMessage?>.Default.Equals(FunctionMessage2, other.FunctionMessage2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FineTuneChatCompletionRequestFunctionMessage obj1, FineTuneChatCompletionRequestFunctionMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FineTuneChatCompletionRequestFunctionMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FineTuneChatCompletionRequestFunctionMessage obj1, FineTuneChatCompletionRequestFunctionMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FineTuneChatCompletionRequestFunctionMessage o && Equals(o);
        }
    }
}
