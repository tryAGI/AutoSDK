//HintName: G.Models.AssistantStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an event emitted when streaming a Run.
    /// Each event in a server-sent events stream has an `event` and `data` property:
    /// ```
    /// event: thread.created
    /// data: {"id": "thread_123", "object": "thread", ...}
    /// ```
    /// We emit events whenever a new object is created, transitions to a new state, or is being
    /// streamed in parts (deltas). For example, we emit `thread.run.created` when a new run
    /// is created, `thread.run.completed` when a run completes, and so on. When an Assistant chooses
    /// to create a message during a run, we emit a `thread.message.created event`, a
    /// `thread.message.in_progress` event, many `thread.message.delta` events, and finally a
    /// `thread.message.completed` event.
    /// We may add additional events over time, so we recommend handling unknown events gracefully
    /// in your code. See the [Assistants API quickstart](/docs/assistants/overview) to learn how to
    /// integrate the Assistants API with streaming.
    /// </summary>
    public readonly struct AssistantStreamEvent : global::System.IEquatable<AssistantStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ThreadStreamEvent? Value1 { get; init; }
#else
        public global::G.ThreadStreamEvent? Value1 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.ThreadStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThreadStreamEvent?(AssistantStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.ThreadStreamEvent? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEvent? Value2 { get; init; }
#else
        public global::G.RunStreamEvent? Value2 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.RunStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEvent?(AssistantStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.RunStreamEvent? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEvent? Value3 { get; init; }
#else
        public global::G.RunStepStreamEvent? Value3 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.RunStepStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEvent?(AssistantStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.RunStepStreamEvent? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEvent? Value4 { get; init; }
#else
        public global::G.MessageStreamEvent? Value4 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.MessageStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEvent?(AssistantStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.MessageStreamEvent? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorEvent? Value5 { get; init; }
#else
        public global::G.ErrorEvent? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.ErrorEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorEvent?(AssistantStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.ErrorEvent? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DoneEvent? Value6 { get; init; }
#else
        public global::G.DoneEvent? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.DoneEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DoneEvent?(AssistantStreamEvent @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.DoneEvent? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::G.ThreadStreamEvent? value1,
            global::G.RunStreamEvent? value2,
            global::G.RunStepStreamEvent? value3,
            global::G.MessageStreamEvent? value4,
            global::G.ErrorEvent? value5,
            global::G.DoneEvent? value6
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return !IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 || IsValue1 && !IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 || IsValue1 && IsValue2 && !IsValue3 && IsValue4 && IsValue5 && IsValue6 || IsValue1 && IsValue2 && IsValue3 && !IsValue4 && IsValue5 && IsValue6 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && !IsValue5 && IsValue6 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && !IsValue6;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.ThreadStreamEvent),
                Value2,
                typeof(global::G.RunStreamEvent),
                Value3,
                typeof(global::G.RunStepStreamEvent),
                Value4,
                typeof(global::G.MessageStreamEvent),
                Value5,
                typeof(global::G.ErrorEvent),
                Value6,
                typeof(global::G.DoneEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AssistantStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ThreadStreamEvent?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEvent?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEvent?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEvent?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorEvent?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DoneEvent?>.Default.Equals(Value6, other.Value6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantStreamEvent obj1, AssistantStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantStreamEvent obj1, AssistantStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantStreamEvent o && Equals(o);
        }
    }
}
