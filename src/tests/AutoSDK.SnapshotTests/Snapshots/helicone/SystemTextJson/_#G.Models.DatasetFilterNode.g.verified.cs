//HintName: G.Models.DatasetFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DatasetFilterNode : global::System.IEquatable<DatasetFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafRequestOrPromptsVersions? PickLeafRequestOrPromptsVersions { get; init; }
#else
        public global::G.PickFilterLeafRequestOrPromptsVersions? PickLeafRequestOrPromptsVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafRequestOrPromptsVersions))]
#endif
        public bool IsPickLeafRequestOrPromptsVersions => PickLeafRequestOrPromptsVersions != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DatasetFilterBranch? Branch { get; init; }
#else
        public global::G.DatasetFilterBranch? Branch { get; }
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
        public global::G.DatasetFilterNodeEnum? Enum { get; init; }
#else
        public global::G.DatasetFilterNodeEnum? Enum { get; }
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
        public static implicit operator DatasetFilterNode(global::G.PickFilterLeafRequestOrPromptsVersions value) => new DatasetFilterNode((global::G.PickFilterLeafRequestOrPromptsVersions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafRequestOrPromptsVersions?(DatasetFilterNode @this) => @this.PickLeafRequestOrPromptsVersions;

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(global::G.PickFilterLeafRequestOrPromptsVersions? value)
        {
            PickLeafRequestOrPromptsVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetFilterNode(global::G.DatasetFilterBranch value) => new DatasetFilterNode((global::G.DatasetFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatasetFilterBranch?(DatasetFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(global::G.DatasetFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetFilterNode(global::G.DatasetFilterNodeEnum value) => new DatasetFilterNode((global::G.DatasetFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatasetFilterNodeEnum?(DatasetFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(global::G.DatasetFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(
            global::G.PickFilterLeafRequestOrPromptsVersions? pickLeafRequestOrPromptsVersions,
            global::G.DatasetFilterBranch? branch,
            global::G.DatasetFilterNodeEnum? @enum
            )
        {
            PickLeafRequestOrPromptsVersions = pickLeafRequestOrPromptsVersions;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafRequestOrPromptsVersions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafRequestOrPromptsVersions?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafRequestOrPromptsVersions || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafRequestOrPromptsVersions?, TResult>? pickLeafRequestOrPromptsVersions = null,
            global::System.Func<global::G.DatasetFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.DatasetFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestOrPromptsVersions && pickLeafRequestOrPromptsVersions != null)
            {
                return pickLeafRequestOrPromptsVersions(PickLeafRequestOrPromptsVersions!);
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
            global::System.Action<global::G.PickFilterLeafRequestOrPromptsVersions?>? pickLeafRequestOrPromptsVersions = null,
            global::System.Action<global::G.DatasetFilterBranch?>? branch = null,
            global::System.Action<global::G.DatasetFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestOrPromptsVersions)
            {
                pickLeafRequestOrPromptsVersions?.Invoke(PickLeafRequestOrPromptsVersions!);
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
                PickLeafRequestOrPromptsVersions,
                typeof(global::G.PickFilterLeafRequestOrPromptsVersions),
                Branch,
                typeof(global::G.DatasetFilterBranch),
                Enum,
                typeof(global::G.DatasetFilterNodeEnum),
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
        public bool Equals(DatasetFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafRequestOrPromptsVersions?>.Default.Equals(PickLeafRequestOrPromptsVersions, other.PickLeafRequestOrPromptsVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatasetFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatasetFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DatasetFilterNode obj1, DatasetFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DatasetFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DatasetFilterNode obj1, DatasetFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DatasetFilterNode o && Equals(o);
        }
    }
}
