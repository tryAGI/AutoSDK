//HintName: G.Models.InsightControllerRemoveResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InsightControllerRemoveResponse : global::System.IEquatable<InsightControllerRemoveResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InsightControllerRemoveResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BarInsight? Bar { get; init; }
#else
        public global::G.BarInsight? Bar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bar))]
#endif
        public bool IsBar => Bar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PieInsight? Pie { get; init; }
#else
        public global::G.PieInsight? Pie { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pie))]
#endif
        public bool IsPie => Pie != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LineInsight? Line { get; init; }
#else
        public global::G.LineInsight? Line { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Line))]
#endif
        public bool IsLine => Line != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextInsight? Text { get; init; }
#else
        public global::G.TextInsight? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerRemoveResponse(global::G.BarInsight value) => new InsightControllerRemoveResponse((global::G.BarInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BarInsight?(InsightControllerRemoveResponse @this) => @this.Bar;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerRemoveResponse(global::G.BarInsight? value)
        {
            Bar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerRemoveResponse(global::G.PieInsight value) => new InsightControllerRemoveResponse((global::G.PieInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PieInsight?(InsightControllerRemoveResponse @this) => @this.Pie;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerRemoveResponse(global::G.PieInsight? value)
        {
            Pie = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerRemoveResponse(global::G.LineInsight value) => new InsightControllerRemoveResponse((global::G.LineInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LineInsight?(InsightControllerRemoveResponse @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerRemoveResponse(global::G.LineInsight? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerRemoveResponse(global::G.TextInsight value) => new InsightControllerRemoveResponse((global::G.TextInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextInsight?(InsightControllerRemoveResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerRemoveResponse(global::G.TextInsight? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerRemoveResponse(
            global::G.InsightControllerRemoveResponseDiscriminatorType? type,
            global::G.BarInsight? bar,
            global::G.PieInsight? pie,
            global::G.LineInsight? line,
            global::G.TextInsight? text
            )
        {
            Type = type;

            Bar = bar;
            Pie = pie;
            Line = line;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Line as object ??
            Pie as object ??
            Bar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bar?.ToString() ??
            Pie?.ToString() ??
            Line?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBar && !IsPie && !IsLine && !IsText || !IsBar && IsPie && !IsLine && !IsText || !IsBar && !IsPie && IsLine && !IsText || !IsBar && !IsPie && !IsLine && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BarInsight?, TResult>? bar = null,
            global::System.Func<global::G.PieInsight?, TResult>? pie = null,
            global::System.Func<global::G.LineInsight?, TResult>? line = null,
            global::System.Func<global::G.TextInsight?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBar && bar != null)
            {
                return bar(Bar!);
            }
            else if (IsPie && pie != null)
            {
                return pie(Pie!);
            }
            else if (IsLine && line != null)
            {
                return line(Line!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BarInsight?>? bar = null,
            global::System.Action<global::G.PieInsight?>? pie = null,
            global::System.Action<global::G.LineInsight?>? line = null,
            global::System.Action<global::G.TextInsight?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBar)
            {
                bar?.Invoke(Bar!);
            }
            else if (IsPie)
            {
                pie?.Invoke(Pie!);
            }
            else if (IsLine)
            {
                line?.Invoke(Line!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bar,
                typeof(global::G.BarInsight),
                Pie,
                typeof(global::G.PieInsight),
                Line,
                typeof(global::G.LineInsight),
                Text,
                typeof(global::G.TextInsight),
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
        public bool Equals(InsightControllerRemoveResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BarInsight?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PieInsight?>.Default.Equals(Pie, other.Pie) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LineInsight?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextInsight?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InsightControllerRemoveResponse obj1, InsightControllerRemoveResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsightControllerRemoveResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InsightControllerRemoveResponse obj1, InsightControllerRemoveResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsightControllerRemoveResponse o && Equals(o);
        }
    }
}
