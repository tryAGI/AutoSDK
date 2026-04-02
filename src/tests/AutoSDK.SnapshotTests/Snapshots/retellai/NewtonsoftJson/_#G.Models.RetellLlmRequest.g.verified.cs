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
        public global::G.RetellLlmOverride? Override { get; init; }
#else
        public global::G.RetellLlmOverride? Override { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Override))]
#endif
        public bool IsOverride => Override != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RetellLlmRequestVariant2? RetellLlmRequestVariant2 { get; init; }
#else
        public global::G.RetellLlmRequestVariant2? RetellLlmRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetellLlmRequestVariant2))]
#endif
        public bool IsRetellLlmRequestVariant2 => RetellLlmRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLlmRequest(global::G.RetellLlmOverride value) => new RetellLlmRequest((global::G.RetellLlmOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLlmOverride?(RetellLlmRequest @this) => @this.Override;

        /// <summary>
        /// 
        /// </summary>
        public RetellLlmRequest(global::G.RetellLlmOverride? value)
        {
            Override = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetellLlmRequest(global::G.RetellLlmRequestVariant2 value) => new RetellLlmRequest((global::G.RetellLlmRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RetellLlmRequestVariant2?(RetellLlmRequest @this) => @this.RetellLlmRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RetellLlmRequest(global::G.RetellLlmRequestVariant2? value)
        {
            RetellLlmRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetellLlmRequest(
            global::G.RetellLlmOverride? @override,
            global::G.RetellLlmRequestVariant2? retellLlmRequestVariant2
            )
        {
            Override = @override;
            RetellLlmRequestVariant2 = retellLlmRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RetellLlmRequestVariant2 as object ??
            Override as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Override?.ToString() ??
            RetellLlmRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOverride && IsRetellLlmRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RetellLlmOverride?, TResult>? @override = null,
            global::System.Func<global::G.RetellLlmRequestVariant2?, TResult>? retellLlmRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOverride && @override != null)
            {
                return @override(Override!);
            }
            else if (IsRetellLlmRequestVariant2 && retellLlmRequestVariant2 != null)
            {
                return retellLlmRequestVariant2(RetellLlmRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RetellLlmOverride?>? @override = null,
            global::System.Action<global::G.RetellLlmRequestVariant2?>? retellLlmRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOverride)
            {
                @override?.Invoke(Override!);
            }
            else if (IsRetellLlmRequestVariant2)
            {
                retellLlmRequestVariant2?.Invoke(RetellLlmRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Override,
                typeof(global::G.RetellLlmOverride),
                RetellLlmRequestVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLlmOverride?>.Default.Equals(Override, other.Override) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RetellLlmRequestVariant2?>.Default.Equals(RetellLlmRequestVariant2, other.RetellLlmRequestVariant2) 
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
