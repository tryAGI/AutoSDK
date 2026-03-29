//HintName: G.Models.Expression.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Expression : global::System.IEquatable<Expression>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public float? Value1 { get; init; }
#else
        public float? Value1 { get; }
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
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.Condition? Value3 { get; init; }
#else
        public global::G.Condition? Value3 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GeoDistance? Value4 { get; init; }
#else
        public global::G.GeoDistance? Value4 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.DatetimeExpression? Value5 { get; init; }
#else
        public global::G.DatetimeExpression? Value5 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.DatetimeKeyExpression? Value6 { get; init; }
#else
        public global::G.DatetimeKeyExpression? Value6 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.MultExpression? Value7 { get; init; }
#else
        public global::G.MultExpression? Value7 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.SumExpression? Value8 { get; init; }
#else
        public global::G.SumExpression? Value8 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.NegExpression? Value9 { get; init; }
#else
        public global::G.NegExpression? Value9 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AbsExpression? Value10 { get; init; }
#else
        public global::G.AbsExpression? Value10 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.DivExpression? Value11 { get; init; }
#else
        public global::G.DivExpression? Value11 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.SqrtExpression? Value12 { get; init; }
#else
        public global::G.SqrtExpression? Value12 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.PowExpression? Value13 { get; init; }
#else
        public global::G.PowExpression? Value13 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ExpExpression? Value14 { get; init; }
#else
        public global::G.ExpExpression? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Log10Expression? Value15 { get; init; }
#else
        public global::G.Log10Expression? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LnExpression? Value16 { get; init; }
#else
        public global::G.LnExpression? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LinDecayExpression? Value17 { get; init; }
#else
        public global::G.LinDecayExpression? Value17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpDecayExpression? Value18 { get; init; }
#else
        public global::G.ExpDecayExpression? Value18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GaussDecayExpression? Value19 { get; init; }
#else
        public global::G.GaussDecayExpression? Value19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(float value) => new Expression((float?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator float?(Expression @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Expression(float? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(string value) => new Expression((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Expression @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Expression(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.Condition value) => new Expression((global::G.Condition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Condition?(Expression @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.Condition? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.GeoDistance value) => new Expression((global::G.GeoDistance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeoDistance?(Expression @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.GeoDistance? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.DatetimeExpression value) => new Expression((global::G.DatetimeExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatetimeExpression?(Expression @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.DatetimeExpression? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.DatetimeKeyExpression value) => new Expression((global::G.DatetimeKeyExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatetimeKeyExpression?(Expression @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.DatetimeKeyExpression? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.MultExpression value) => new Expression((global::G.MultExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MultExpression?(Expression @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.MultExpression? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.SumExpression value) => new Expression((global::G.SumExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SumExpression?(Expression @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.SumExpression? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.NegExpression value) => new Expression((global::G.NegExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NegExpression?(Expression @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.NegExpression? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.AbsExpression value) => new Expression((global::G.AbsExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AbsExpression?(Expression @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.AbsExpression? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.DivExpression value) => new Expression((global::G.DivExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DivExpression?(Expression @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.DivExpression? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.SqrtExpression value) => new Expression((global::G.SqrtExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SqrtExpression?(Expression @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.SqrtExpression? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.PowExpression value) => new Expression((global::G.PowExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PowExpression?(Expression @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.PowExpression? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.ExpExpression value) => new Expression((global::G.ExpExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpExpression?(Expression @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.ExpExpression? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.Log10Expression value) => new Expression((global::G.Log10Expression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Log10Expression?(Expression @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.Log10Expression? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.LnExpression value) => new Expression((global::G.LnExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LnExpression?(Expression @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.LnExpression? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.LinDecayExpression value) => new Expression((global::G.LinDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LinDecayExpression?(Expression @this) => @this.Value17;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.LinDecayExpression? value)
        {
            Value17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.ExpDecayExpression value) => new Expression((global::G.ExpDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpDecayExpression?(Expression @this) => @this.Value18;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.ExpDecayExpression? value)
        {
            Value18 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.GaussDecayExpression value) => new Expression((global::G.GaussDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GaussDecayExpression?(Expression @this) => @this.Value19;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.GaussDecayExpression? value)
        {
            Value19 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Expression(
            float? value1,
            string? value2,
            global::G.Condition? value3,
            global::G.GeoDistance? value4,
            global::G.DatetimeExpression? value5,
            global::G.DatetimeKeyExpression? value6,
            global::G.MultExpression? value7,
            global::G.SumExpression? value8,
            global::G.NegExpression? value9,
            global::G.AbsExpression? value10,
            global::G.DivExpression? value11,
            global::G.SqrtExpression? value12,
            global::G.PowExpression? value13,
            global::G.ExpExpression? value14,
            global::G.Log10Expression? value15,
            global::G.LnExpression? value16,
            global::G.LinDecayExpression? value17,
            global::G.ExpDecayExpression? value18,
            global::G.GaussDecayExpression? value19
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
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
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() ??
            Value14?.ToString() ??
            Value15?.ToString() ??
            Value16?.ToString() ??
            Value17?.ToString() ??
            Value18?.ToString() ??
            Value19?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13 || IsValue14 || IsValue15 || IsValue16 || IsValue17 || IsValue18 || IsValue19;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<float?, TResult>? value1 = null,
            global::System.Func<string?, TResult>? value2 = null,
            global::System.Func<global::G.Condition?, TResult>? value3 = null,
            global::System.Func<global::G.GeoDistance?, TResult>? value4 = null,
            global::System.Func<global::G.DatetimeExpression?, TResult>? value5 = null,
            global::System.Func<global::G.DatetimeKeyExpression?, TResult>? value6 = null,
            global::System.Func<global::G.MultExpression?, TResult>? value7 = null,
            global::System.Func<global::G.SumExpression?, TResult>? value8 = null,
            global::System.Func<global::G.NegExpression?, TResult>? value9 = null,
            global::System.Func<global::G.AbsExpression?, TResult>? value10 = null,
            global::System.Func<global::G.DivExpression?, TResult>? value11 = null,
            global::System.Func<global::G.SqrtExpression?, TResult>? value12 = null,
            global::System.Func<global::G.PowExpression?, TResult>? value13 = null,
            global::System.Func<global::G.ExpExpression?, TResult>? value14 = null,
            global::System.Func<global::G.Log10Expression?, TResult>? value15 = null,
            global::System.Func<global::G.LnExpression?, TResult>? value16 = null,
            global::System.Func<global::G.LinDecayExpression?, TResult>? value17 = null,
            global::System.Func<global::G.ExpDecayExpression?, TResult>? value18 = null,
            global::System.Func<global::G.GaussDecayExpression?, TResult>? value19 = null,
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
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<float?>? value1 = null,
            global::System.Action<string?>? value2 = null,
            global::System.Action<global::G.Condition?>? value3 = null,
            global::System.Action<global::G.GeoDistance?>? value4 = null,
            global::System.Action<global::G.DatetimeExpression?>? value5 = null,
            global::System.Action<global::G.DatetimeKeyExpression?>? value6 = null,
            global::System.Action<global::G.MultExpression?>? value7 = null,
            global::System.Action<global::G.SumExpression?>? value8 = null,
            global::System.Action<global::G.NegExpression?>? value9 = null,
            global::System.Action<global::G.AbsExpression?>? value10 = null,
            global::System.Action<global::G.DivExpression?>? value11 = null,
            global::System.Action<global::G.SqrtExpression?>? value12 = null,
            global::System.Action<global::G.PowExpression?>? value13 = null,
            global::System.Action<global::G.ExpExpression?>? value14 = null,
            global::System.Action<global::G.Log10Expression?>? value15 = null,
            global::System.Action<global::G.LnExpression?>? value16 = null,
            global::System.Action<global::G.LinDecayExpression?>? value17 = null,
            global::System.Action<global::G.ExpDecayExpression?>? value18 = null,
            global::System.Action<global::G.GaussDecayExpression?>? value19 = null,
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
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
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
                typeof(float),
                Value2,
                typeof(string),
                Value3,
                typeof(global::G.Condition),
                Value4,
                typeof(global::G.GeoDistance),
                Value5,
                typeof(global::G.DatetimeExpression),
                Value6,
                typeof(global::G.DatetimeKeyExpression),
                Value7,
                typeof(global::G.MultExpression),
                Value8,
                typeof(global::G.SumExpression),
                Value9,
                typeof(global::G.NegExpression),
                Value10,
                typeof(global::G.AbsExpression),
                Value11,
                typeof(global::G.DivExpression),
                Value12,
                typeof(global::G.SqrtExpression),
                Value13,
                typeof(global::G.PowExpression),
                Value14,
                typeof(global::G.ExpExpression),
                Value15,
                typeof(global::G.Log10Expression),
                Value16,
                typeof(global::G.LnExpression),
                Value17,
                typeof(global::G.LinDecayExpression),
                Value18,
                typeof(global::G.ExpDecayExpression),
                Value19,
                typeof(global::G.GaussDecayExpression),
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
        public bool Equals(Expression other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<float?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Condition?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeoDistance?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatetimeExpression?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatetimeKeyExpression?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MultExpression?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SumExpression?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NegExpression?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AbsExpression?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DivExpression?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SqrtExpression?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PowExpression?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExpExpression?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Log10Expression?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LnExpression?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LinDecayExpression?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExpDecayExpression?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GaussDecayExpression?>.Default.Equals(Value19, other.Value19) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Expression obj1, Expression obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Expression>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Expression obj1, Expression obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Expression o && Equals(o);
        }
    }
}
