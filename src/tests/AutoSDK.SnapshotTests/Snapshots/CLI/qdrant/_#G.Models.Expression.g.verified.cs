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
        public float? ExpressionVariant1 { get; init; }
#else
        public float? ExpressionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressionVariant1))]
#endif
        public bool IsExpressionVariant1 => ExpressionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ExpressionVariant2 { get; init; }
#else
        public string? ExpressionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressionVariant2))]
#endif
        public bool IsExpressionVariant2 => ExpressionVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Condition? Condition { get; init; }
#else
        public global::G.Condition? Condition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Condition))]
#endif
        public bool IsCondition => Condition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GeoDistance? GeoDistance { get; init; }
#else
        public global::G.GeoDistance? GeoDistance { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeoDistance))]
#endif
        public bool IsGeoDistance => GeoDistance != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DatetimeExpression? Datetime { get; init; }
#else
        public global::G.DatetimeExpression? Datetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Datetime))]
#endif
        public bool IsDatetime => Datetime != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DatetimeKeyExpression? DatetimeKey { get; init; }
#else
        public global::G.DatetimeKeyExpression? DatetimeKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeKey))]
#endif
        public bool IsDatetimeKey => DatetimeKey != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MultExpression? Mult { get; init; }
#else
        public global::G.MultExpression? Mult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mult))]
#endif
        public bool IsMult => Mult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SumExpression? Sum { get; init; }
#else
        public global::G.SumExpression? Sum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sum))]
#endif
        public bool IsSum => Sum != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NegExpression? Neg { get; init; }
#else
        public global::G.NegExpression? Neg { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Neg))]
#endif
        public bool IsNeg => Neg != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AbsExpression? Abs { get; init; }
#else
        public global::G.AbsExpression? Abs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Abs))]
#endif
        public bool IsAbs => Abs != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DivExpression? Div { get; init; }
#else
        public global::G.DivExpression? Div { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Div))]
#endif
        public bool IsDiv => Div != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SqrtExpression? Sqrt { get; init; }
#else
        public global::G.SqrtExpression? Sqrt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sqrt))]
#endif
        public bool IsSqrt => Sqrt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PowExpression? Pow { get; init; }
#else
        public global::G.PowExpression? Pow { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pow))]
#endif
        public bool IsPow => Pow != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpExpression? Exp { get; init; }
#else
        public global::G.ExpExpression? Exp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exp))]
#endif
        public bool IsExp => Exp != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Log10Expression? Log10 { get; init; }
#else
        public global::G.Log10Expression? Log10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Log10))]
#endif
        public bool IsLog10 => Log10 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LnExpression? Ln { get; init; }
#else
        public global::G.LnExpression? Ln { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ln))]
#endif
        public bool IsLn => Ln != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LinDecayExpression? LinDecay { get; init; }
#else
        public global::G.LinDecayExpression? LinDecay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LinDecay))]
#endif
        public bool IsLinDecay => LinDecay != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpDecayExpression? ExpDecay { get; init; }
#else
        public global::G.ExpDecayExpression? ExpDecay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpDecay))]
#endif
        public bool IsExpDecay => ExpDecay != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GaussDecayExpression? GaussDecay { get; init; }
#else
        public global::G.GaussDecayExpression? GaussDecay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GaussDecay))]
#endif
        public bool IsGaussDecay => GaussDecay != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(float value) => new Expression((float?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator float?(Expression @this) => @this.ExpressionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Expression(float? value)
        {
            ExpressionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(string value) => new Expression((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Expression @this) => @this.ExpressionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Expression(string? value)
        {
            ExpressionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.Condition value) => new Expression((global::G.Condition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Condition?(Expression @this) => @this.Condition;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.Condition? value)
        {
            Condition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.GeoDistance value) => new Expression((global::G.GeoDistance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeoDistance?(Expression @this) => @this.GeoDistance;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.GeoDistance? value)
        {
            GeoDistance = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.DatetimeExpression value) => new Expression((global::G.DatetimeExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatetimeExpression?(Expression @this) => @this.Datetime;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.DatetimeExpression? value)
        {
            Datetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.DatetimeKeyExpression value) => new Expression((global::G.DatetimeKeyExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatetimeKeyExpression?(Expression @this) => @this.DatetimeKey;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.DatetimeKeyExpression? value)
        {
            DatetimeKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.MultExpression value) => new Expression((global::G.MultExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MultExpression?(Expression @this) => @this.Mult;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.MultExpression? value)
        {
            Mult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.SumExpression value) => new Expression((global::G.SumExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SumExpression?(Expression @this) => @this.Sum;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.SumExpression? value)
        {
            Sum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.NegExpression value) => new Expression((global::G.NegExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NegExpression?(Expression @this) => @this.Neg;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.NegExpression? value)
        {
            Neg = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.AbsExpression value) => new Expression((global::G.AbsExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AbsExpression?(Expression @this) => @this.Abs;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.AbsExpression? value)
        {
            Abs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.DivExpression value) => new Expression((global::G.DivExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DivExpression?(Expression @this) => @this.Div;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.DivExpression? value)
        {
            Div = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.SqrtExpression value) => new Expression((global::G.SqrtExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SqrtExpression?(Expression @this) => @this.Sqrt;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.SqrtExpression? value)
        {
            Sqrt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.PowExpression value) => new Expression((global::G.PowExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PowExpression?(Expression @this) => @this.Pow;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.PowExpression? value)
        {
            Pow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.ExpExpression value) => new Expression((global::G.ExpExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpExpression?(Expression @this) => @this.Exp;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.ExpExpression? value)
        {
            Exp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.Log10Expression value) => new Expression((global::G.Log10Expression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Log10Expression?(Expression @this) => @this.Log10;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.Log10Expression? value)
        {
            Log10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.LnExpression value) => new Expression((global::G.LnExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LnExpression?(Expression @this) => @this.Ln;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.LnExpression? value)
        {
            Ln = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.LinDecayExpression value) => new Expression((global::G.LinDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LinDecayExpression?(Expression @this) => @this.LinDecay;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.LinDecayExpression? value)
        {
            LinDecay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.ExpDecayExpression value) => new Expression((global::G.ExpDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpDecayExpression?(Expression @this) => @this.ExpDecay;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.ExpDecayExpression? value)
        {
            ExpDecay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::G.GaussDecayExpression value) => new Expression((global::G.GaussDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GaussDecayExpression?(Expression @this) => @this.GaussDecay;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::G.GaussDecayExpression? value)
        {
            GaussDecay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Expression(
            float? expressionVariant1,
            string? expressionVariant2,
            global::G.Condition? condition,
            global::G.GeoDistance? geoDistance,
            global::G.DatetimeExpression? datetime,
            global::G.DatetimeKeyExpression? datetimeKey,
            global::G.MultExpression? mult,
            global::G.SumExpression? sum,
            global::G.NegExpression? neg,
            global::G.AbsExpression? abs,
            global::G.DivExpression? div,
            global::G.SqrtExpression? sqrt,
            global::G.PowExpression? pow,
            global::G.ExpExpression? exp,
            global::G.Log10Expression? log10,
            global::G.LnExpression? ln,
            global::G.LinDecayExpression? linDecay,
            global::G.ExpDecayExpression? expDecay,
            global::G.GaussDecayExpression? gaussDecay
            )
        {
            ExpressionVariant1 = expressionVariant1;
            ExpressionVariant2 = expressionVariant2;
            Condition = condition;
            GeoDistance = geoDistance;
            Datetime = datetime;
            DatetimeKey = datetimeKey;
            Mult = mult;
            Sum = sum;
            Neg = neg;
            Abs = abs;
            Div = div;
            Sqrt = sqrt;
            Pow = pow;
            Exp = exp;
            Log10 = log10;
            Ln = ln;
            LinDecay = linDecay;
            ExpDecay = expDecay;
            GaussDecay = gaussDecay;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GaussDecay as object ??
            ExpDecay as object ??
            LinDecay as object ??
            Ln as object ??
            Log10 as object ??
            Exp as object ??
            Pow as object ??
            Sqrt as object ??
            Div as object ??
            Abs as object ??
            Neg as object ??
            Sum as object ??
            Mult as object ??
            DatetimeKey as object ??
            Datetime as object ??
            GeoDistance as object ??
            Condition as object ??
            ExpressionVariant2 as object ??
            ExpressionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExpressionVariant1?.ToString() ??
            ExpressionVariant2?.ToString() ??
            Condition?.ToString() ??
            GeoDistance?.ToString() ??
            Datetime?.ToString() ??
            DatetimeKey?.ToString() ??
            Mult?.ToString() ??
            Sum?.ToString() ??
            Neg?.ToString() ??
            Abs?.ToString() ??
            Div?.ToString() ??
            Sqrt?.ToString() ??
            Pow?.ToString() ??
            Exp?.ToString() ??
            Log10?.ToString() ??
            Ln?.ToString() ??
            LinDecay?.ToString() ??
            ExpDecay?.ToString() ??
            GaussDecay?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExpressionVariant1 || IsExpressionVariant2 || IsCondition || IsGeoDistance || IsDatetime || IsDatetimeKey || IsMult || IsSum || IsNeg || IsAbs || IsDiv || IsSqrt || IsPow || IsExp || IsLog10 || IsLn || IsLinDecay || IsExpDecay || IsGaussDecay;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<float?, TResult>? expressionVariant1 = null,
            global::System.Func<string?, TResult>? expressionVariant2 = null,
            global::System.Func<global::G.Condition?, TResult>? condition = null,
            global::System.Func<global::G.GeoDistance?, TResult>? geoDistance = null,
            global::System.Func<global::G.DatetimeExpression?, TResult>? datetime = null,
            global::System.Func<global::G.DatetimeKeyExpression?, TResult>? datetimeKey = null,
            global::System.Func<global::G.MultExpression?, TResult>? mult = null,
            global::System.Func<global::G.SumExpression?, TResult>? sum = null,
            global::System.Func<global::G.NegExpression?, TResult>? neg = null,
            global::System.Func<global::G.AbsExpression?, TResult>? abs = null,
            global::System.Func<global::G.DivExpression?, TResult>? div = null,
            global::System.Func<global::G.SqrtExpression?, TResult>? sqrt = null,
            global::System.Func<global::G.PowExpression?, TResult>? pow = null,
            global::System.Func<global::G.ExpExpression?, TResult>? exp = null,
            global::System.Func<global::G.Log10Expression?, TResult>? log10 = null,
            global::System.Func<global::G.LnExpression?, TResult>? ln = null,
            global::System.Func<global::G.LinDecayExpression?, TResult>? linDecay = null,
            global::System.Func<global::G.ExpDecayExpression?, TResult>? expDecay = null,
            global::System.Func<global::G.GaussDecayExpression?, TResult>? gaussDecay = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressionVariant1 && expressionVariant1 != null)
            {
                return expressionVariant1(ExpressionVariant1!);
            }
            else if (IsExpressionVariant2 && expressionVariant2 != null)
            {
                return expressionVariant2(ExpressionVariant2!);
            }
            else if (IsCondition && condition != null)
            {
                return condition(Condition!);
            }
            else if (IsGeoDistance && geoDistance != null)
            {
                return geoDistance(GeoDistance!);
            }
            else if (IsDatetime && datetime != null)
            {
                return datetime(Datetime!);
            }
            else if (IsDatetimeKey && datetimeKey != null)
            {
                return datetimeKey(DatetimeKey!);
            }
            else if (IsMult && mult != null)
            {
                return mult(Mult!);
            }
            else if (IsSum && sum != null)
            {
                return sum(Sum!);
            }
            else if (IsNeg && neg != null)
            {
                return neg(Neg!);
            }
            else if (IsAbs && abs != null)
            {
                return abs(Abs!);
            }
            else if (IsDiv && div != null)
            {
                return div(Div!);
            }
            else if (IsSqrt && sqrt != null)
            {
                return sqrt(Sqrt!);
            }
            else if (IsPow && pow != null)
            {
                return pow(Pow!);
            }
            else if (IsExp && exp != null)
            {
                return exp(Exp!);
            }
            else if (IsLog10 && log10 != null)
            {
                return log10(Log10!);
            }
            else if (IsLn && ln != null)
            {
                return ln(Ln!);
            }
            else if (IsLinDecay && linDecay != null)
            {
                return linDecay(LinDecay!);
            }
            else if (IsExpDecay && expDecay != null)
            {
                return expDecay(ExpDecay!);
            }
            else if (IsGaussDecay && gaussDecay != null)
            {
                return gaussDecay(GaussDecay!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<float?>? expressionVariant1 = null,
            global::System.Action<string?>? expressionVariant2 = null,
            global::System.Action<global::G.Condition?>? condition = null,
            global::System.Action<global::G.GeoDistance?>? geoDistance = null,
            global::System.Action<global::G.DatetimeExpression?>? datetime = null,
            global::System.Action<global::G.DatetimeKeyExpression?>? datetimeKey = null,
            global::System.Action<global::G.MultExpression?>? mult = null,
            global::System.Action<global::G.SumExpression?>? sum = null,
            global::System.Action<global::G.NegExpression?>? neg = null,
            global::System.Action<global::G.AbsExpression?>? abs = null,
            global::System.Action<global::G.DivExpression?>? div = null,
            global::System.Action<global::G.SqrtExpression?>? sqrt = null,
            global::System.Action<global::G.PowExpression?>? pow = null,
            global::System.Action<global::G.ExpExpression?>? exp = null,
            global::System.Action<global::G.Log10Expression?>? log10 = null,
            global::System.Action<global::G.LnExpression?>? ln = null,
            global::System.Action<global::G.LinDecayExpression?>? linDecay = null,
            global::System.Action<global::G.ExpDecayExpression?>? expDecay = null,
            global::System.Action<global::G.GaussDecayExpression?>? gaussDecay = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressionVariant1)
            {
                expressionVariant1?.Invoke(ExpressionVariant1!);
            }
            else if (IsExpressionVariant2)
            {
                expressionVariant2?.Invoke(ExpressionVariant2!);
            }
            else if (IsCondition)
            {
                condition?.Invoke(Condition!);
            }
            else if (IsGeoDistance)
            {
                geoDistance?.Invoke(GeoDistance!);
            }
            else if (IsDatetime)
            {
                datetime?.Invoke(Datetime!);
            }
            else if (IsDatetimeKey)
            {
                datetimeKey?.Invoke(DatetimeKey!);
            }
            else if (IsMult)
            {
                mult?.Invoke(Mult!);
            }
            else if (IsSum)
            {
                sum?.Invoke(Sum!);
            }
            else if (IsNeg)
            {
                neg?.Invoke(Neg!);
            }
            else if (IsAbs)
            {
                abs?.Invoke(Abs!);
            }
            else if (IsDiv)
            {
                div?.Invoke(Div!);
            }
            else if (IsSqrt)
            {
                sqrt?.Invoke(Sqrt!);
            }
            else if (IsPow)
            {
                pow?.Invoke(Pow!);
            }
            else if (IsExp)
            {
                exp?.Invoke(Exp!);
            }
            else if (IsLog10)
            {
                log10?.Invoke(Log10!);
            }
            else if (IsLn)
            {
                ln?.Invoke(Ln!);
            }
            else if (IsLinDecay)
            {
                linDecay?.Invoke(LinDecay!);
            }
            else if (IsExpDecay)
            {
                expDecay?.Invoke(ExpDecay!);
            }
            else if (IsGaussDecay)
            {
                gaussDecay?.Invoke(GaussDecay!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExpressionVariant1,
                typeof(float),
                ExpressionVariant2,
                typeof(string),
                Condition,
                typeof(global::G.Condition),
                GeoDistance,
                typeof(global::G.GeoDistance),
                Datetime,
                typeof(global::G.DatetimeExpression),
                DatetimeKey,
                typeof(global::G.DatetimeKeyExpression),
                Mult,
                typeof(global::G.MultExpression),
                Sum,
                typeof(global::G.SumExpression),
                Neg,
                typeof(global::G.NegExpression),
                Abs,
                typeof(global::G.AbsExpression),
                Div,
                typeof(global::G.DivExpression),
                Sqrt,
                typeof(global::G.SqrtExpression),
                Pow,
                typeof(global::G.PowExpression),
                Exp,
                typeof(global::G.ExpExpression),
                Log10,
                typeof(global::G.Log10Expression),
                Ln,
                typeof(global::G.LnExpression),
                LinDecay,
                typeof(global::G.LinDecayExpression),
                ExpDecay,
                typeof(global::G.ExpDecayExpression),
                GaussDecay,
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
                global::System.Collections.Generic.EqualityComparer<float?>.Default.Equals(ExpressionVariant1, other.ExpressionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ExpressionVariant2, other.ExpressionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Condition?>.Default.Equals(Condition, other.Condition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeoDistance?>.Default.Equals(GeoDistance, other.GeoDistance) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatetimeExpression?>.Default.Equals(Datetime, other.Datetime) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatetimeKeyExpression?>.Default.Equals(DatetimeKey, other.DatetimeKey) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MultExpression?>.Default.Equals(Mult, other.Mult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SumExpression?>.Default.Equals(Sum, other.Sum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NegExpression?>.Default.Equals(Neg, other.Neg) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AbsExpression?>.Default.Equals(Abs, other.Abs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DivExpression?>.Default.Equals(Div, other.Div) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SqrtExpression?>.Default.Equals(Sqrt, other.Sqrt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PowExpression?>.Default.Equals(Pow, other.Pow) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExpExpression?>.Default.Equals(Exp, other.Exp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Log10Expression?>.Default.Equals(Log10, other.Log10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LnExpression?>.Default.Equals(Ln, other.Ln) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LinDecayExpression?>.Default.Equals(LinDecay, other.LinDecay) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExpDecayExpression?>.Default.Equals(ExpDecay, other.ExpDecay) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GaussDecayExpression?>.Default.Equals(GaussDecay, other.GaussDecay) 
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
