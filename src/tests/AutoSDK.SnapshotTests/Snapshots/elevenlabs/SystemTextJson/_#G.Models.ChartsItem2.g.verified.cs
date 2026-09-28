//HintName: G.Models.ChartsItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChartsItem2 : global::System.IEquatable<ChartsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DashboardCallSuccessChartModel? CallSuccess { get; init; }
#else
        public global::G.DashboardCallSuccessChartModel? CallSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallSuccess))]
#endif
        public bool IsCallSuccess => CallSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCallSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DashboardCallSuccessChartModel? value)
        {
            value = CallSuccess;
            return IsCallSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DashboardCallSuccessChartModel PickCallSuccess() => CallSuccess is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CallSuccess' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DashboardCriteriaChartModel? Criteria { get; init; }
#else
        public global::G.DashboardCriteriaChartModel? Criteria { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Criteria))]
#endif
        public bool IsCriteria => Criteria != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCriteria(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DashboardCriteriaChartModel? value)
        {
            value = Criteria;
            return IsCriteria;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DashboardCriteriaChartModel PickCriteria() => Criteria is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Criteria' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DashboardDataCollectionChartModel? DataCollection { get; init; }
#else
        public global::G.DashboardDataCollectionChartModel? DataCollection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataCollection))]
#endif
        public bool IsDataCollection => DataCollection != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDataCollection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DashboardDataCollectionChartModel? value)
        {
            value = DataCollection;
            return IsDataCollection;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DashboardDataCollectionChartModel PickDataCollection() => DataCollection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DataCollection' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChartsItem2(global::G.DashboardCallSuccessChartModel value) => new ChartsItem2((global::G.DashboardCallSuccessChartModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DashboardCallSuccessChartModel?(ChartsItem2 @this) => @this.CallSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem2(global::G.DashboardCallSuccessChartModel? value)
        {
            CallSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChartsItem2 FromCallSuccess(global::G.DashboardCallSuccessChartModel? value) => new ChartsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChartsItem2(global::G.DashboardCriteriaChartModel value) => new ChartsItem2((global::G.DashboardCriteriaChartModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DashboardCriteriaChartModel?(ChartsItem2 @this) => @this.Criteria;

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem2(global::G.DashboardCriteriaChartModel? value)
        {
            Criteria = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChartsItem2 FromCriteria(global::G.DashboardCriteriaChartModel? value) => new ChartsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChartsItem2(global::G.DashboardDataCollectionChartModel value) => new ChartsItem2((global::G.DashboardDataCollectionChartModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DashboardDataCollectionChartModel?(ChartsItem2 @this) => @this.DataCollection;

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem2(global::G.DashboardDataCollectionChartModel? value)
        {
            DataCollection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChartsItem2 FromDataCollection(global::G.DashboardDataCollectionChartModel? value) => new ChartsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem2(
            global::G.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? type,
            global::G.DashboardCallSuccessChartModel? callSuccess,
            global::G.DashboardCriteriaChartModel? criteria,
            global::G.DashboardDataCollectionChartModel? dataCollection
            )
        {
            Type = type;

            CallSuccess = callSuccess;
            Criteria = criteria;
            DataCollection = dataCollection;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DataCollection as object ??
            Criteria as object ??
            CallSuccess as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CallSuccess?.ToString() ??
            Criteria?.ToString() ??
            DataCollection?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCallSuccess && !IsCriteria && !IsDataCollection || !IsCallSuccess && IsCriteria && !IsDataCollection || !IsCallSuccess && !IsCriteria && IsDataCollection;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.DashboardCallSuccessChartModel, TResult>? callSuccess = null,
            global::System.Func<global::G.DashboardCriteriaChartModel, TResult>? criteria = null,
            global::System.Func<global::G.DashboardDataCollectionChartModel, TResult>? dataCollection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CallSuccess is { } __value0 && callSuccess != null)
            {
                return callSuccess(__value0);
            }
            else if (Criteria is { } __value1 && criteria != null)
            {
                return criteria(__value1);
            }
            else if (DataCollection is { } __value2 && dataCollection != null)
            {
                return dataCollection(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.DashboardCallSuccessChartModel>? callSuccess = null,

            global::System.Action<global::G.DashboardCriteriaChartModel>? criteria = null,

            global::System.Action<global::G.DashboardDataCollectionChartModel>? dataCollection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CallSuccess is { } __value0)
            {
                callSuccess?.Invoke(__value0);
            }
            else if (Criteria is { } __value1)
            {
                criteria?.Invoke(__value1);
            }
            else if (DataCollection is { } __value2)
            {
                dataCollection?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.DashboardCallSuccessChartModel>? callSuccess = null,
            global::System.Action<global::G.DashboardCriteriaChartModel>? criteria = null,
            global::System.Action<global::G.DashboardDataCollectionChartModel>? dataCollection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CallSuccess is { } __value0)
            {
                callSuccess?.Invoke(__value0);
            }
            else if (Criteria is { } __value1)
            {
                criteria?.Invoke(__value1);
            }
            else if (DataCollection is { } __value2)
            {
                dataCollection?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CallSuccess,
                typeof(global::G.DashboardCallSuccessChartModel),
                Criteria,
                typeof(global::G.DashboardCriteriaChartModel),
                DataCollection,
                typeof(global::G.DashboardDataCollectionChartModel),
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
        public bool Equals(ChartsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DashboardCallSuccessChartModel?>.Default.Equals(CallSuccess, other.CallSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DashboardCriteriaChartModel?>.Default.Equals(Criteria, other.Criteria) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DashboardDataCollectionChartModel?>.Default.Equals(DataCollection, other.DataCollection) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChartsItem2 obj1, ChartsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChartsItem2 obj1, ChartsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartsItem2 o && Equals(o);
        }
    }
}
