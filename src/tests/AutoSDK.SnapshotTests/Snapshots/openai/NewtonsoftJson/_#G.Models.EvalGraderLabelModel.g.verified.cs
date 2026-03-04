//HintName: G.Models.EvalGraderLabelModel.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderLabelModel : global::System.IEquatable<EvalGraderLabelModel>
    {
        /// <summary>
        /// A LabelModelGrader object which uses a model to assign labels to each item<br/>
        /// in the evaluation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraderLabelModel? LabelModelGrader { get; init; }
#else
        public global::G.GraderLabelModel? LabelModelGrader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabelModelGrader))]
#endif
        public bool IsLabelModelGrader => LabelModelGrader != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderLabelModel(global::G.GraderLabelModel value) => new EvalGraderLabelModel((global::G.GraderLabelModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraderLabelModel?(EvalGraderLabelModel @this) => @this.LabelModelGrader;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderLabelModel(global::G.GraderLabelModel? value)
        {
            LabelModelGrader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LabelModelGrader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LabelModelGrader?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabelModelGrader;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GraderLabelModel?, TResult>? labelModelGrader = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabelModelGrader && labelModelGrader != null)
            {
                return labelModelGrader(LabelModelGrader!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GraderLabelModel?>? labelModelGrader = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabelModelGrader)
            {
                labelModelGrader?.Invoke(LabelModelGrader!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabelModelGrader,
                typeof(global::G.GraderLabelModel),
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
        public bool Equals(EvalGraderLabelModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GraderLabelModel?>.Default.Equals(LabelModelGrader, other.LabelModelGrader) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderLabelModel obj1, EvalGraderLabelModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderLabelModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderLabelModel obj1, EvalGraderLabelModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderLabelModel o && Equals(o);
        }
    }
}
