//HintName: G.Models.ExperimentFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExperimentFilterNode : global::System.IEquatable<ExperimentFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafExperiment? PickLeaf { get; init; }
#else
        public global::G.PickFilterLeafExperiment? PickLeaf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeaf))]
#endif
        public bool IsPickLeaf => PickLeaf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExperimentFilterBranch? Branch { get; init; }
#else
        public global::G.ExperimentFilterBranch? Branch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExperimentFilterNodeEnum? Enum { get; init; }
#else
        public global::G.ExperimentFilterNodeEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::G.PickFilterLeafExperiment value) => new ExperimentFilterNode((global::G.PickFilterLeafExperiment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafExperiment?(ExperimentFilterNode @this) => @this.PickLeaf;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::G.PickFilterLeafExperiment? value)
        {
            PickLeaf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::G.ExperimentFilterBranch value) => new ExperimentFilterNode((global::G.ExperimentFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExperimentFilterBranch?(ExperimentFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::G.ExperimentFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::G.ExperimentFilterNodeEnum value) => new ExperimentFilterNode((global::G.ExperimentFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExperimentFilterNodeEnum?(ExperimentFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::G.ExperimentFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(
            global::G.PickFilterLeafExperiment? pickLeaf,
            global::G.ExperimentFilterBranch? branch,
            global::G.ExperimentFilterNodeEnum? @enum
            )
        {
            PickLeaf = pickLeaf;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeaf as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeaf?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeaf || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafExperiment?, TResult>? pickLeaf = null,
            global::System.Func<global::G.ExperimentFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.ExperimentFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeaf && pickLeaf != null)
            {
                return pickLeaf(PickLeaf!);
            }
            else if (IsBranch && branch != null)
            {
                return branch(Branch!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PickFilterLeafExperiment?>? pickLeaf = null,
            global::System.Action<global::G.ExperimentFilterBranch?>? branch = null,
            global::System.Action<global::G.ExperimentFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeaf)
            {
                pickLeaf?.Invoke(PickLeaf!);
            }
            else if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PickLeaf,
                typeof(global::G.PickFilterLeafExperiment),
                Branch,
                typeof(global::G.ExperimentFilterBranch),
                Enum,
                typeof(global::G.ExperimentFilterNodeEnum),
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
        public bool Equals(ExperimentFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafExperiment?>.Default.Equals(PickLeaf, other.PickLeaf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExperimentFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExperimentFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExperimentFilterNode obj1, ExperimentFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExperimentFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExperimentFilterNode obj1, ExperimentFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExperimentFilterNode o && Equals(o);
        }
    }
}
