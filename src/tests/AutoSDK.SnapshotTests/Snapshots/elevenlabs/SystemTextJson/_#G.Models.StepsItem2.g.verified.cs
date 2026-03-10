//HintName: G.Models.StepsItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StepsItem2 : global::System.IEquatable<StepsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowToolResponseModelOutputStepDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowToolEdgeStepModel? Edge { get; init; }
#else
        public global::G.WorkflowToolEdgeStepModel? Edge { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Edge))]
#endif
        public bool IsEdge => Edge != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowToolNestedToolsStepModelOutput? NestedTools { get; init; }
#else
        public global::G.WorkflowToolNestedToolsStepModelOutput? NestedTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NestedTools))]
#endif
        public bool IsNestedTools => NestedTools != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowToolMaxIterationsExceededStepModel? MaxIterationsExceeded { get; init; }
#else
        public global::G.WorkflowToolMaxIterationsExceededStepModel? MaxIterationsExceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxIterationsExceeded))]
#endif
        public bool IsMaxIterationsExceeded => MaxIterationsExceeded != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem2(global::G.WorkflowToolEdgeStepModel value) => new StepsItem2((global::G.WorkflowToolEdgeStepModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolEdgeStepModel?(StepsItem2 @this) => @this.Edge;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem2(global::G.WorkflowToolEdgeStepModel? value)
        {
            Edge = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem2(global::G.WorkflowToolNestedToolsStepModelOutput value) => new StepsItem2((global::G.WorkflowToolNestedToolsStepModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolNestedToolsStepModelOutput?(StepsItem2 @this) => @this.NestedTools;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem2(global::G.WorkflowToolNestedToolsStepModelOutput? value)
        {
            NestedTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem2(global::G.WorkflowToolMaxIterationsExceededStepModel value) => new StepsItem2((global::G.WorkflowToolMaxIterationsExceededStepModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolMaxIterationsExceededStepModel?(StepsItem2 @this) => @this.MaxIterationsExceeded;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem2(global::G.WorkflowToolMaxIterationsExceededStepModel? value)
        {
            MaxIterationsExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepsItem2(
            global::G.WorkflowToolResponseModelOutputStepDiscriminatorType? type,
            global::G.WorkflowToolEdgeStepModel? edge,
            global::G.WorkflowToolNestedToolsStepModelOutput? nestedTools,
            global::G.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded
            )
        {
            Type = type;

            Edge = edge;
            NestedTools = nestedTools;
            MaxIterationsExceeded = maxIterationsExceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MaxIterationsExceeded as object ??
            NestedTools as object ??
            Edge as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Edge?.ToString() ??
            NestedTools?.ToString() ??
            MaxIterationsExceeded?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEdge && !IsNestedTools && !IsMaxIterationsExceeded || !IsEdge && IsNestedTools && !IsMaxIterationsExceeded || !IsEdge && !IsNestedTools && IsMaxIterationsExceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WorkflowToolEdgeStepModel?, TResult>? edge = null,
            global::System.Func<global::G.WorkflowToolNestedToolsStepModelOutput?, TResult>? nestedTools = null,
            global::System.Func<global::G.WorkflowToolMaxIterationsExceededStepModel?, TResult>? maxIterationsExceeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEdge && edge != null)
            {
                return edge(Edge!);
            }
            else if (IsNestedTools && nestedTools != null)
            {
                return nestedTools(NestedTools!);
            }
            else if (IsMaxIterationsExceeded && maxIterationsExceeded != null)
            {
                return maxIterationsExceeded(MaxIterationsExceeded!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WorkflowToolEdgeStepModel?>? edge = null,
            global::System.Action<global::G.WorkflowToolNestedToolsStepModelOutput?>? nestedTools = null,
            global::System.Action<global::G.WorkflowToolMaxIterationsExceededStepModel?>? maxIterationsExceeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEdge)
            {
                edge?.Invoke(Edge!);
            }
            else if (IsNestedTools)
            {
                nestedTools?.Invoke(NestedTools!);
            }
            else if (IsMaxIterationsExceeded)
            {
                maxIterationsExceeded?.Invoke(MaxIterationsExceeded!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Edge,
                typeof(global::G.WorkflowToolEdgeStepModel),
                NestedTools,
                typeof(global::G.WorkflowToolNestedToolsStepModelOutput),
                MaxIterationsExceeded,
                typeof(global::G.WorkflowToolMaxIterationsExceededStepModel),
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
        public bool Equals(StepsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolEdgeStepModel?>.Default.Equals(Edge, other.Edge) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolNestedToolsStepModelOutput?>.Default.Equals(NestedTools, other.NestedTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolMaxIterationsExceededStepModel?>.Default.Equals(MaxIterationsExceeded, other.MaxIterationsExceeded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepsItem2 obj1, StepsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepsItem2 obj1, StepsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepsItem2 o && Equals(o);
        }
    }
}
