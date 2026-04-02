//HintName: G.Models.RetellLLMResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RetellLLMResponse : global::System.IEquatable<RetellLLMResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RetellLLMResponseVariant1? RetellLLMResponseVariant1 { get; init; }
#else
        public global::G.RetellLLMResponseVariant1? RetellLLMResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetellLLMResponseVariant1))]
#endif
        public bool IsRetellLLMResponseVariant1 => RetellLLMResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RetellLlmRequest? LlmRequest { get; init; }
#else
        public global::G.RetellLlmRequest? LlmRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LlmRequest))]
#endif
        public bool IsLlmRequest => LlmRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RetellLLMResponseVariant3? RetellLLMResponseVariant3 { get; init; }
#else
        public global::G.RetellLLMResponseVariant3? RetellLLMResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetellLLMResponseVariant3))]
#endif
        public bool IsRetellLLMResponseVariant3 => RetellLLMResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLLMResponse(global::G.RetellLLMResponseVariant1 value) => new RetellLLMResponse((global::G.RetellLLMResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLLMResponseVariant1?(RetellLLMResponse @this) => @this.RetellLLMResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RetellLLMResponse(global::G.RetellLLMResponseVariant1? value)
        {
            RetellLLMResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLLMResponse(global::G.RetellLlmRequest value) => new RetellLLMResponse((global::G.RetellLlmRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLlmRequest?(RetellLLMResponse @this) => @this.LlmRequest;

        /// <summary>
        /// 
        /// </summary>
        public RetellLLMResponse(global::G.RetellLlmRequest? value)
        {
            LlmRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLLMResponse(global::G.RetellLLMResponseVariant3 value) => new RetellLLMResponse((global::G.RetellLLMResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLLMResponseVariant3?(RetellLLMResponse @this) => @this.RetellLLMResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public RetellLLMResponse(global::G.RetellLLMResponseVariant3? value)
        {
            RetellLLMResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetellLLMResponse(
            global::G.RetellLLMResponseVariant1? retellLLMResponseVariant1,
            global::G.RetellLlmRequest? llmRequest,
            global::G.RetellLLMResponseVariant3? retellLLMResponseVariant3
            )
        {
            RetellLLMResponseVariant1 = retellLLMResponseVariant1;
            LlmRequest = llmRequest;
            RetellLLMResponseVariant3 = retellLLMResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RetellLLMResponseVariant3 as object ??
            LlmRequest as object ??
            RetellLLMResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RetellLLMResponseVariant1?.ToString() ??
            LlmRequest?.ToString() ??
            RetellLLMResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRetellLLMResponseVariant1 && IsLlmRequest && IsRetellLLMResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RetellLLMResponseVariant1?, TResult>? retellLLMResponseVariant1 = null,
            global::System.Func<global::G.RetellLlmRequest?, TResult>? llmRequest = null,
            global::System.Func<global::G.RetellLLMResponseVariant3?, TResult>? retellLLMResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRetellLLMResponseVariant1 && retellLLMResponseVariant1 != null)
            {
                return retellLLMResponseVariant1(RetellLLMResponseVariant1!);
            }
            else if (IsLlmRequest && llmRequest != null)
            {
                return llmRequest(LlmRequest!);
            }
            else if (IsRetellLLMResponseVariant3 && retellLLMResponseVariant3 != null)
            {
                return retellLLMResponseVariant3(RetellLLMResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RetellLLMResponseVariant1?>? retellLLMResponseVariant1 = null,
            global::System.Action<global::G.RetellLlmRequest?>? llmRequest = null,
            global::System.Action<global::G.RetellLLMResponseVariant3?>? retellLLMResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRetellLLMResponseVariant1)
            {
                retellLLMResponseVariant1?.Invoke(RetellLLMResponseVariant1!);
            }
            else if (IsLlmRequest)
            {
                llmRequest?.Invoke(LlmRequest!);
            }
            else if (IsRetellLLMResponseVariant3)
            {
                retellLLMResponseVariant3?.Invoke(RetellLLMResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RetellLLMResponseVariant1,
                typeof(global::G.RetellLLMResponseVariant1),
                LlmRequest,
                typeof(global::G.RetellLlmRequest),
                RetellLLMResponseVariant3,
                typeof(global::G.RetellLLMResponseVariant3),
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
        public bool Equals(RetellLLMResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLLMResponseVariant1?>.Default.Equals(RetellLLMResponseVariant1, other.RetellLLMResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLlmRequest?>.Default.Equals(LlmRequest, other.LlmRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLLMResponseVariant3?>.Default.Equals(RetellLLMResponseVariant3, other.RetellLLMResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RetellLLMResponse obj1, RetellLLMResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RetellLLMResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RetellLLMResponse obj1, RetellLLMResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RetellLLMResponse o && Equals(o);
        }
    }
}
