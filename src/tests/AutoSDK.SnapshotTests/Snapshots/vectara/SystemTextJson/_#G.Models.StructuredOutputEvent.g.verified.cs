//HintName: G.Models.StructuredOutputEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An event representing a complete agent response with structured JSON content conforming to a schema.<br/>
    /// This event is published instead of AgentOutputEvent when the agent's output_parser is configured<br/>
    /// with type "structured". It contains the LLM's final response parsed as validated JSON that<br/>
    /// conforms to the schema specified in the StructuredOutputParser configuration.<br/>
    /// When streaming is enabled, this event appears as a single complete event (not streamed in chunks)<br/>
    /// after any tool interactions are complete. The content field contains the parsed JSON,<br/>
    /// and schema_name identifies which schema the content was validated against.
    /// </summary>
    public readonly partial struct StructuredOutputEvent : global::System.IEquatable<StructuredOutputEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentEventBase? Value1 { get; init; }
#else
        public global::G.AgentEventBase? Value1 { get; }
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
        public global::G.StructuredOutputEventVariant2? Value2 { get; init; }
#else
        public global::G.StructuredOutputEventVariant2? Value2 { get; }
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
        public static implicit operator StructuredOutputEvent(global::G.AgentEventBase value) => new StructuredOutputEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(StructuredOutputEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public StructuredOutputEvent(global::G.AgentEventBase? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredOutputEvent(global::G.StructuredOutputEventVariant2 value) => new StructuredOutputEvent((global::G.StructuredOutputEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StructuredOutputEventVariant2?(StructuredOutputEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public StructuredOutputEvent(global::G.StructuredOutputEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StructuredOutputEvent(
            global::G.AgentEventBase? value1,
            global::G.StructuredOutputEventVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? value1 = null,
            global::System.Func<global::G.StructuredOutputEventVariant2?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? value1 = null,
            global::System.Action<global::G.StructuredOutputEventVariant2?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.AgentEventBase),
                Value2,
                typeof(global::G.StructuredOutputEventVariant2),
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
        public bool Equals(StructuredOutputEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StructuredOutputEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StructuredOutputEvent obj1, StructuredOutputEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StructuredOutputEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StructuredOutputEvent obj1, StructuredOutputEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StructuredOutputEvent o && Equals(o);
        }
    }
}
