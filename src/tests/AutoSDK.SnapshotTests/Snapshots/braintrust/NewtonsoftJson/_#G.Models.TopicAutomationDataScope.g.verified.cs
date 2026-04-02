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
        public global::G.TopicAutomationDataScopeVariant1? TopicAutomationDataScopeVariant1 { get; init; }
#else
        public global::G.TopicAutomationDataScopeVariant1? TopicAutomationDataScopeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TopicAutomationDataScopeVariant1))]
#endif
        public bool IsTopicAutomationDataScopeVariant1 => TopicAutomationDataScopeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TopicAutomationDataScopeVariant2? TopicAutomationDataScopeVariant2 { get; init; }
#else
        public global::G.TopicAutomationDataScopeVariant2? TopicAutomationDataScopeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TopicAutomationDataScopeVariant2))]
#endif
        public bool IsTopicAutomationDataScopeVariant2 => TopicAutomationDataScopeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TopicAutomationDataScopeVariant3? TopicAutomationDataScopeVariant3 { get; init; }
#else
        public global::G.TopicAutomationDataScopeVariant3? TopicAutomationDataScopeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TopicAutomationDataScopeVariant3))]
#endif
        public bool IsTopicAutomationDataScopeVariant3 => TopicAutomationDataScopeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? TopicAutomationDataScopeVariant4 { get; init; }
#else
        public object? TopicAutomationDataScopeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TopicAutomationDataScopeVariant4))]
#endif
        public bool IsTopicAutomationDataScopeVariant4 => TopicAutomationDataScopeVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant1 value) => new TopicAutomationDataScope((global::G.TopicAutomationDataScopeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TopicAutomationDataScopeVariant1?(TopicAutomationDataScope @this) => @this.TopicAutomationDataScopeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant1? value)
        {
            TopicAutomationDataScopeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant2 value) => new TopicAutomationDataScope((global::G.TopicAutomationDataScopeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TopicAutomationDataScopeVariant2?(TopicAutomationDataScope @this) => @this.TopicAutomationDataScopeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant2? value)
        {
            TopicAutomationDataScopeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant3 value) => new TopicAutomationDataScope((global::G.TopicAutomationDataScopeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TopicAutomationDataScopeVariant3?(TopicAutomationDataScope @this) => @this.TopicAutomationDataScopeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(global::G.TopicAutomationDataScopeVariant3? value)
        {
            TopicAutomationDataScopeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TopicAutomationDataScope(
            global::G.TopicAutomationDataScopeVariant1? topicAutomationDataScopeVariant1,
            global::G.TopicAutomationDataScopeVariant2? topicAutomationDataScopeVariant2,
            global::G.TopicAutomationDataScopeVariant3? topicAutomationDataScopeVariant3,
            object? topicAutomationDataScopeVariant4
            )
        {
            TopicAutomationDataScopeVariant1 = topicAutomationDataScopeVariant1;
            TopicAutomationDataScopeVariant2 = topicAutomationDataScopeVariant2;
            TopicAutomationDataScopeVariant3 = topicAutomationDataScopeVariant3;
            TopicAutomationDataScopeVariant4 = topicAutomationDataScopeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TopicAutomationDataScopeVariant4 as object ??
            TopicAutomationDataScopeVariant3 as object ??
            TopicAutomationDataScopeVariant2 as object ??
            TopicAutomationDataScopeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TopicAutomationDataScopeVariant1?.ToString() ??
            TopicAutomationDataScopeVariant2?.ToString() ??
            TopicAutomationDataScopeVariant3?.ToString() ??
            TopicAutomationDataScopeVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTopicAutomationDataScopeVariant1 || IsTopicAutomationDataScopeVariant2 || IsTopicAutomationDataScopeVariant3 || IsTopicAutomationDataScopeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TopicAutomationDataScopeVariant1?, TResult>? topicAutomationDataScopeVariant1 = null,
            global::System.Func<global::G.TopicAutomationDataScopeVariant2?, TResult>? topicAutomationDataScopeVariant2 = null,
            global::System.Func<global::G.TopicAutomationDataScopeVariant3?, TResult>? topicAutomationDataScopeVariant3 = null,
            global::System.Func<object?, TResult>? topicAutomationDataScopeVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTopicAutomationDataScopeVariant1 && topicAutomationDataScopeVariant1 != null)
            {
                return topicAutomationDataScopeVariant1(TopicAutomationDataScopeVariant1!);
            }
            else if (IsTopicAutomationDataScopeVariant2 && topicAutomationDataScopeVariant2 != null)
            {
                return topicAutomationDataScopeVariant2(TopicAutomationDataScopeVariant2!);
            }
            else if (IsTopicAutomationDataScopeVariant3 && topicAutomationDataScopeVariant3 != null)
            {
                return topicAutomationDataScopeVariant3(TopicAutomationDataScopeVariant3!);
            }
            else if (IsTopicAutomationDataScopeVariant4 && topicAutomationDataScopeVariant4 != null)
            {
                return topicAutomationDataScopeVariant4(TopicAutomationDataScopeVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TopicAutomationDataScopeVariant1?>? topicAutomationDataScopeVariant1 = null,
            global::System.Action<global::G.TopicAutomationDataScopeVariant2?>? topicAutomationDataScopeVariant2 = null,
            global::System.Action<global::G.TopicAutomationDataScopeVariant3?>? topicAutomationDataScopeVariant3 = null,
            global::System.Action<object?>? topicAutomationDataScopeVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTopicAutomationDataScopeVariant1)
            {
                topicAutomationDataScopeVariant1?.Invoke(TopicAutomationDataScopeVariant1!);
            }
            else if (IsTopicAutomationDataScopeVariant2)
            {
                topicAutomationDataScopeVariant2?.Invoke(TopicAutomationDataScopeVariant2!);
            }
            else if (IsTopicAutomationDataScopeVariant3)
            {
                topicAutomationDataScopeVariant3?.Invoke(TopicAutomationDataScopeVariant3!);
            }
            else if (IsTopicAutomationDataScopeVariant4)
            {
                topicAutomationDataScopeVariant4?.Invoke(TopicAutomationDataScopeVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TopicAutomationDataScopeVariant1,
                typeof(global::G.TopicAutomationDataScopeVariant1),
                TopicAutomationDataScopeVariant2,
                typeof(global::G.TopicAutomationDataScopeVariant2),
                TopicAutomationDataScopeVariant3,
                typeof(global::G.TopicAutomationDataScopeVariant3),
                TopicAutomationDataScopeVariant4,
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
                global::System.Collections.Generic.EqualityComparer<global::G.TopicAutomationDataScopeVariant1?>.Default.Equals(TopicAutomationDataScopeVariant1, other.TopicAutomationDataScopeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TopicAutomationDataScopeVariant2?>.Default.Equals(TopicAutomationDataScopeVariant2, other.TopicAutomationDataScopeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TopicAutomationDataScopeVariant3?>.Default.Equals(TopicAutomationDataScopeVariant3, other.TopicAutomationDataScopeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(TopicAutomationDataScopeVariant4, other.TopicAutomationDataScopeVariant4) 
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
