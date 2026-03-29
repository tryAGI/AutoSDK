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
        public global::G.PickFilterLeafUsersViewOrRequestResponseRmt? Value1 { get; init; }
#else
        public global::G.PickFilterLeafUsersViewOrRequestResponseRmt? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserFilterBranch? Value2 { get; init; }
#else
        public global::G.UserFilterBranch? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserFilterNodeEnum? Value3 { get; init; }
#else
        public global::G.UserFilterNodeEnum? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::G.PickFilterLeafUsersViewOrRequestResponseRmt value) => new UserFilterNode((global::G.PickFilterLeafUsersViewOrRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafUsersViewOrRequestResponseRmt?(UserFilterNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::G.PickFilterLeafUsersViewOrRequestResponseRmt? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::G.UserFilterBranch value) => new UserFilterNode((global::G.UserFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserFilterBranch?(UserFilterNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::G.UserFilterBranch? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::G.UserFilterNodeEnum value) => new UserFilterNode((global::G.UserFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserFilterNodeEnum?(UserFilterNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::G.UserFilterNodeEnum? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(
            global::G.PickFilterLeafUsersViewOrRequestResponseRmt? value1,
            global::G.UserFilterBranch? value2,
            global::G.UserFilterNodeEnum? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafUsersViewOrRequestResponseRmt?, TResult>? value1 = null,
            global::System.Func<global::G.UserFilterBranch?, TResult>? value2 = null,
            global::System.Func<global::G.UserFilterNodeEnum?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PickFilterLeafUsersViewOrRequestResponseRmt?>? value1 = null,
            global::System.Action<global::G.UserFilterBranch?>? value2 = null,
            global::System.Action<global::G.UserFilterNodeEnum?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.PickFilterLeafUsersViewOrRequestResponseRmt),
                Value2,
                typeof(global::G.UserFilterBranch),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafUsersViewOrRequestResponseRmt?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserFilterBranch?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserFilterNodeEnum?>.Default.Equals(Value3, other.Value3) 
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
