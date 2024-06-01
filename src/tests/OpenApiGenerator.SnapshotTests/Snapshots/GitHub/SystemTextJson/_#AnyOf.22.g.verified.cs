//HintName: AnyOf.22.g.cs
using System.Linq;

#nullable enable

namespace System
{
    public readonly struct AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : global::System.IEquatable<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>
    {
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T1 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T1?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value1;

        public AnyOf(T1? value)
        {
            Value1 = value;
        }

#if NET6_0_OR_GREATER
        public T2? Value2 { get; init; }
#else
        public T2? Value2 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T2 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T2?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value2;

        public AnyOf(T2? value)
        {
            Value2 = value;
        }

#if NET6_0_OR_GREATER
        public T3? Value3 { get; init; }
#else
        public T3? Value3 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T3 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T3?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value3;

        public AnyOf(T3? value)
        {
            Value3 = value;
        }

#if NET6_0_OR_GREATER
        public T4? Value4 { get; init; }
#else
        public T4? Value4 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T4 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T4?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value4;

        public AnyOf(T4? value)
        {
            Value4 = value;
        }

#if NET6_0_OR_GREATER
        public T5? Value5 { get; init; }
#else
        public T5? Value5 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T5 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T5?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value5;

        public AnyOf(T5? value)
        {
            Value5 = value;
        }

#if NET6_0_OR_GREATER
        public T6? Value6 { get; init; }
#else
        public T6? Value6 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T6 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T6?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value6;

        public AnyOf(T6? value)
        {
            Value6 = value;
        }

#if NET6_0_OR_GREATER
        public T7? Value7 { get; init; }
#else
        public T7? Value7 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T7 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T7?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value7;

        public AnyOf(T7? value)
        {
            Value7 = value;
        }

#if NET6_0_OR_GREATER
        public T8? Value8 { get; init; }
#else
        public T8? Value8 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T8 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T8?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value8;

        public AnyOf(T8? value)
        {
            Value8 = value;
        }

#if NET6_0_OR_GREATER
        public T9? Value9 { get; init; }
#else
        public T9? Value9 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T9 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T9?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value9;

        public AnyOf(T9? value)
        {
            Value9 = value;
        }

#if NET6_0_OR_GREATER
        public T10? Value10 { get; init; }
#else
        public T10? Value10 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T10 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T10?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value10;

        public AnyOf(T10? value)
        {
            Value10 = value;
        }

#if NET6_0_OR_GREATER
        public T11? Value11 { get; init; }
#else
        public T11? Value11 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T11 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T11?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value11;

        public AnyOf(T11? value)
        {
            Value11 = value;
        }

#if NET6_0_OR_GREATER
        public T12? Value12 { get; init; }
#else
        public T12? Value12 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T12 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T12?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value12;

        public AnyOf(T12? value)
        {
            Value12 = value;
        }

#if NET6_0_OR_GREATER
        public T13? Value13 { get; init; }
#else
        public T13? Value13 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T13 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T13?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value13;

        public AnyOf(T13? value)
        {
            Value13 = value;
        }

#if NET6_0_OR_GREATER
        public T14? Value14 { get; init; }
#else
        public T14? Value14 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T14 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T14?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value14;

        public AnyOf(T14? value)
        {
            Value14 = value;
        }

#if NET6_0_OR_GREATER
        public T15? Value15 { get; init; }
#else
        public T15? Value15 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T15 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T15?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value15;

        public AnyOf(T15? value)
        {
            Value15 = value;
        }

#if NET6_0_OR_GREATER
        public T16? Value16 { get; init; }
#else
        public T16? Value16 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T16 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T16?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value16;

        public AnyOf(T16? value)
        {
            Value16 = value;
        }

#if NET6_0_OR_GREATER
        public T17? Value17 { get; init; }
#else
        public T17? Value17 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T17 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T17?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value17;

        public AnyOf(T17? value)
        {
            Value17 = value;
        }

#if NET6_0_OR_GREATER
        public T18? Value18 { get; init; }
#else
        public T18? Value18 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T18 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T18?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value18;

        public AnyOf(T18? value)
        {
            Value18 = value;
        }

#if NET6_0_OR_GREATER
        public T19? Value19 { get; init; }
#else
        public T19? Value19 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T19 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T19?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value19;

        public AnyOf(T19? value)
        {
            Value19 = value;
        }

#if NET6_0_OR_GREATER
        public T20? Value20 { get; init; }
#else
        public T20? Value20 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value20))]
#endif
        public bool IsValue20 => Value20 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T20 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T20?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value20;

        public AnyOf(T20? value)
        {
            Value20 = value;
        }

#if NET6_0_OR_GREATER
        public T21? Value21 { get; init; }
#else
        public T21? Value21 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value21))]
#endif
        public bool IsValue21 => Value21 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T21 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T21?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value21;

        public AnyOf(T21? value)
        {
            Value21 = value;
        }

#if NET6_0_OR_GREATER
        public T22? Value22 { get; init; }
#else
        public T22? Value22 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value22))]
#endif
        public bool IsValue22 => Value22 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T22 value) => new AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(value);

        public static implicit operator T22?(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> @this) => @this.Value22;

        public AnyOf(T22? value)
        {
            Value22 = value;
        }

        public AnyOf(
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

            T13? value13,

            T14? value14,

            T15? value15,

            T16? value16,

            T17? value17,

            T18? value18,

            T19? value19,

            T20? value20,

            T21? value21,

            T22? value22
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

            Value14 = value14;

            Value15 = value15;

            Value16 = value16;

            Value17 = value17;

            Value18 = value18;

            Value19 = value19;

            Value20 = value20;

            Value21 = value21;

            Value22 = value22;
        }

        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13 || IsValue14 || IsValue15 || IsValue16 || IsValue17 || IsValue18 || IsValue19 || IsValue20 || IsValue21 || IsValue22;
        }

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

                Value14,
                typeof(T14),

                Value15,
                typeof(T15),

                Value16,
                typeof(T16),

                Value17,
                typeof(T17),

                Value18,
                typeof(T18),

                Value19,
                typeof(T19),

                Value20,
                typeof(T20),

                Value21,
                typeof(T21),

                Value22,
                typeof(T22),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        public bool Equals(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other)
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

                global::System.Collections.Generic.EqualityComparer<T13?>.Default.Equals(Value13, other.Value13) &&

                global::System.Collections.Generic.EqualityComparer<T14?>.Default.Equals(Value14, other.Value14) &&

                global::System.Collections.Generic.EqualityComparer<T15?>.Default.Equals(Value15, other.Value15) &&

                global::System.Collections.Generic.EqualityComparer<T16?>.Default.Equals(Value16, other.Value16) &&

                global::System.Collections.Generic.EqualityComparer<T17?>.Default.Equals(Value17, other.Value17) &&

                global::System.Collections.Generic.EqualityComparer<T18?>.Default.Equals(Value18, other.Value18) &&

                global::System.Collections.Generic.EqualityComparer<T19?>.Default.Equals(Value19, other.Value19) &&

                global::System.Collections.Generic.EqualityComparer<T20?>.Default.Equals(Value20, other.Value20) &&

                global::System.Collections.Generic.EqualityComparer<T21?>.Default.Equals(Value21, other.Value21) &&

                global::System.Collections.Generic.EqualityComparer<T22?>.Default.Equals(Value22, other.Value22) 
                ;
        }

        public static bool operator ==(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> obj1, AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> obj1, AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is AnyOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> o && Equals(o);
        }
    }
}
