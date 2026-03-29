//HintName: G.Models.InsightControllerUpdateRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InsightControllerUpdateRequest : global::System.IEquatable<InsightControllerUpdateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InsightControllerUpdateRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateBarInsightFromCallTableDTO? Bar { get; init; }
#else
        public global::G.UpdateBarInsightFromCallTableDTO? Bar { get; }
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
        public global::G.UpdatePieInsightFromCallTableDTO? Pie { get; init; }
#else
        public global::G.UpdatePieInsightFromCallTableDTO? Pie { get; }
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
        public global::G.UpdateLineInsightFromCallTableDTO? Line { get; init; }
#else
        public global::G.UpdateLineInsightFromCallTableDTO? Line { get; }
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
        public global::G.UpdateTextInsightFromCallTableDTO? Text { get; init; }
#else
        public global::G.UpdateTextInsightFromCallTableDTO? Text { get; }
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
        public static implicit operator InsightControllerUpdateRequest(global::G.UpdateBarInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::G.UpdateBarInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateBarInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Bar;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::G.UpdateBarInsightFromCallTableDTO? value)
        {
            Bar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::G.UpdatePieInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::G.UpdatePieInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdatePieInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Pie;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::G.UpdatePieInsightFromCallTableDTO? value)
        {
            Pie = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::G.UpdateLineInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::G.UpdateLineInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateLineInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::G.UpdateLineInsightFromCallTableDTO? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::G.UpdateTextInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::G.UpdateTextInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateTextInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::G.UpdateTextInsightFromCallTableDTO? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(
            global::G.InsightControllerUpdateRequestDiscriminatorType? type,
            global::G.UpdateBarInsightFromCallTableDTO? bar,
            global::G.UpdatePieInsightFromCallTableDTO? pie,
            global::G.UpdateLineInsightFromCallTableDTO? line,
            global::G.UpdateTextInsightFromCallTableDTO? text
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
            global::System.Func<global::G.UpdateBarInsightFromCallTableDTO?, TResult>? bar = null,
            global::System.Func<global::G.UpdatePieInsightFromCallTableDTO?, TResult>? pie = null,
            global::System.Func<global::G.UpdateLineInsightFromCallTableDTO?, TResult>? line = null,
            global::System.Func<global::G.UpdateTextInsightFromCallTableDTO?, TResult>? text = null,
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
            global::System.Action<global::G.UpdateBarInsightFromCallTableDTO?>? bar = null,
            global::System.Action<global::G.UpdatePieInsightFromCallTableDTO?>? pie = null,
            global::System.Action<global::G.UpdateLineInsightFromCallTableDTO?>? line = null,
            global::System.Action<global::G.UpdateTextInsightFromCallTableDTO?>? text = null,
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
                typeof(global::G.UpdateBarInsightFromCallTableDTO),
                Pie,
                typeof(global::G.UpdatePieInsightFromCallTableDTO),
                Line,
                typeof(global::G.UpdateLineInsightFromCallTableDTO),
                Text,
                typeof(global::G.UpdateTextInsightFromCallTableDTO),
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
        public bool Equals(InsightControllerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateBarInsightFromCallTableDTO?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdatePieInsightFromCallTableDTO?>.Default.Equals(Pie, other.Pie) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateLineInsightFromCallTableDTO?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateTextInsightFromCallTableDTO?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InsightControllerUpdateRequest obj1, InsightControllerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsightControllerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InsightControllerUpdateRequest obj1, InsightControllerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsightControllerUpdateRequest o && Equals(o);
        }
    }
}
