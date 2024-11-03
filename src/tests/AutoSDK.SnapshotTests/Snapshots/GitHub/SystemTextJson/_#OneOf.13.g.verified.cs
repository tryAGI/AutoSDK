//HintName: OneOf.13.g.cs
using System.Linq;

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : global::System.IEquatable<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
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
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T1?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T2? Value2 { get; init; }
#else
        public T2? Value2 { get; }
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
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T2?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T3? Value3 { get; init; }
#else
        public T3? Value3 { get; }
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
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T3?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T4? Value4 { get; init; }
#else
        public T4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T4?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T5? Value5 { get; init; }
#else
        public T5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T5?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T6? Value6 { get; init; }
#else
        public T6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T6?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T7? Value7 { get; init; }
#else
        public T7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T7?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T8? Value8 { get; init; }
#else
        public T8? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T8?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T8? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T9? Value9 { get; init; }
#else
        public T9? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T9?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T9? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T10? Value10 { get; init; }
#else
        public T10? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T10?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T10? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T11? Value11 { get; init; }
#else
        public T11? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T11?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T11? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T12? Value12 { get; init; }
#else
        public T12? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T12?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T12? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T13? Value13 { get; init; }
#else
        public T13? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T13?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T13? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OneOf(
            T1? value1,
            T2? value2,
            T3? value3,
            T4? value4,
            T5? value5,
            T6? value6,
            T7? value7,
            T8? value8,
            T9? value9,
            T10? value10,
            T11? value11,
            T12? value12,
            T13? value13
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<T1, TResult>? value1 = null,
            global::System.Func<T2, TResult>? value2 = null,
            global::System.Func<T3, TResult>? value3 = null,
            global::System.Func<T4, TResult>? value4 = null,
            global::System.Func<T5, TResult>? value5 = null,
            global::System.Func<T6, TResult>? value6 = null,
            global::System.Func<T7, TResult>? value7 = null,
            global::System.Func<T8, TResult>? value8 = null,
            global::System.Func<T9, TResult>? value9 = null,
            global::System.Func<T10, TResult>? value10 = null,
            global::System.Func<T11, TResult>? value11 = null,
            global::System.Func<T12, TResult>? value12 = null,
            global::System.Func<T13, TResult>? value13 = null,
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
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<T1>? value1 = null,
            global::System.Action<T2>? value2 = null,
            global::System.Action<T3>? value3 = null,
            global::System.Action<T4>? value4 = null,
            global::System.Action<T5>? value5 = null,
            global::System.Action<T6>? value6 = null,
            global::System.Action<T7>? value7 = null,
            global::System.Action<T8>? value8 = null,
            global::System.Action<T9>? value9 = null,
            global::System.Action<T10>? value10 = null,
            global::System.Action<T11>? value11 = null,
            global::System.Action<T12>? value12 = null,
            global::System.Action<T13>? value13 = null,
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
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
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
                typeof(T1),
                Value2,
                typeof(T2),
                Value3,
                typeof(T3),
                Value4,
                typeof(T4),
                Value5,
                typeof(T5),
                Value6,
                typeof(T6),
                Value7,
                typeof(T7),
                Value8,
                typeof(T8),
                Value9,
                typeof(T9),
                Value10,
                typeof(T10),
                Value11,
                typeof(T11),
                Value12,
                typeof(T12),
                Value13,
                typeof(T13),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<T3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<T4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<T5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<T6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<T7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<T8?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<T9?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<T10?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<T11?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<T12?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<T13?>.Default.Equals(Value13, other.Value13) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> obj1, OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> obj1, OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>),
                jsonSerializerContext) as global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
