//HintName: G.Models.StepsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StepsItem : global::System.IEquatable<StepsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowToolResponseModelInputStepDiscriminatorType? Type { get; }

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
        public global::G.WorkflowToolNestedToolsStepModelInput? NestedTools { get; init; }
#else
        public global::G.WorkflowToolNestedToolsStepModelInput? NestedTools { get; }
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
        public static implicit operator StepsItem(global::G.WorkflowToolEdgeStepModel value) => new StepsItem((global::G.WorkflowToolEdgeStepModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolEdgeStepModel?(StepsItem @this) => @this.Edge;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(global::G.WorkflowToolEdgeStepModel? value)
        {
            Edge = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem(global::G.WorkflowToolNestedToolsStepModelInput value) => new StepsItem((global::G.WorkflowToolNestedToolsStepModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolNestedToolsStepModelInput?(StepsItem @this) => @this.NestedTools;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(global::G.WorkflowToolNestedToolsStepModelInput? value)
        {
            NestedTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem(global::G.WorkflowToolMaxIterationsExceededStepModel value) => new StepsItem((global::G.WorkflowToolMaxIterationsExceededStepModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolMaxIterationsExceededStepModel?(StepsItem @this) => @this.MaxIterationsExceeded;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(global::G.WorkflowToolMaxIterationsExceededStepModel? value)
        {
            MaxIterationsExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(
            global::G.WorkflowToolResponseModelInputStepDiscriminatorType? type,
            global::G.WorkflowToolEdgeStepModel? edge,
            global::G.WorkflowToolNestedToolsStepModelInput? nestedTools,
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
            global::System.Func<global::G.WorkflowToolNestedToolsStepModelInput?, TResult>? nestedTools = null,
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
            global::System.Action<global::G.WorkflowToolNestedToolsStepModelInput?>? nestedTools = null,
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
                typeof(global::G.WorkflowToolNestedToolsStepModelInput),
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
        public bool Equals(StepsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolEdgeStepModel?>.Default.Equals(Edge, other.Edge) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolNestedToolsStepModelInput?>.Default.Equals(NestedTools, other.NestedTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolMaxIterationsExceededStepModel?>.Default.Equals(MaxIterationsExceeded, other.MaxIterationsExceeded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepsItem obj1, StepsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepsItem obj1, StepsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepsItem o && Equals(o);
        }
    }
}
