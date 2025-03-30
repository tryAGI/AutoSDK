//HintName: G.Models.EntitiesItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EntitiesItem : global::System.IEquatable<EntitiesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.TenantShareTokensResponseEntitieDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TenantShareRunToken? Run { get; init; }
#else
        public global::G.TenantShareRunToken? Run { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Run))]
#endif
        public bool IsRun => Run != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EntitiesItem(global::G.TenantShareRunToken value) => new EntitiesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TenantShareRunToken?(EntitiesItem @this) => @this.Run;

        /// <summary>
        /// 
        /// </summary>
        public EntitiesItem(global::G.TenantShareRunToken? value)
        {
            Run = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TenantShareDatasetToken? Dataset { get; init; }
#else
        public global::G.TenantShareDatasetToken? Dataset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dataset))]
#endif
        public bool IsDataset => Dataset != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EntitiesItem(global::G.TenantShareDatasetToken value) => new EntitiesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TenantShareDatasetToken?(EntitiesItem @this) => @this.Dataset;

        /// <summary>
        /// 
        /// </summary>
        public EntitiesItem(global::G.TenantShareDatasetToken? value)
        {
            Dataset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EntitiesItem(
            global::G.TenantShareTokensResponseEntitieDiscriminatorType? type,
            global::G.TenantShareRunToken? run,
            global::G.TenantShareDatasetToken? dataset
            )
        {
            Type = type;

            Run = run;
            Dataset = dataset;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dataset as object ??
            Run as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Run?.ToString() ??
            Dataset?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRun && !IsDataset || !IsRun && IsDataset;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TenantShareRunToken?, TResult>? run = null,
            global::System.Func<global::G.TenantShareDatasetToken?, TResult>? dataset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRun && run != null)
            {
                return run(Run!);
            }
            else if (IsDataset && dataset != null)
            {
                return dataset(Dataset!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TenantShareRunToken?>? run = null,
            global::System.Action<global::G.TenantShareDatasetToken?>? dataset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Run,
                typeof(global::G.TenantShareRunToken),
                Dataset,
                typeof(global::G.TenantShareDatasetToken),
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
        public bool Equals(EntitiesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TenantShareRunToken?>.Default.Equals(Run, other.Run) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TenantShareDatasetToken?>.Default.Equals(Dataset, other.Dataset) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EntitiesItem obj1, EntitiesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EntitiesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EntitiesItem obj1, EntitiesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EntitiesItem o && Equals(o);
        }
    }
}
