//HintName: G.Models.LemurTaskParams.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// LeMUR task parameters<br/>
    /// Example: {"transcript_ids":["64nygnr62k-405c-4ae8-8a6b-d90b40ff3cce"],"prompt":"List all the locations affected by wildfires.","context":"This is an interview about wildfires.","final_model":"default","temperature":0,"max_output_size":3000}
    /// </summary>
    public readonly partial struct LemurTaskParams : global::System.IEquatable<LemurTaskParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurTaskParamsVariant1? LemurTaskParamsVariant1 { get; init; }
#else
        public global::G.LemurTaskParamsVariant1? LemurTaskParamsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LemurTaskParamsVariant1))]
#endif
        public bool IsLemurTaskParamsVariant1 => LemurTaskParamsVariant1 != null;

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
        public static implicit operator LemurTaskParams(global::G.LemurTaskParamsVariant1 value) => new LemurTaskParams((global::G.LemurTaskParamsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurTaskParamsVariant1?(LemurTaskParams @this) => @this.LemurTaskParamsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LemurTaskParams(global::G.LemurTaskParamsVariant1? value)
        {
            LemurTaskParamsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurTaskParams(global::G.LemurBaseParams value) => new LemurTaskParams((global::G.LemurBaseParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurBaseParams?(LemurTaskParams @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LemurTaskParams(global::G.LemurBaseParams? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurTaskParams(
            global::G.LemurTaskParamsVariant1? lemurTaskParamsVariant1,
            global::G.LemurBaseParams? @base
            )
        {
            LemurTaskParamsVariant1 = lemurTaskParamsVariant1;
            Base = @base;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object ??
            LemurTaskParamsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LemurTaskParamsVariant1?.ToString() ??
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLemurTaskParamsVariant1 && IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurTaskParamsVariant1?, TResult>? lemurTaskParamsVariant1 = null,
            global::System.Func<global::G.LemurBaseParams?, TResult>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLemurTaskParamsVariant1 && lemurTaskParamsVariant1 != null)
            {
                return lemurTaskParamsVariant1(LemurTaskParamsVariant1!);
            }
            else if (IsBase && @base != null)
            {
                return @base(Base!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurTaskParamsVariant1?>? lemurTaskParamsVariant1 = null,
            global::System.Action<global::G.LemurBaseParams?>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLemurTaskParamsVariant1)
            {
                lemurTaskParamsVariant1?.Invoke(LemurTaskParamsVariant1!);
            }
            else if (IsBase)
            {
                @base?.Invoke(Base!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LemurTaskParamsVariant1,
                typeof(global::G.LemurTaskParamsVariant1),
                Base,
                typeof(global::G.LemurBaseParams),
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
        public bool Equals(LemurTaskParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurTaskParamsVariant1?>.Default.Equals(LemurTaskParamsVariant1, other.LemurTaskParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurBaseParams?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurTaskParams obj1, LemurTaskParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurTaskParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurTaskParams obj1, LemurTaskParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurTaskParams o && Equals(o);
        }
    }
}
