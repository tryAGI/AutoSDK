//HintName: G.Models.FunctionToolCallResource.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionToolCallResource : global::System.IEquatable<FunctionToolCallResource>
    {
        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCall? FunctionToolCall { get; init; }
#else
        public global::G.FunctionToolCall? FunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCallResourceVariant2? FunctionToolCallResourceVariant2 { get; init; }
#else
        public global::G.FunctionToolCallResourceVariant2? FunctionToolCallResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallResourceVariant2))]
#endif
        public bool IsFunctionToolCallResourceVariant2 => FunctionToolCallResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionToolCallResource(global::G.FunctionToolCall value) => new FunctionToolCallResource((global::G.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCall?(FunctionToolCallResource @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public FunctionToolCallResource(global::G.FunctionToolCall? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionToolCallResource(global::G.FunctionToolCallResourceVariant2 value) => new FunctionToolCallResource((global::G.FunctionToolCallResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCallResourceVariant2?(FunctionToolCallResource @this) => @this.FunctionToolCallResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FunctionToolCallResource(global::G.FunctionToolCallResourceVariant2? value)
        {
            FunctionToolCallResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionToolCallResource(
            global::G.FunctionToolCall? functionToolCall,
            global::G.FunctionToolCallResourceVariant2? functionToolCallResourceVariant2
            )
        {
            FunctionToolCall = functionToolCall;
            FunctionToolCallResourceVariant2 = functionToolCallResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionToolCallResourceVariant2 as object ??
            FunctionToolCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionToolCall?.ToString() ??
            FunctionToolCallResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionToolCall && IsFunctionToolCallResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::G.FunctionToolCallResourceVariant2?, TResult>? functionToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionToolCallResourceVariant2 && functionToolCallResourceVariant2 != null)
            {
                return functionToolCallResourceVariant2(FunctionToolCallResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::G.FunctionToolCallResourceVariant2?>? functionToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallResourceVariant2)
            {
                functionToolCallResourceVariant2?.Invoke(FunctionToolCallResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionToolCall,
                typeof(global::G.FunctionToolCall),
                FunctionToolCallResourceVariant2,
                typeof(global::G.FunctionToolCallResourceVariant2),
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
        public bool Equals(FunctionToolCallResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCallResourceVariant2?>.Default.Equals(FunctionToolCallResourceVariant2, other.FunctionToolCallResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionToolCallResource obj1, FunctionToolCallResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionToolCallResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionToolCallResource obj1, FunctionToolCallResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionToolCallResource o && Equals(o);
        }
    }
}
