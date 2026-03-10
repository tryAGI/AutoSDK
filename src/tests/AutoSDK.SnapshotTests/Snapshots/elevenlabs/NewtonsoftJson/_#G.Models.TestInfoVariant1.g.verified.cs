//HintName: G.Models.TestInfoVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestInfoVariant1 : global::System.IEquatable<TestInfoVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseUnitTestModel? Llm { get; init; }
#else
        public global::G.ResponseUnitTestModel? Llm { get; }
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
        public global::G.ToolCallUnitTestModel? Tool { get; init; }
#else
        public global::G.ToolCallUnitTestModel? Tool { get; }
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
        public global::G.SimulationTestModel? Simulation { get; init; }
#else
        public global::G.SimulationTestModel? Simulation { get; }
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
        public static implicit operator TestInfoVariant1(global::G.ResponseUnitTestModel value) => new TestInfoVariant1((global::G.ResponseUnitTestModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseUnitTestModel?(TestInfoVariant1 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public TestInfoVariant1(global::G.ResponseUnitTestModel? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestInfoVariant1(global::G.ToolCallUnitTestModel value) => new TestInfoVariant1((global::G.ToolCallUnitTestModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallUnitTestModel?(TestInfoVariant1 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public TestInfoVariant1(global::G.ToolCallUnitTestModel? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestInfoVariant1(global::G.SimulationTestModel value) => new TestInfoVariant1((global::G.SimulationTestModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SimulationTestModel?(TestInfoVariant1 @this) => @this.Simulation;

        /// <summary>
        /// 
        /// </summary>
        public TestInfoVariant1(global::G.SimulationTestModel? value)
        {
            Simulation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestInfoVariant1(
            global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? type,
            global::G.ResponseUnitTestModel? llm,
            global::G.ToolCallUnitTestModel? tool,
            global::G.SimulationTestModel? simulation
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
            global::System.Func<global::G.ResponseUnitTestModel?, TResult>? llm = null,
            global::System.Func<global::G.ToolCallUnitTestModel?, TResult>? tool = null,
            global::System.Func<global::G.SimulationTestModel?, TResult>? simulation = null,
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
            global::System.Action<global::G.ResponseUnitTestModel?>? llm = null,
            global::System.Action<global::G.ToolCallUnitTestModel?>? tool = null,
            global::System.Action<global::G.SimulationTestModel?>? simulation = null,
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
                typeof(global::G.ResponseUnitTestModel),
                Tool,
                typeof(global::G.ToolCallUnitTestModel),
                Simulation,
                typeof(global::G.SimulationTestModel),
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
        public bool Equals(TestInfoVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseUnitTestModel?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallUnitTestModel?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SimulationTestModel?>.Default.Equals(Simulation, other.Simulation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestInfoVariant1 obj1, TestInfoVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestInfoVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestInfoVariant1 obj1, TestInfoVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestInfoVariant1 o && Equals(o);
        }
    }
}
