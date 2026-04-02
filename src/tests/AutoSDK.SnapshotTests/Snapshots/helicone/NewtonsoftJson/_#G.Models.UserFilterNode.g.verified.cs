//HintName: G.Models.UserFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UserFilterNode : global::System.IEquatable<UserFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafUsersViewOrRequestResponseRmt? PickLeafUsersViewOrRequestResponseRmt { get; init; }
#else
        public global::G.PickFilterLeafUsersViewOrRequestResponseRmt? PickLeafUsersViewOrRequestResponseRmt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafUsersViewOrRequestResponseRmt))]
#endif
        public bool IsPickLeafUsersViewOrRequestResponseRmt => PickLeafUsersViewOrRequestResponseRmt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserFilterBranch? Branch { get; init; }
#else
        public global::G.UserFilterBranch? Branch { get; }
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
        public global::G.UserFilterNodeEnum? Enum { get; init; }
#else
        public global::G.UserFilterNodeEnum? Enum { get; }
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
        public static implicit operator UserFilterNode(global::G.PickFilterLeafUsersViewOrRequestResponseRmt value) => new UserFilterNode((global::G.PickFilterLeafUsersViewOrRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafUsersViewOrRequestResponseRmt?(UserFilterNode @this) => @this.PickLeafUsersViewOrRequestResponseRmt;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::G.PickFilterLeafUsersViewOrRequestResponseRmt? value)
        {
            PickLeafUsersViewOrRequestResponseRmt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::G.UserFilterBranch value) => new UserFilterNode((global::G.UserFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserFilterBranch?(UserFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::G.UserFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::G.UserFilterNodeEnum value) => new UserFilterNode((global::G.UserFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserFilterNodeEnum?(UserFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::G.UserFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(
            global::G.PickFilterLeafUsersViewOrRequestResponseRmt? pickLeafUsersViewOrRequestResponseRmt,
            global::G.UserFilterBranch? branch,
            global::G.UserFilterNodeEnum? @enum
            )
        {
            PickLeafUsersViewOrRequestResponseRmt = pickLeafUsersViewOrRequestResponseRmt;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafUsersViewOrRequestResponseRmt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafUsersViewOrRequestResponseRmt?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafUsersViewOrRequestResponseRmt || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafUsersViewOrRequestResponseRmt?, TResult>? pickLeafUsersViewOrRequestResponseRmt = null,
            global::System.Func<global::G.UserFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.UserFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafUsersViewOrRequestResponseRmt && pickLeafUsersViewOrRequestResponseRmt != null)
            {
                return pickLeafUsersViewOrRequestResponseRmt(PickLeafUsersViewOrRequestResponseRmt!);
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
            global::System.Action<global::G.PickFilterLeafUsersViewOrRequestResponseRmt?>? pickLeafUsersViewOrRequestResponseRmt = null,
            global::System.Action<global::G.UserFilterBranch?>? branch = null,
            global::System.Action<global::G.UserFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafUsersViewOrRequestResponseRmt)
            {
                pickLeafUsersViewOrRequestResponseRmt?.Invoke(PickLeafUsersViewOrRequestResponseRmt!);
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
                PickLeafUsersViewOrRequestResponseRmt,
                typeof(global::G.PickFilterLeafUsersViewOrRequestResponseRmt),
                Branch,
                typeof(global::G.UserFilterBranch),
                Enum,
                typeof(global::G.UserFilterNodeEnum),
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
        public bool Equals(UserFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafUsersViewOrRequestResponseRmt?>.Default.Equals(PickLeafUsersViewOrRequestResponseRmt, other.PickLeafUsersViewOrRequestResponseRmt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UserFilterNode obj1, UserFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UserFilterNode obj1, UserFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserFilterNode o && Equals(o);
        }
    }
}
