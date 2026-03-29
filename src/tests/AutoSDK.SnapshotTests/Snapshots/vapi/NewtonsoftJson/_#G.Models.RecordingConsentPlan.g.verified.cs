//HintName: G.Models.RecordingConsentPlan.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecordingConsentPlan : global::System.IEquatable<RecordingConsentPlan>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompliancePlanRecordingConsentPlanDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RecordingConsentPlanStayOnLine? StayOnLine { get; init; }
#else
        public global::G.RecordingConsentPlanStayOnLine? StayOnLine { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StayOnLine))]
#endif
        public bool IsStayOnLine => StayOnLine != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RecordingConsentPlanVerbal? Verbal { get; init; }
#else
        public global::G.RecordingConsentPlanVerbal? Verbal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Verbal))]
#endif
        public bool IsVerbal => Verbal != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordingConsentPlan(global::G.RecordingConsentPlanStayOnLine value) => new RecordingConsentPlan((global::G.RecordingConsentPlanStayOnLine?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RecordingConsentPlanStayOnLine?(RecordingConsentPlan @this) => @this.StayOnLine;

        /// <summary>
        /// 
        /// </summary>
        public RecordingConsentPlan(global::G.RecordingConsentPlanStayOnLine? value)
        {
            StayOnLine = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordingConsentPlan(global::G.RecordingConsentPlanVerbal value) => new RecordingConsentPlan((global::G.RecordingConsentPlanVerbal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RecordingConsentPlanVerbal?(RecordingConsentPlan @this) => @this.Verbal;

        /// <summary>
        /// 
        /// </summary>
        public RecordingConsentPlan(global::G.RecordingConsentPlanVerbal? value)
        {
            Verbal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordingConsentPlan(
            global::G.CompliancePlanRecordingConsentPlanDiscriminatorType? type,
            global::G.RecordingConsentPlanStayOnLine? stayOnLine,
            global::G.RecordingConsentPlanVerbal? verbal
            )
        {
            Type = type;

            StayOnLine = stayOnLine;
            Verbal = verbal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Verbal as object ??
            StayOnLine as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StayOnLine?.ToString() ??
            Verbal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStayOnLine && !IsVerbal || !IsStayOnLine && IsVerbal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RecordingConsentPlanStayOnLine?, TResult>? stayOnLine = null,
            global::System.Func<global::G.RecordingConsentPlanVerbal?, TResult>? verbal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStayOnLine && stayOnLine != null)
            {
                return stayOnLine(StayOnLine!);
            }
            else if (IsVerbal && verbal != null)
            {
                return verbal(Verbal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RecordingConsentPlanStayOnLine?>? stayOnLine = null,
            global::System.Action<global::G.RecordingConsentPlanVerbal?>? verbal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStayOnLine)
            {
                stayOnLine?.Invoke(StayOnLine!);
            }
            else if (IsVerbal)
            {
                verbal?.Invoke(Verbal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StayOnLine,
                typeof(global::G.RecordingConsentPlanStayOnLine),
                Verbal,
                typeof(global::G.RecordingConsentPlanVerbal),
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
        public bool Equals(RecordingConsentPlan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RecordingConsentPlanStayOnLine?>.Default.Equals(StayOnLine, other.StayOnLine) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RecordingConsentPlanVerbal?>.Default.Equals(Verbal, other.Verbal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecordingConsentPlan obj1, RecordingConsentPlan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecordingConsentPlan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecordingConsentPlan obj1, RecordingConsentPlan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecordingConsentPlan o && Equals(o);
        }
    }
}
