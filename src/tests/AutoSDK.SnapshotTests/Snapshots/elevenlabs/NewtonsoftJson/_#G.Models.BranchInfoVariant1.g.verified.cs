//HintName: G.Models.BranchInfoVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BranchInfoVariant1 : global::System.IEquatable<BranchInfoVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? BranchReason { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferBranchInfoTrafficSplit? TrafficSplit { get; init; }
#else
        public global::G.TransferBranchInfoTrafficSplit? TrafficSplit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrafficSplit))]
#endif
        public bool IsTrafficSplit => TrafficSplit != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferBranchInfoDefaultingToMain? DefaultingToMain { get; init; }
#else
        public global::G.TransferBranchInfoDefaultingToMain? DefaultingToMain { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DefaultingToMain))]
#endif
        public bool IsDefaultingToMain => DefaultingToMain != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchInfoVariant1(global::G.TransferBranchInfoTrafficSplit value) => new BranchInfoVariant1((global::G.TransferBranchInfoTrafficSplit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferBranchInfoTrafficSplit?(BranchInfoVariant1 @this) => @this.TrafficSplit;

        /// <summary>
        /// 
        /// </summary>
        public BranchInfoVariant1(global::G.TransferBranchInfoTrafficSplit? value)
        {
            TrafficSplit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchInfoVariant1(global::G.TransferBranchInfoDefaultingToMain value) => new BranchInfoVariant1((global::G.TransferBranchInfoDefaultingToMain?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferBranchInfoDefaultingToMain?(BranchInfoVariant1 @this) => @this.DefaultingToMain;

        /// <summary>
        /// 
        /// </summary>
        public BranchInfoVariant1(global::G.TransferBranchInfoDefaultingToMain? value)
        {
            DefaultingToMain = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BranchInfoVariant1(
            global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? branchReason,
            global::G.TransferBranchInfoTrafficSplit? trafficSplit,
            global::G.TransferBranchInfoDefaultingToMain? defaultingToMain
            )
        {
            BranchReason = branchReason;

            TrafficSplit = trafficSplit;
            DefaultingToMain = defaultingToMain;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DefaultingToMain as object ??
            TrafficSplit as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrafficSplit?.ToString() ??
            DefaultingToMain?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrafficSplit && !IsDefaultingToMain || !IsTrafficSplit && IsDefaultingToMain;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TransferBranchInfoTrafficSplit?, TResult>? trafficSplit = null,
            global::System.Func<global::G.TransferBranchInfoDefaultingToMain?, TResult>? defaultingToMain = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrafficSplit && trafficSplit != null)
            {
                return trafficSplit(TrafficSplit!);
            }
            else if (IsDefaultingToMain && defaultingToMain != null)
            {
                return defaultingToMain(DefaultingToMain!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TransferBranchInfoTrafficSplit?>? trafficSplit = null,
            global::System.Action<global::G.TransferBranchInfoDefaultingToMain?>? defaultingToMain = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrafficSplit)
            {
                trafficSplit?.Invoke(TrafficSplit!);
            }
            else if (IsDefaultingToMain)
            {
                defaultingToMain?.Invoke(DefaultingToMain!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrafficSplit,
                typeof(global::G.TransferBranchInfoTrafficSplit),
                DefaultingToMain,
                typeof(global::G.TransferBranchInfoDefaultingToMain),
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
        public bool Equals(BranchInfoVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TransferBranchInfoTrafficSplit?>.Default.Equals(TrafficSplit, other.TrafficSplit) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferBranchInfoDefaultingToMain?>.Default.Equals(DefaultingToMain, other.DefaultingToMain) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BranchInfoVariant1 obj1, BranchInfoVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchInfoVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BranchInfoVariant1 obj1, BranchInfoVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchInfoVariant1 o && Equals(o);
        }
    }
}
