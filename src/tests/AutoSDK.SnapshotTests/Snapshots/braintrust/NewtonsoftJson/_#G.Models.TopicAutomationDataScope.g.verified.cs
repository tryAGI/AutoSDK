//HintName: G.Models.TopicAutomationDataScope.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Optional data scope for topic automation.
    /// </summary>
    public readonly partial struct TopicAutomationDataScope : global::System.IEquatable<TopicAutomationDataScope>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TopicAutomationDataScopeVariant1? Value1 { get; init; }
#else
        public global::G.TopicAutomationDataScopeVariant1? Value1 { get; }
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
        public global::G.TopicAutomationDataScopeVariant2? Value2 { get; init; }
#else
        public global::G.TopicAutomationDataScopeVariant2? Value2 { get; }
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
        public global::G.TopicAutomationDataScopeVariant3? Value3 { get; init; }
#else
        public global::G.TopicAutomationDataScopeVariant3? Value3 { get; }
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
#if NET6_0_OR_GREATER
        public object? Value4 { get; init; }
#else
        public object? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant1 value) => new TopicAutomationDataScope((global::G.TopicAutomationDataScopeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TopicAutomationDataScopeVariant1?(TopicAutomationDataScope @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant2 value) => new TopicAutomationDataScope((global::G.TopicAutomationDataScopeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TopicAutomationDataScopeVariant2?(TopicAutomationDataScope @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant3 value) => new TopicAutomationDataScope((global::G.TopicAutomationDataScopeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TopicAutomationDataScopeVariant3?(TopicAutomationDataScope @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(
            global::G.TopicAutomationDataScopeVariant1? value1,
            global::G.TopicAutomationDataScopeVariant2? value2,
            global::G.TopicAutomationDataScopeVariant3? value3,
            object? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
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
            Value3?.ToString() ??
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TopicAutomationDataScopeVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.TopicAutomationDataScopeVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.TopicAutomationDataScopeVariant3?, TResult>? value3 = null,
            global::System.Func<object?, TResult>? value4 = null,
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
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TopicAutomationDataScopeVariant1?>? value1 = null,
            global::System.Action<global::G.TopicAutomationDataScopeVariant2?>? value2 = null,
            global::System.Action<global::G.TopicAutomationDataScopeVariant3?>? value3 = null,
            global::System.Action<object?>? value4 = null,
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
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
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
                typeof(global::G.TopicAutomationDataScopeVariant1),
                Value2,
                typeof(global::G.TopicAutomationDataScopeVariant2),
                Value3,
                typeof(global::G.TopicAutomationDataScopeVariant3),
                Value4,
                typeof(object),
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
        public bool Equals(TopicAutomationDataScope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TopicAutomationDataScopeVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TopicAutomationDataScopeVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TopicAutomationDataScopeVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TopicAutomationDataScope obj1, TopicAutomationDataScope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TopicAutomationDataScope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TopicAutomationDataScope obj1, TopicAutomationDataScope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TopicAutomationDataScope o && Equals(o);
        }
    }
}
