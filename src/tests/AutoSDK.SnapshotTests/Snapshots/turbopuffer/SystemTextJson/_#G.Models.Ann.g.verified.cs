//HintName: G.Models.Ann.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to create an approximate nearest neighbor index for the attribute. Can be a boolean or a detailed configuration object.
    /// </summary>
    public readonly partial struct Ann : global::System.IEquatable<Ann>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? AnnVariant1 { get; init; }
#else
        public bool? AnnVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnnVariant1))]
#endif
        public bool IsAnnVariant1 => AnnVariant1 != null;

        /// <summary>
        /// Configuration options for ANN (Approximate Nearest Neighbor) indexing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnnConfig? Config { get; init; }
#else
        public global::G.AnnConfig? Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Ann(bool value) => new Ann((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(Ann @this) => @this.AnnVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Ann(bool? value)
        {
            AnnVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Ann(global::G.AnnConfig value) => new Ann((global::G.AnnConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnnConfig?(Ann @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public Ann(global::G.AnnConfig? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Ann(
            bool? annVariant1,
            global::G.AnnConfig? config
            )
        {
            AnnVariant1 = annVariant1;
            Config = config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Config as object ??
            AnnVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnnVariant1?.ToString().ToLowerInvariant() ??
            Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnnVariant1 && !IsConfig || !IsAnnVariant1 && IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? annVariant1 = null,
            global::System.Func<global::G.AnnConfig?, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnVariant1 && annVariant1 != null)
            {
                return annVariant1(AnnVariant1!);
            }
            else if (IsConfig && config != null)
            {
                return config(Config!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? annVariant1 = null,
            global::System.Action<global::G.AnnConfig?>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnVariant1)
            {
                annVariant1?.Invoke(AnnVariant1!);
            }
            else if (IsConfig)
            {
                config?.Invoke(Config!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnnVariant1,
                typeof(bool),
                Config,
                typeof(global::G.AnnConfig),
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
        public bool Equals(Ann other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(AnnVariant1, other.AnnVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnnConfig?>.Default.Equals(Config, other.Config) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Ann obj1, Ann obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Ann>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Ann obj1, Ann obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Ann o && Equals(o);
        }
    }
}
