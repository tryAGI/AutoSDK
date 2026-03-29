//HintName: G.Models.OptimizersStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Current state of the collection
    /// </summary>
    public readonly partial struct OptimizersStatus : global::System.IEquatable<OptimizersStatus>
    {
        /// <summary>
        /// Optimizers are reporting as expected
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OptimizersStatusEnum? Value1 { get; init; }
#else
        public global::G.OptimizersStatusEnum? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Something wrong happened with optimizers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OptimizersStatusEnum2? Value2 { get; init; }
#else
        public global::G.OptimizersStatusEnum2? Value2 { get; }
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
        public static implicit operator OptimizersStatus(global::G.OptimizersStatusEnum value) => new OptimizersStatus((global::G.OptimizersStatusEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OptimizersStatusEnum?(OptimizersStatus @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OptimizersStatus(global::G.OptimizersStatusEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OptimizersStatus(global::G.OptimizersStatusEnum2 value) => new OptimizersStatus((global::G.OptimizersStatusEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OptimizersStatusEnum2?(OptimizersStatus @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OptimizersStatus(global::G.OptimizersStatusEnum2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OptimizersStatus(
            global::G.OptimizersStatusEnum? value1,
            global::G.OptimizersStatusEnum2? value2
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
            Value1?.ToValueString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OptimizersStatusEnum?, TResult>? value1 = null,
            global::System.Func<global::G.OptimizersStatusEnum2?, TResult>? value2 = null,
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
            global::System.Action<global::G.OptimizersStatusEnum?>? value1 = null,
            global::System.Action<global::G.OptimizersStatusEnum2?>? value2 = null,
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
                typeof(global::G.OptimizersStatusEnum),
                Value2,
                typeof(global::G.OptimizersStatusEnum2),
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
        public bool Equals(OptimizersStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OptimizersStatusEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OptimizersStatusEnum2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OptimizersStatus obj1, OptimizersStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OptimizersStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OptimizersStatus obj1, OptimizersStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OptimizersStatus o && Equals(o);
        }
    }
}
