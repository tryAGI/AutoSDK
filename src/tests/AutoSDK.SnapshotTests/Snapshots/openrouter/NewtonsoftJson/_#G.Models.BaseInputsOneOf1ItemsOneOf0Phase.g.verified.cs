//HintName: G.Models.BaseInputsOneOf1ItemsOneOf0Phase.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf0Phase : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf0Phase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseInputsOneOf1ItemsOneOf0Phase0? BaseInputsOneOf1ItemsOneOf0Phase0 { get; init; }
#else
        public global::G.BaseInputsOneOf1ItemsOneOf0Phase0? BaseInputsOneOf1ItemsOneOf0Phase0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf0Phase0))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf0Phase0 => BaseInputsOneOf1ItemsOneOf0Phase0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseInputsOneOf1ItemsOneOf0Phase1? BaseInputsOneOf1ItemsOneOf0Phase1 { get; init; }
#else
        public global::G.BaseInputsOneOf1ItemsOneOf0Phase1? BaseInputsOneOf1ItemsOneOf0Phase1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1ItemsOneOf0Phase1))]
#endif
        public bool IsBaseInputsOneOf1ItemsOneOf0Phase1 => BaseInputsOneOf1ItemsOneOf0Phase1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf0Phase(global::G.BaseInputsOneOf1ItemsOneOf0Phase0 value) => new BaseInputsOneOf1ItemsOneOf0Phase((global::G.BaseInputsOneOf1ItemsOneOf0Phase0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseInputsOneOf1ItemsOneOf0Phase0?(BaseInputsOneOf1ItemsOneOf0Phase @this) => @this.BaseInputsOneOf1ItemsOneOf0Phase0;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0Phase(global::G.BaseInputsOneOf1ItemsOneOf0Phase0? value)
        {
            BaseInputsOneOf1ItemsOneOf0Phase0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf0Phase(global::G.BaseInputsOneOf1ItemsOneOf0Phase1 value) => new BaseInputsOneOf1ItemsOneOf0Phase((global::G.BaseInputsOneOf1ItemsOneOf0Phase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseInputsOneOf1ItemsOneOf0Phase1?(BaseInputsOneOf1ItemsOneOf0Phase @this) => @this.BaseInputsOneOf1ItemsOneOf0Phase1;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0Phase(global::G.BaseInputsOneOf1ItemsOneOf0Phase1? value)
        {
            BaseInputsOneOf1ItemsOneOf0Phase1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0Phase(
            global::G.BaseInputsOneOf1ItemsOneOf0Phase0? baseInputsOneOf1ItemsOneOf0Phase0,
            global::G.BaseInputsOneOf1ItemsOneOf0Phase1? baseInputsOneOf1ItemsOneOf0Phase1,
            object? value3
            )
        {
            BaseInputsOneOf1ItemsOneOf0Phase0 = baseInputsOneOf1ItemsOneOf0Phase0;
            BaseInputsOneOf1ItemsOneOf0Phase1 = baseInputsOneOf1ItemsOneOf0Phase1;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            BaseInputsOneOf1ItemsOneOf0Phase1 as object ??
            BaseInputsOneOf1ItemsOneOf0Phase0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsOneOf1ItemsOneOf0Phase0?.ToValueString() ??
            BaseInputsOneOf1ItemsOneOf0Phase1?.ToValueString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsOneOf1ItemsOneOf0Phase0 && !IsBaseInputsOneOf1ItemsOneOf0Phase1 && !IsValue3 || !IsBaseInputsOneOf1ItemsOneOf0Phase0 && IsBaseInputsOneOf1ItemsOneOf0Phase1 && !IsValue3 || !IsBaseInputsOneOf1ItemsOneOf0Phase0 && !IsBaseInputsOneOf1ItemsOneOf0Phase1 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseInputsOneOf1ItemsOneOf0Phase0?, TResult>? baseInputsOneOf1ItemsOneOf0Phase0 = null,
            global::System.Func<global::G.BaseInputsOneOf1ItemsOneOf0Phase1?, TResult>? baseInputsOneOf1ItemsOneOf0Phase1 = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf0Phase0 && baseInputsOneOf1ItemsOneOf0Phase0 != null)
            {
                return baseInputsOneOf1ItemsOneOf0Phase0(BaseInputsOneOf1ItemsOneOf0Phase0!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf0Phase1 && baseInputsOneOf1ItemsOneOf0Phase1 != null)
            {
                return baseInputsOneOf1ItemsOneOf0Phase1(BaseInputsOneOf1ItemsOneOf0Phase1!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseInputsOneOf1ItemsOneOf0Phase0?>? baseInputsOneOf1ItemsOneOf0Phase0 = null,
            global::System.Action<global::G.BaseInputsOneOf1ItemsOneOf0Phase1?>? baseInputsOneOf1ItemsOneOf0Phase1 = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1ItemsOneOf0Phase0)
            {
                baseInputsOneOf1ItemsOneOf0Phase0?.Invoke(BaseInputsOneOf1ItemsOneOf0Phase0!);
            }
            else if (IsBaseInputsOneOf1ItemsOneOf0Phase1)
            {
                baseInputsOneOf1ItemsOneOf0Phase1?.Invoke(BaseInputsOneOf1ItemsOneOf0Phase1!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseInputsOneOf1ItemsOneOf0Phase0,
                typeof(global::G.BaseInputsOneOf1ItemsOneOf0Phase0),
                BaseInputsOneOf1ItemsOneOf0Phase1,
                typeof(global::G.BaseInputsOneOf1ItemsOneOf0Phase1),
                Value3,
                typeof(object),
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf0Phase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseInputsOneOf1ItemsOneOf0Phase0?>.Default.Equals(BaseInputsOneOf1ItemsOneOf0Phase0, other.BaseInputsOneOf1ItemsOneOf0Phase0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BaseInputsOneOf1ItemsOneOf0Phase1?>.Default.Equals(BaseInputsOneOf1ItemsOneOf0Phase1, other.BaseInputsOneOf1ItemsOneOf0Phase1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf0Phase obj1, BaseInputsOneOf1ItemsOneOf0Phase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf0Phase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf0Phase obj1, BaseInputsOneOf1ItemsOneOf0Phase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf0Phase o && Equals(o);
        }
    }
}
