//HintName: G.Models.PromptsFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptsFilterNode : global::System.IEquatable<PromptsFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafPromptV2? PickLeafPromptV2 { get; init; }
#else
        public global::G.PickFilterLeafPromptV2? PickLeafPromptV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafPromptV2))]
#endif
        public bool IsPickLeafPromptV2 => PickLeafPromptV2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptsFilterBranch? Branch { get; init; }
#else
        public global::G.PromptsFilterBranch? Branch { get; }
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
        public global::G.PromptsFilterNodeEnum? Enum { get; init; }
#else
        public global::G.PromptsFilterNodeEnum? Enum { get; }
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
        public static implicit operator PromptsFilterNode(global::G.PickFilterLeafPromptV2 value) => new PromptsFilterNode((global::G.PickFilterLeafPromptV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafPromptV2?(PromptsFilterNode @this) => @this.PickLeafPromptV2;

        /// <summary>
        /// 
        /// </summary>
        public PromptsFilterNode(global::G.PickFilterLeafPromptV2? value)
        {
            PickLeafPromptV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptsFilterNode(global::G.PromptsFilterBranch value) => new PromptsFilterNode((global::G.PromptsFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptsFilterBranch?(PromptsFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public PromptsFilterNode(global::G.PromptsFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptsFilterNode(global::G.PromptsFilterNodeEnum value) => new PromptsFilterNode((global::G.PromptsFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptsFilterNodeEnum?(PromptsFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public PromptsFilterNode(global::G.PromptsFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptsFilterNode(
            global::G.PickFilterLeafPromptV2? pickLeafPromptV2,
            global::G.PromptsFilterBranch? branch,
            global::G.PromptsFilterNodeEnum? @enum
            )
        {
            PickLeafPromptV2 = pickLeafPromptV2;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafPromptV2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafPromptV2?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafPromptV2 || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafPromptV2?, TResult>? pickLeafPromptV2 = null,
            global::System.Func<global::G.PromptsFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.PromptsFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafPromptV2 && pickLeafPromptV2 != null)
            {
                return pickLeafPromptV2(PickLeafPromptV2!);
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
            global::System.Action<global::G.PickFilterLeafPromptV2?>? pickLeafPromptV2 = null,
            global::System.Action<global::G.PromptsFilterBranch?>? branch = null,
            global::System.Action<global::G.PromptsFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafPromptV2)
            {
                pickLeafPromptV2?.Invoke(PickLeafPromptV2!);
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
                PickLeafPromptV2,
                typeof(global::G.PickFilterLeafPromptV2),
                Branch,
                typeof(global::G.PromptsFilterBranch),
                Enum,
                typeof(global::G.PromptsFilterNodeEnum),
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
        public bool Equals(PromptsFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafPromptV2?>.Default.Equals(PickLeafPromptV2, other.PickLeafPromptV2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptsFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptsFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptsFilterNode obj1, PromptsFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptsFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptsFilterNode obj1, PromptsFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptsFilterNode o && Equals(o);
        }
    }
}
