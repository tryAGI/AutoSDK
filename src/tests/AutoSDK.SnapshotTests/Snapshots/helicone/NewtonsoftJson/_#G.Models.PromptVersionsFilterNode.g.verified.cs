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
        public global::G.PickFilterLeafPromptsVersions? Value1 { get; init; }
#else
        public global::G.PickFilterLeafPromptsVersions? Value1 { get; }
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
        public global::G.PromptVersionsFilterBranch? Value2 { get; init; }
#else
        public global::G.PromptVersionsFilterBranch? Value2 { get; }
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
        public global::G.PromptVersionsFilterNodeEnum? Value3 { get; init; }
#else
        public global::G.PromptVersionsFilterNodeEnum? Value3 { get; }
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
        public static implicit operator PromptVersionsFilterNode(global::G.PickFilterLeafPromptsVersions value) => new PromptVersionsFilterNode((global::G.PickFilterLeafPromptsVersions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafPromptsVersions?(PromptVersionsFilterNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(global::G.PickFilterLeafPromptsVersions? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::G.PromptVersionsFilterBranch value) => new PromptVersionsFilterNode((global::G.PromptVersionsFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptVersionsFilterBranch?(PromptVersionsFilterNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(global::G.PromptVersionsFilterBranch? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::G.PromptVersionsFilterNodeEnum value) => new PromptVersionsFilterNode((global::G.PromptVersionsFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptVersionsFilterNodeEnum?(PromptVersionsFilterNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(global::G.PromptVersionsFilterNodeEnum? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionsFilterNode(
            global::G.PickFilterLeafPromptsVersions? value1,
            global::G.PromptVersionsFilterBranch? value2,
            global::G.PromptVersionsFilterNodeEnum? value3
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
            global::System.Func<global::G.PickFilterLeafPromptsVersions?, TResult>? value1 = null,
            global::System.Func<global::G.PromptVersionsFilterBranch?, TResult>? value2 = null,
            global::System.Func<global::G.PromptVersionsFilterNodeEnum?, TResult>? value3 = null,
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
            global::System.Action<global::G.PickFilterLeafPromptsVersions?>? value1 = null,
            global::System.Action<global::G.PromptVersionsFilterBranch?>? value2 = null,
            global::System.Action<global::G.PromptVersionsFilterNodeEnum?>? value3 = null,
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
                typeof(global::G.PickFilterLeafPromptsVersions),
                Value2,
                typeof(global::G.PromptVersionsFilterBranch),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafPromptsVersions?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptVersionsFilterBranch?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptVersionsFilterNodeEnum?>.Default.Equals(Value3, other.Value3) 
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
