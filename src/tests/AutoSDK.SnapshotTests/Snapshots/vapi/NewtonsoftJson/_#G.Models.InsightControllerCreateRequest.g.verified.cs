//HintName: G.Models.InsightControllerCreateRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InsightControllerCreateRequest : global::System.IEquatable<InsightControllerCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InsightControllerCreateRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateBarInsightFromCallTableDTO? Bar { get; init; }
#else
        public global::G.CreateBarInsightFromCallTableDTO? Bar { get; }
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
        public global::G.CreatePieInsightFromCallTableDTO? Pie { get; init; }
#else
        public global::G.CreatePieInsightFromCallTableDTO? Pie { get; }
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
        public global::G.CreateLineInsightFromCallTableDTO? Line { get; init; }
#else
        public global::G.CreateLineInsightFromCallTableDTO? Line { get; }
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
        public global::G.CreateTextInsightFromCallTableDTO? Text { get; init; }
#else
        public global::G.CreateTextInsightFromCallTableDTO? Text { get; }
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
        public static implicit operator InsightControllerCreateRequest(global::G.CreateBarInsightFromCallTableDTO value) => new InsightControllerCreateRequest((global::G.CreateBarInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateBarInsightFromCallTableDTO?(InsightControllerCreateRequest @this) => @this.Bar;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateRequest(global::G.CreateBarInsightFromCallTableDTO? value)
        {
            Bar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerCreateRequest(global::G.CreatePieInsightFromCallTableDTO value) => new InsightControllerCreateRequest((global::G.CreatePieInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreatePieInsightFromCallTableDTO?(InsightControllerCreateRequest @this) => @this.Pie;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateRequest(global::G.CreatePieInsightFromCallTableDTO? value)
        {
            Pie = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerCreateRequest(global::G.CreateLineInsightFromCallTableDTO value) => new InsightControllerCreateRequest((global::G.CreateLineInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateLineInsightFromCallTableDTO?(InsightControllerCreateRequest @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateRequest(global::G.CreateLineInsightFromCallTableDTO? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerCreateRequest(global::G.CreateTextInsightFromCallTableDTO value) => new InsightControllerCreateRequest((global::G.CreateTextInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextInsightFromCallTableDTO?(InsightControllerCreateRequest @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateRequest(global::G.CreateTextInsightFromCallTableDTO? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateRequest(
            global::G.InsightControllerCreateRequestDiscriminatorType? type,
            global::G.CreateBarInsightFromCallTableDTO? bar,
            global::G.CreatePieInsightFromCallTableDTO? pie,
            global::G.CreateLineInsightFromCallTableDTO? line,
            global::G.CreateTextInsightFromCallTableDTO? text
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
            global::System.Func<global::G.CreateBarInsightFromCallTableDTO?, TResult>? bar = null,
            global::System.Func<global::G.CreatePieInsightFromCallTableDTO?, TResult>? pie = null,
            global::System.Func<global::G.CreateLineInsightFromCallTableDTO?, TResult>? line = null,
            global::System.Func<global::G.CreateTextInsightFromCallTableDTO?, TResult>? text = null,
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
            global::System.Action<global::G.CreateBarInsightFromCallTableDTO?>? bar = null,
            global::System.Action<global::G.CreatePieInsightFromCallTableDTO?>? pie = null,
            global::System.Action<global::G.CreateLineInsightFromCallTableDTO?>? line = null,
            global::System.Action<global::G.CreateTextInsightFromCallTableDTO?>? text = null,
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
                typeof(global::G.CreateBarInsightFromCallTableDTO),
                Pie,
                typeof(global::G.CreatePieInsightFromCallTableDTO),
                Line,
                typeof(global::G.CreateLineInsightFromCallTableDTO),
                Text,
                typeof(global::G.CreateTextInsightFromCallTableDTO),
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
        public bool Equals(InsightControllerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateBarInsightFromCallTableDTO?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreatePieInsightFromCallTableDTO?>.Default.Equals(Pie, other.Pie) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateLineInsightFromCallTableDTO?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextInsightFromCallTableDTO?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InsightControllerCreateRequest obj1, InsightControllerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsightControllerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InsightControllerCreateRequest obj1, InsightControllerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsightControllerCreateRequest o && Equals(o);
        }
    }
}
