//HintName: G.Models.UpdateAgentResponseTestRouteResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateAgentResponseTestRouteResponse : global::System.IEquatable<UpdateAgentResponseTestRouteResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetResponseUnitTestResponseModel? Llm { get; init; }
#else
        public global::G.GetResponseUnitTestResponseModel? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetToolCallUnitTestResponseModel? Tool { get; init; }
#else
        public global::G.GetToolCallUnitTestResponseModel? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetSimulationTestResponseModel? Simulation { get; init; }
#else
        public global::G.GetSimulationTestResponseModel? Simulation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Simulation))]
#endif
        public bool IsSimulation => Simulation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAgentResponseTestRouteResponse(global::G.GetResponseUnitTestResponseModel value) => new UpdateAgentResponseTestRouteResponse((global::G.GetResponseUnitTestResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetResponseUnitTestResponseModel?(UpdateAgentResponseTestRouteResponse @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(global::G.GetResponseUnitTestResponseModel? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAgentResponseTestRouteResponse(global::G.GetToolCallUnitTestResponseModel value) => new UpdateAgentResponseTestRouteResponse((global::G.GetToolCallUnitTestResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetToolCallUnitTestResponseModel?(UpdateAgentResponseTestRouteResponse @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(global::G.GetToolCallUnitTestResponseModel? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAgentResponseTestRouteResponse(global::G.GetSimulationTestResponseModel value) => new UpdateAgentResponseTestRouteResponse((global::G.GetSimulationTestResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetSimulationTestResponseModel?(UpdateAgentResponseTestRouteResponse @this) => @this.Simulation;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(global::G.GetSimulationTestResponseModel? value)
        {
            Simulation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(
            global::G.UpdateAgentResponseTestRouteResponseDiscriminatorType? type,
            global::G.GetResponseUnitTestResponseModel? llm,
            global::G.GetToolCallUnitTestResponseModel? tool,
            global::G.GetSimulationTestResponseModel? simulation
            )
        {
            Type = type;

            Llm = llm;
            Tool = tool;
            Simulation = simulation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Simulation as object ??
            Tool as object ??
            Llm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Llm?.ToString() ??
            Tool?.ToString() ??
            Simulation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLlm && !IsTool && !IsSimulation || !IsLlm && IsTool && !IsSimulation || !IsLlm && !IsTool && IsSimulation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GetResponseUnitTestResponseModel?, TResult>? llm = null,
            global::System.Func<global::G.GetToolCallUnitTestResponseModel?, TResult>? tool = null,
            global::System.Func<global::G.GetSimulationTestResponseModel?, TResult>? simulation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsSimulation && simulation != null)
            {
                return simulation(Simulation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GetResponseUnitTestResponseModel?>? llm = null,
            global::System.Action<global::G.GetToolCallUnitTestResponseModel?>? tool = null,
            global::System.Action<global::G.GetSimulationTestResponseModel?>? simulation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsSimulation)
            {
                simulation?.Invoke(Simulation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Llm,
                typeof(global::G.GetResponseUnitTestResponseModel),
                Tool,
                typeof(global::G.GetToolCallUnitTestResponseModel),
                Simulation,
                typeof(global::G.GetSimulationTestResponseModel),
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
        public bool Equals(UpdateAgentResponseTestRouteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetResponseUnitTestResponseModel?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetToolCallUnitTestResponseModel?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetSimulationTestResponseModel?>.Default.Equals(Simulation, other.Simulation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateAgentResponseTestRouteResponse obj1, UpdateAgentResponseTestRouteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateAgentResponseTestRouteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateAgentResponseTestRouteResponse obj1, UpdateAgentResponseTestRouteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateAgentResponseTestRouteResponse o && Equals(o);
        }
    }
}
