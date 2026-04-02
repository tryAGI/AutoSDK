//HintName: G.Models.GroupId.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Value of the group_by key, shared across all the hits in the group
    /// </summary>
    public readonly partial struct GroupId : global::System.IEquatable<GroupId>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? GroupIdVariant1 { get; init; }
#else
        public string? GroupIdVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroupIdVariant1))]
#endif
        public bool IsGroupIdVariant1 => GroupIdVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? GroupIdVariant2 { get; init; }
#else
        public int? GroupIdVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroupIdVariant2))]
#endif
        public bool IsGroupIdVariant2 => GroupIdVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public long? GroupIdVariant3 { get; init; }
#else
        public long? GroupIdVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroupIdVariant3))]
#endif
        public bool IsGroupIdVariant3 => GroupIdVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GroupId(string value) => new GroupId((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(GroupId @this) => @this.GroupIdVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GroupId(string? value)
        {
            GroupIdVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GroupId(int value) => new GroupId((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(GroupId @this) => @this.GroupIdVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GroupId(int? value)
        {
            GroupIdVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GroupId(long value) => new GroupId((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(GroupId @this) => @this.GroupIdVariant3;

        /// <summary>
        /// 
        /// </summary>
        public GroupId(long? value)
        {
            GroupIdVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupId(
            string? groupIdVariant1,
            int? groupIdVariant2,
            long? groupIdVariant3
            )
        {
            GroupIdVariant1 = groupIdVariant1;
            GroupIdVariant2 = groupIdVariant2;
            GroupIdVariant3 = groupIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GroupIdVariant3 as object ??
            GroupIdVariant2 as object ??
            GroupIdVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GroupIdVariant1?.ToString() ??
            GroupIdVariant2?.ToString() ??
            GroupIdVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGroupIdVariant1 || IsGroupIdVariant2 || IsGroupIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? groupIdVariant1 = null,
            global::System.Func<int?, TResult>? groupIdVariant2 = null,
            global::System.Func<long?, TResult>? groupIdVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGroupIdVariant1 && groupIdVariant1 != null)
            {
                return groupIdVariant1(GroupIdVariant1!);
            }
            else if (IsGroupIdVariant2 && groupIdVariant2 != null)
            {
                return groupIdVariant2(GroupIdVariant2!);
            }
            else if (IsGroupIdVariant3 && groupIdVariant3 != null)
            {
                return groupIdVariant3(GroupIdVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? groupIdVariant1 = null,
            global::System.Action<int?>? groupIdVariant2 = null,
            global::System.Action<long?>? groupIdVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGroupIdVariant1)
            {
                groupIdVariant1?.Invoke(GroupIdVariant1!);
            }
            else if (IsGroupIdVariant2)
            {
                groupIdVariant2?.Invoke(GroupIdVariant2!);
            }
            else if (IsGroupIdVariant3)
            {
                groupIdVariant3?.Invoke(GroupIdVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GroupIdVariant1,
                typeof(string),
                GroupIdVariant2,
                typeof(int),
                GroupIdVariant3,
                typeof(long),
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
        public bool Equals(GroupId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(GroupIdVariant1, other.GroupIdVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(GroupIdVariant2, other.GroupIdVariant2) &&
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(GroupIdVariant3, other.GroupIdVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GroupId obj1, GroupId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GroupId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GroupId obj1, GroupId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GroupId o && Equals(o);
        }
    }
}
