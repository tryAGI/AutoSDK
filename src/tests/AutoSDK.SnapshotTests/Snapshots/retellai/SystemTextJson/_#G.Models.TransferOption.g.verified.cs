//HintName: G.Models.TransferOption.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferOption : global::System.IEquatable<TransferOption>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferOptionColdTransfer? ColdTransfer { get; init; }
#else
        public global::G.TransferOptionColdTransfer? ColdTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ColdTransfer))]
#endif
        public bool IsColdTransfer => ColdTransfer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferOptionWarmTransfer? WarmTransfer { get; init; }
#else
        public global::G.TransferOptionWarmTransfer? WarmTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WarmTransfer))]
#endif
        public bool IsWarmTransfer => WarmTransfer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferOptionAgenticWarmTransfer? AgenticWarmTransfer { get; init; }
#else
        public global::G.TransferOptionAgenticWarmTransfer? AgenticWarmTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgenticWarmTransfer))]
#endif
        public bool IsAgenticWarmTransfer => AgenticWarmTransfer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferOption(global::G.TransferOptionColdTransfer value) => new TransferOption((global::G.TransferOptionColdTransfer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferOptionColdTransfer?(TransferOption @this) => @this.ColdTransfer;

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(global::G.TransferOptionColdTransfer? value)
        {
            ColdTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferOption(global::G.TransferOptionWarmTransfer value) => new TransferOption((global::G.TransferOptionWarmTransfer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferOptionWarmTransfer?(TransferOption @this) => @this.WarmTransfer;

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(global::G.TransferOptionWarmTransfer? value)
        {
            WarmTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferOption(global::G.TransferOptionAgenticWarmTransfer value) => new TransferOption((global::G.TransferOptionAgenticWarmTransfer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferOptionAgenticWarmTransfer?(TransferOption @this) => @this.AgenticWarmTransfer;

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(global::G.TransferOptionAgenticWarmTransfer? value)
        {
            AgenticWarmTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferOption(
            global::G.TransferOptionColdTransfer? coldTransfer,
            global::G.TransferOptionWarmTransfer? warmTransfer,
            global::G.TransferOptionAgenticWarmTransfer? agenticWarmTransfer
            )
        {
            ColdTransfer = coldTransfer;
            WarmTransfer = warmTransfer;
            AgenticWarmTransfer = agenticWarmTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgenticWarmTransfer as object ??
            WarmTransfer as object ??
            ColdTransfer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ColdTransfer?.ToString() ??
            WarmTransfer?.ToString() ??
            AgenticWarmTransfer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsColdTransfer && !IsWarmTransfer && !IsAgenticWarmTransfer || !IsColdTransfer && IsWarmTransfer && !IsAgenticWarmTransfer || !IsColdTransfer && !IsWarmTransfer && IsAgenticWarmTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TransferOptionColdTransfer?, TResult>? coldTransfer = null,
            global::System.Func<global::G.TransferOptionWarmTransfer?, TResult>? warmTransfer = null,
            global::System.Func<global::G.TransferOptionAgenticWarmTransfer?, TResult>? agenticWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColdTransfer && coldTransfer != null)
            {
                return coldTransfer(ColdTransfer!);
            }
            else if (IsWarmTransfer && warmTransfer != null)
            {
                return warmTransfer(WarmTransfer!);
            }
            else if (IsAgenticWarmTransfer && agenticWarmTransfer != null)
            {
                return agenticWarmTransfer(AgenticWarmTransfer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TransferOptionColdTransfer?>? coldTransfer = null,
            global::System.Action<global::G.TransferOptionWarmTransfer?>? warmTransfer = null,
            global::System.Action<global::G.TransferOptionAgenticWarmTransfer?>? agenticWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColdTransfer)
            {
                coldTransfer?.Invoke(ColdTransfer!);
            }
            else if (IsWarmTransfer)
            {
                warmTransfer?.Invoke(WarmTransfer!);
            }
            else if (IsAgenticWarmTransfer)
            {
                agenticWarmTransfer?.Invoke(AgenticWarmTransfer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ColdTransfer,
                typeof(global::G.TransferOptionColdTransfer),
                WarmTransfer,
                typeof(global::G.TransferOptionWarmTransfer),
                AgenticWarmTransfer,
                typeof(global::G.TransferOptionAgenticWarmTransfer),
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
        public bool Equals(TransferOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TransferOptionColdTransfer?>.Default.Equals(ColdTransfer, other.ColdTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferOptionWarmTransfer?>.Default.Equals(WarmTransfer, other.WarmTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferOptionAgenticWarmTransfer?>.Default.Equals(AgenticWarmTransfer, other.AgenticWarmTransfer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferOption obj1, TransferOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferOption obj1, TransferOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferOption o && Equals(o);
        }
    }
}
