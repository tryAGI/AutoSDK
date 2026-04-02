//HintName: G.Models.LemurQuestionAnswerParams.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// LeMUR question &amp; answer parameters<br/>
    /// Example: {"transcript_ids":["64nygnr62k-405c-4ae8-8a6b-d90b40ff3cce"],"context":"This is an interview about wildfires.","questions":[{"question":"Where are there wildfires?","answer_format":"List of countries in ISO 3166-1 alpha-2 format","answer_options":["US","CA"]},{"question":"Is global warming affecting wildfires?","answer_options":["yes","no"]}],"final_model":"default","temperature":0,"max_output_size":3000}
    /// </summary>
    public readonly partial struct LemurQuestionAnswerParams : global::System.IEquatable<LemurQuestionAnswerParams>
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
        public global::G.LemurQuestionAnswerParamsVariant2? LemurQuestionAnswerParamsVariant2 { get; init; }
#else
        public global::G.LemurQuestionAnswerParamsVariant2? LemurQuestionAnswerParamsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LemurQuestionAnswerParamsVariant2))]
#endif
        public bool IsLemurQuestionAnswerParamsVariant2 => LemurQuestionAnswerParamsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurQuestionAnswerParams(global::G.LemurBaseParams value) => new LemurQuestionAnswerParams((global::G.LemurBaseParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurBaseParams?(LemurQuestionAnswerParams @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerParams(global::G.LemurBaseParams? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurQuestionAnswerParams(global::G.LemurQuestionAnswerParamsVariant2 value) => new LemurQuestionAnswerParams((global::G.LemurQuestionAnswerParamsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurQuestionAnswerParamsVariant2?(LemurQuestionAnswerParams @this) => @this.LemurQuestionAnswerParamsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerParams(global::G.LemurQuestionAnswerParamsVariant2? value)
        {
            LemurQuestionAnswerParamsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerParams(
            global::G.LemurBaseParams? @base,
            global::G.LemurQuestionAnswerParamsVariant2? lemurQuestionAnswerParamsVariant2
            )
        {
            Base = @base;
            LemurQuestionAnswerParamsVariant2 = lemurQuestionAnswerParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LemurQuestionAnswerParamsVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LemurQuestionAnswerParamsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLemurQuestionAnswerParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurBaseParams?, TResult>? @base = null,
            global::System.Func<global::G.LemurQuestionAnswerParamsVariant2?, TResult>? lemurQuestionAnswerParamsVariant2 = null,
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
            else if (IsLemurQuestionAnswerParamsVariant2 && lemurQuestionAnswerParamsVariant2 != null)
            {
                return lemurQuestionAnswerParamsVariant2(LemurQuestionAnswerParamsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurBaseParams?>? @base = null,
            global::System.Action<global::G.LemurQuestionAnswerParamsVariant2?>? lemurQuestionAnswerParamsVariant2 = null,
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
            else if (IsLemurQuestionAnswerParamsVariant2)
            {
                lemurQuestionAnswerParamsVariant2?.Invoke(LemurQuestionAnswerParamsVariant2!);
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
                LemurQuestionAnswerParamsVariant2,
                typeof(global::G.LemurQuestionAnswerParamsVariant2),
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
        public bool Equals(LemurQuestionAnswerParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurBaseParams?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurQuestionAnswerParamsVariant2?>.Default.Equals(LemurQuestionAnswerParamsVariant2, other.LemurQuestionAnswerParamsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurQuestionAnswerParams obj1, LemurQuestionAnswerParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurQuestionAnswerParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurQuestionAnswerParams obj1, LemurQuestionAnswerParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurQuestionAnswerParams o && Equals(o);
        }
    }
}
