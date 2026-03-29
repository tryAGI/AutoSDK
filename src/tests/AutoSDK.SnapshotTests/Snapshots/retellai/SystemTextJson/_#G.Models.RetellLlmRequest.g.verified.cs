//HintName: G.Models.RetellLlmRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RetellLlmRequest : global::System.IEquatable<RetellLlmRequest>
    {
        /// <summary>
        /// Override properties for Retell LLM configuration in agent override requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RetellLlmOverride? Value1 { get; init; }
#else
        public global::G.RetellLlmOverride? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RetellLlmRequestVariant2? Value2 { get; init; }
#else
        public global::G.RetellLlmRequestVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLlmRequest(global::G.RetellLlmOverride value) => new RetellLlmRequest((global::G.RetellLlmOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLlmOverride?(RetellLlmRequest @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RetellLlmRequest(global::G.RetellLlmOverride? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLlmRequest(global::G.RetellLlmRequestVariant2 value) => new RetellLlmRequest((global::G.RetellLlmRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLlmRequestVariant2?(RetellLlmRequest @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RetellLlmRequest(global::G.RetellLlmRequestVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetellLlmRequest(
            global::G.RetellLlmOverride? value1,
            global::G.RetellLlmRequestVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RetellLlmOverride?, TResult>? value1 = null,
            global::System.Func<global::G.RetellLlmRequestVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RetellLlmOverride?>? value1 = null,
            global::System.Action<global::G.RetellLlmRequestVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.RetellLlmOverride),
                Value2,
                typeof(global::G.RetellLlmRequestVariant2),
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
        public bool Equals(RetellLlmRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLlmOverride?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLlmRequestVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RetellLlmRequest obj1, RetellLlmRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RetellLlmRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RetellLlmRequest obj1, RetellLlmRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RetellLlmRequest o && Equals(o);
        }
    }
}
