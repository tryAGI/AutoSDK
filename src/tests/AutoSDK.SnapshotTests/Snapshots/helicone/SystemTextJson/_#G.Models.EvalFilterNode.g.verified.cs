//HintName: G.Models.EvalFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalFilterNode : global::System.IEquatable<EvalFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafRequestResponseRmt? PickLeafRequestResponseRmt { get; init; }
#else
        public global::G.PickFilterLeafRequestResponseRmt? PickLeafRequestResponseRmt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafRequestResponseRmt))]
#endif
        public bool IsPickLeafRequestResponseRmt => PickLeafRequestResponseRmt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EvalFilterBranch? Branch { get; init; }
#else
        public global::G.EvalFilterBranch? Branch { get; }
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
        public global::G.EvalFilterNodeEnum? Enum { get; init; }
#else
        public global::G.EvalFilterNodeEnum? Enum { get; }
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
        public static implicit operator EvalFilterNode(global::G.PickFilterLeafRequestResponseRmt value) => new EvalFilterNode((global::G.PickFilterLeafRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafRequestResponseRmt?(EvalFilterNode @this) => @this.PickLeafRequestResponseRmt;

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(global::G.PickFilterLeafRequestResponseRmt? value)
        {
            PickLeafRequestResponseRmt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalFilterNode(global::G.EvalFilterBranch value) => new EvalFilterNode((global::G.EvalFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EvalFilterBranch?(EvalFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(global::G.EvalFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalFilterNode(global::G.EvalFilterNodeEnum value) => new EvalFilterNode((global::G.EvalFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EvalFilterNodeEnum?(EvalFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(global::G.EvalFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(
            global::G.PickFilterLeafRequestResponseRmt? pickLeafRequestResponseRmt,
            global::G.EvalFilterBranch? branch,
            global::G.EvalFilterNodeEnum? @enum
            )
        {
            PickLeafRequestResponseRmt = pickLeafRequestResponseRmt;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafRequestResponseRmt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafRequestResponseRmt?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafRequestResponseRmt || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafRequestResponseRmt?, TResult>? pickLeafRequestResponseRmt = null,
            global::System.Func<global::G.EvalFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.EvalFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestResponseRmt && pickLeafRequestResponseRmt != null)
            {
                return pickLeafRequestResponseRmt(PickLeafRequestResponseRmt!);
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
            global::System.Action<global::G.PickFilterLeafRequestResponseRmt?>? pickLeafRequestResponseRmt = null,
            global::System.Action<global::G.EvalFilterBranch?>? branch = null,
            global::System.Action<global::G.EvalFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestResponseRmt)
            {
                pickLeafRequestResponseRmt?.Invoke(PickLeafRequestResponseRmt!);
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
                PickLeafRequestResponseRmt,
                typeof(global::G.PickFilterLeafRequestResponseRmt),
                Branch,
                typeof(global::G.EvalFilterBranch),
                Enum,
                typeof(global::G.EvalFilterNodeEnum),
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
        public bool Equals(EvalFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafRequestResponseRmt?>.Default.Equals(PickLeafRequestResponseRmt, other.PickLeafRequestResponseRmt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EvalFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EvalFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalFilterNode obj1, EvalFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalFilterNode obj1, EvalFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalFilterNode o && Equals(o);
        }
    }
}
