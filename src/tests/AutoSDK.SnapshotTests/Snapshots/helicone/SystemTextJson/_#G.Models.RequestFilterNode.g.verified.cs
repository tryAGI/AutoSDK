//HintName: G.Models.RequestFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RequestFilterNode : global::System.IEquatable<RequestFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? PickLeafFeedbackOrResponsePropertiesValuesRmtSessions { get; init; }
#else
        public global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? PickLeafFeedbackOrResponsePropertiesValuesRmtSessions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions))]
#endif
        public bool IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions => PickLeafFeedbackOrResponsePropertiesValuesRmtSessions != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestFilterBranch? Branch { get; init; }
#else
        public global::G.RequestFilterBranch? Branch { get; }
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
        public global::G.RequestFilterNodeEnum? Enum { get; init; }
#else
        public global::G.RequestFilterNodeEnum? Enum { get; }
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
        public static implicit operator RequestFilterNode(global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt value) => new RequestFilterNode((global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?(RequestFilterNode @this) => @this.PickLeafFeedbackOrResponsePropertiesValuesRmtSessions;

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? value)
        {
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestFilterNode(global::G.RequestFilterBranch value) => new RequestFilterNode((global::G.RequestFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestFilterBranch?(RequestFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(global::G.RequestFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestFilterNode(global::G.RequestFilterNodeEnum value) => new RequestFilterNode((global::G.RequestFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestFilterNodeEnum?(RequestFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(global::G.RequestFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(
            global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions,
            global::G.RequestFilterBranch? branch,
            global::G.RequestFilterNodeEnum? @enum
            )
        {
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions = pickLeafFeedbackOrResponsePropertiesValuesRmtSessions;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?, TResult>? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = null,
            global::System.Func<global::G.RequestFilterBranch?, TResult>? branch = null,
            global::System.Func<global::G.RequestFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions && pickLeafFeedbackOrResponsePropertiesValuesRmtSessions != null)
            {
                return pickLeafFeedbackOrResponsePropertiesValuesRmtSessions(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions!);
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
            global::System.Action<global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?>? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = null,
            global::System.Action<global::G.RequestFilterBranch?>? branch = null,
            global::System.Action<global::G.RequestFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions)
            {
                pickLeafFeedbackOrResponsePropertiesValuesRmtSessions?.Invoke(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions!);
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
                PickLeafFeedbackOrResponsePropertiesValuesRmtSessions,
                typeof(global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt),
                Branch,
                typeof(global::G.RequestFilterBranch),
                Enum,
                typeof(global::G.RequestFilterNodeEnum),
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
        public bool Equals(RequestFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?>.Default.Equals(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions, other.PickLeafFeedbackOrResponsePropertiesValuesRmtSessions) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RequestFilterNode obj1, RequestFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RequestFilterNode obj1, RequestFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestFilterNode o && Equals(o);
        }
    }
}
