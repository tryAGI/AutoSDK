//HintName: G.Models.OrgRulesetConditions.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Conditions for an organization ruleset. The conditions object should contain both `repository_name` and `ref_name` properties or both `repository_id` and `ref_name` properties.
    /// </summary>
    public readonly struct OrgRulesetConditions : global::System.IEquatable<OrgRulesetConditions>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value1 { get; init; }
#else
        public object? Value1 { get; }
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
        public static implicit operator OrgRulesetConditions(object value) => new OrgRulesetConditions(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator object?(OrgRulesetConditions @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(object? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value2 { get; init; }
#else
        public object? Value2 { get; }
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
        public static implicit operator OrgRulesetConditions(object value) => new OrgRulesetConditions(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator object?(OrgRulesetConditions @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(object? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
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
        public static implicit operator OrgRulesetConditions(object value) => new OrgRulesetConditions(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator object?(OrgRulesetConditions @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(object? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(
            object? value1,
            object? value2,
            object? value3
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
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(object),
                Value2,
                typeof(object),
                Value3,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OrgRulesetConditions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgRulesetConditions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgRulesetConditions o && Equals(o);
        }
    }
}
