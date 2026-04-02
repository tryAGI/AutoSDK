//HintName: G.Models.LemurActionItemsParams.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// LeMUR action items parameters<br/>
    /// Example: {"transcript_ids":["64nygnr62k-405c-4ae8-8a6b-d90b40ff3cce"],"context":"This is an interview about wildfires.","answer_format":"Bullet Points","final_model":"default","temperature":0,"max_output_size":3000}
    /// </summary>
    public readonly partial struct LemurActionItemsParams : global::System.IEquatable<LemurActionItemsParams>
    {
        /// <summary>
        /// LeMUR base parameters<br/>
        /// Example: {"transcript_ids":["85f9b381-e90c-46ed-beca-7d76245d375e","7c3acd18-df4d-4432-88f5-1e89f8827eea"],"context":"This is an interview about wildfires.","final_model":"default","temperature":0,"max_output_size":3000}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurBaseParams? Base { get; init; }
#else
        public global::G.LemurBaseParams? Base { get; }
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
#if NET6_0_OR_GREATER
        public global::G.LemurActionItemsParamsVariant2? LemurActionItemsParamsVariant2 { get; init; }
#else
        public global::G.LemurActionItemsParamsVariant2? LemurActionItemsParamsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LemurActionItemsParamsVariant2))]
#endif
        public bool IsLemurActionItemsParamsVariant2 => LemurActionItemsParamsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurActionItemsParams(global::G.LemurBaseParams value) => new LemurActionItemsParams((global::G.LemurBaseParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurBaseParams?(LemurActionItemsParams @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LemurActionItemsParams(global::G.LemurBaseParams? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurActionItemsParams(global::G.LemurActionItemsParamsVariant2 value) => new LemurActionItemsParams((global::G.LemurActionItemsParamsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurActionItemsParamsVariant2?(LemurActionItemsParams @this) => @this.LemurActionItemsParamsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LemurActionItemsParams(global::G.LemurActionItemsParamsVariant2? value)
        {
            LemurActionItemsParamsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurActionItemsParams(
            global::G.LemurBaseParams? @base,
            global::G.LemurActionItemsParamsVariant2? lemurActionItemsParamsVariant2
            )
        {
            Base = @base;
            LemurActionItemsParamsVariant2 = lemurActionItemsParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LemurActionItemsParamsVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LemurActionItemsParamsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLemurActionItemsParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurBaseParams?, TResult>? @base = null,
            global::System.Func<global::G.LemurActionItemsParamsVariant2?, TResult>? lemurActionItemsParamsVariant2 = null,
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
            else if (IsLemurActionItemsParamsVariant2 && lemurActionItemsParamsVariant2 != null)
            {
                return lemurActionItemsParamsVariant2(LemurActionItemsParamsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurBaseParams?>? @base = null,
            global::System.Action<global::G.LemurActionItemsParamsVariant2?>? lemurActionItemsParamsVariant2 = null,
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
            else if (IsLemurActionItemsParamsVariant2)
            {
                lemurActionItemsParamsVariant2?.Invoke(LemurActionItemsParamsVariant2!);
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
                typeof(global::G.LemurBaseParams),
                LemurActionItemsParamsVariant2,
                typeof(global::G.LemurActionItemsParamsVariant2),
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
        public bool Equals(LemurActionItemsParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurBaseParams?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurActionItemsParamsVariant2?>.Default.Equals(LemurActionItemsParamsVariant2, other.LemurActionItemsParamsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurActionItemsParams obj1, LemurActionItemsParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurActionItemsParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurActionItemsParams obj1, LemurActionItemsParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurActionItemsParams o && Equals(o);
        }
    }
}
