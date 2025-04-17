//HintName: G.Models.DataItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem2 : global::System.IEquatable<DataItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelListDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseModelCard? Base { get; init; }
#else
        public global::G.BaseModelCard? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::G.BaseModelCard value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseModelCard?(DataItem2 @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::G.BaseModelCard? value)
        {
            Base = value;
        }

        /// <summary>
        /// Extra fields for fine-tuned models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FTModelCard? FineTuned { get; init; }
#else
        public global::G.FTModelCard? FineTuned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FineTuned))]
#endif
        public bool IsFineTuned => FineTuned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::G.FTModelCard value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FTModelCard?(DataItem2 @this) => @this.FineTuned;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::G.FTModelCard? value)
        {
            FineTuned = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(
            global::G.ModelListDataItemDiscriminatorType? type,
            global::G.BaseModelCard? @base,
            global::G.FTModelCard? fineTuned
            )
        {
            Type = type;

            Base = @base;
            FineTuned = fineTuned;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FineTuned as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FineTuned?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && !IsFineTuned || !IsBase && IsFineTuned;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseModelCard?, TResult>? @base = null,
            global::System.Func<global::G.FTModelCard?, TResult>? fineTuned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsFineTuned && fineTuned != null)
            {
                return fineTuned(FineTuned!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseModelCard?>? @base = null,
            global::System.Action<global::G.FTModelCard?>? fineTuned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsFineTuned)
            {
                fineTuned?.Invoke(FineTuned!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.BaseModelCard),
                FineTuned,
                typeof(global::G.FTModelCard),
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
        public bool Equals(DataItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseModelCard?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FTModelCard?>.Default.Equals(FineTuned, other.FineTuned) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem2 obj1, DataItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem2 obj1, DataItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem2 o && Equals(o);
        }
    }
}
