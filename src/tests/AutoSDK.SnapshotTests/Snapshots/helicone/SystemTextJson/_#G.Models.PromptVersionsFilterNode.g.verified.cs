//HintName: G.Models.PromptVersionsFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptVersionsFilterNode : global::System.IEquatable<PromptVersionsFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafPromptsVersions? PickLeafPrompts { get; init; }
#else
        public global::G.PickFilterLeafPromptsVersions? PickLeafPrompts { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafPrompts))]
#endif
        public bool IsPickLeafPrompts => PickLeafPrompts != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptVersionsFilterBranch? Branch { get; init; }
#else
        public global::G.PromptVersionsFilterBranch? Branch { get; }
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
        public global::G.PromptVersionsFilterNodeEnum? Enum { get; init; }
#else
        public global::G.PromptVersionsFilterNodeEnum? Enum { get; }
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
        public static implicit operator PromptVersionsFilterNode(global::G.PickFilterLeafPromptsVersions value) => new PromptVersionsFilterNode((global::G.PickFilterLeafPromptsVersions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafPromptsVersions?(PromptVersionsFilterNode @this) => @this.PickLeafPrompts;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(global::G.PickFilterLeafPromptsVersions? value)
        {
            PickLeafPrompts = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::G.PromptVersionsFilterBranch value) => new PromptVersionsFilterNode((global::G.PromptVersionsFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptVersionsFilterBranch?(PromptVersionsFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(global::G.PromptVersionsFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::G.PromptVersionsFilterNodeEnum value) => new PromptVersionsFilterNode((global::G.PromptVersionsFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptVersionsFilterNodeEnum?(PromptVersionsFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(global::G.PromptVersionsFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(
            global::G.PickFilterLeafPromptsVersions? pickLeafPrompts,
            global::G.PromptVersionsFilterBranch? branch,
            global::G.PromptVersionsFilterNodeEnum? @enum
            )
        {
            PickLeafPrompts = pickLeafPrompts;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafPrompts as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafPrompts?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafPrompts || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafPromptsVersions?, TResult>? pickLeafPrompts = null,
            global::System.Func<global::G.PromptVersionsFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.PromptVersionsFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafPrompts && pickLeafPrompts != null)
            {
                return pickLeafPrompts(PickLeafPrompts!);
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
            global::System.Action<global::G.PickFilterLeafPromptsVersions?>? pickLeafPrompts = null,
            global::System.Action<global::G.PromptVersionsFilterBranch?>? branch = null,
            global::System.Action<global::G.PromptVersionsFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafPrompts)
            {
                pickLeafPrompts?.Invoke(PickLeafPrompts!);
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
                PickLeafPrompts,
                typeof(global::G.PickFilterLeafPromptsVersions),
                Branch,
                typeof(global::G.PromptVersionsFilterBranch),
                Enum,
                typeof(global::G.PromptVersionsFilterNodeEnum),
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
        public bool Equals(PromptVersionsFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafPromptsVersions?>.Default.Equals(PickLeafPrompts, other.PickLeafPrompts) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptVersionsFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptVersionsFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptVersionsFilterNode obj1, PromptVersionsFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptVersionsFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptVersionsFilterNode obj1, PromptVersionsFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptVersionsFilterNode o && Equals(o);
        }
    }
}
