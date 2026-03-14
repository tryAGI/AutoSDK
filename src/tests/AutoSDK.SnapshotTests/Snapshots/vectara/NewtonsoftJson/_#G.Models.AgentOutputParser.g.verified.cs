//HintName: G.Models.AgentOutputParser.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for how the agent's output should be parsed and formatted.<br/>
    /// The output parser determines how the agent's responses are processed before being returned to the user.
    /// </summary>
    public readonly partial struct AgentOutputParser : global::System.IEquatable<AgentOutputParser>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentOutputParserDiscriminatorType? Type { get; }

        /// <summary>
        /// Uses native tool calling capabilities and returns output directly to the user. This parser leverages the underlying model's built-in tool calling functionality and passes responses through without additional processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DefaultOutputParser? Default { get; init; }
#else
        public global::G.DefaultOutputParser? Default { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Default))]
#endif
        public bool IsDefault => Default != null;

        /// <summary>
        /// Parses agent output as structured JSON conforming to a specified schema.<br/>
        /// Uses the model's native structured outputs capability to guarantee valid JSON<br/>
        /// that adheres to the provided schema. This is useful when you need the agent's<br/>
        /// final response in a specific format for downstream processing.<br/>
        /// When this parser is configured, the agent emits a StructuredOutputEvent instead<br/>
        /// of AgentOutputEvent. The StructuredOutputEvent contains the validated JSON content<br/>
        /// along with the schema name for identification.<br/>
        /// Note: When using structured outputs, the agent can still use tools normally.<br/>
        /// The schema constraint only applies to the agent's final text response.<br/>
        /// When streaming, the structured output is delivered as a single complete event<br/>
        /// rather than being streamed in chunks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StructuredOutputParser? Structured { get; init; }
#else
        public global::G.StructuredOutputParser? Structured { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Structured))]
#endif
        public bool IsStructured => Structured != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentOutputParser(global::G.DefaultOutputParser value) => new AgentOutputParser((global::G.DefaultOutputParser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DefaultOutputParser?(AgentOutputParser @this) => @this.Default;

        /// <summary>
        /// 
        /// </summary>
        public AgentOutputParser(global::G.DefaultOutputParser? value)
        {
            Default = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentOutputParser(global::G.StructuredOutputParser value) => new AgentOutputParser((global::G.StructuredOutputParser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StructuredOutputParser?(AgentOutputParser @this) => @this.Structured;

        /// <summary>
        /// 
        /// </summary>
        public AgentOutputParser(global::G.StructuredOutputParser? value)
        {
            Structured = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentOutputParser(
            global::G.AgentOutputParserDiscriminatorType? type,
            global::G.DefaultOutputParser? @default,
            global::G.StructuredOutputParser? structured
            )
        {
            Type = type;

            Default = @default;
            Structured = structured;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Structured as object ??
            Default as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Default?.ToString() ??
            Structured?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDefault && !IsStructured || !IsDefault && IsStructured;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.DefaultOutputParser?, TResult>? @default = null,
            global::System.Func<global::G.StructuredOutputParser?, TResult>? structured = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefault && @default != null)
            {
                return @default(Default!);
            }
            else if (IsStructured && structured != null)
            {
                return structured(Structured!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.DefaultOutputParser?>? @default = null,
            global::System.Action<global::G.StructuredOutputParser?>? structured = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefault)
            {
                @default?.Invoke(Default!);
            }
            else if (IsStructured)
            {
                structured?.Invoke(Structured!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Default,
                typeof(global::G.DefaultOutputParser),
                Structured,
                typeof(global::G.StructuredOutputParser),
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
        public bool Equals(AgentOutputParser other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DefaultOutputParser?>.Default.Equals(Default, other.Default) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StructuredOutputParser?>.Default.Equals(Structured, other.Structured) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentOutputParser obj1, AgentOutputParser obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentOutputParser>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentOutputParser obj1, AgentOutputParser obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentOutputParser o && Equals(o);
        }
    }
}
