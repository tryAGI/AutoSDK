//HintName: G.Models.AssistantStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an event emitted when streaming a Run.<br/>
    /// Each event in a server-sent events stream has an `event` and `data` property:<br/>
    /// ```<br/>
    /// event: thread.created<br/>
    /// data: {"id": "thread_123", "object": "thread", ...}<br/>
    /// ```<br/>
    /// We emit events whenever a new object is created, transitions to a new state, or is being<br/>
    /// streamed in parts (deltas). For example, we emit `thread.run.created` when a new run<br/>
    /// is created, `thread.run.completed` when a run completes, and so on. When an Assistant chooses<br/>
    /// to create a message during a run, we emit a `thread.message.created event`, a<br/>
    /// `thread.message.in_progress` event, many `thread.message.delta` events, and finally a<br/>
    /// `thread.message.completed` event.<br/>
    /// We may add additional events over time, so we recommend handling unknown events gracefully<br/>
    /// in your code. See the [Assistants API quickstart](/docs/assistants/overview) to learn how to<br/>
    /// integrate the Assistants API with streaming.
    /// </summary>
    public readonly partial struct AssistantStreamEvent : global::System.IEquatable<AssistantStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantStreamEventDiscriminatorEvent? Event { get; }

        /// <summary>
        /// Occurs when an [error](/docs/guides/error-codes/api-errors) occurs. This can happen due to an internal server error or a timeout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorEvent? Value1 { get; init; }
#else
        public global::G.ErrorEvent? Value1 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.ErrorEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorEvent?(AssistantStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.ErrorEvent? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Occurs when a stream ends.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DoneEvent? Value2 { get; init; }
#else
        public global::G.DoneEvent? Value2 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.DoneEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DoneEvent?(AssistantStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.DoneEvent? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Occurs when a new [thread](/docs/api-reference/threads/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant3? Value3 { get; init; }
#else
        public global::G.AssistantStreamEventVariant3? Value3 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant3 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant3?(AssistantStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Occurs when a new [run](/docs/api-reference/runs/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant4? Value4 { get; init; }
#else
        public global::G.AssistantStreamEventVariant4? Value4 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant4 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant4?(AssistantStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `queued` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant5? Value5 { get; init; }
#else
        public global::G.AssistantStreamEventVariant5? Value5 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant5 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant5?(AssistantStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to an `in_progress` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant6? Value6 { get; init; }
#else
        public global::G.AssistantStreamEventVariant6? Value6 { get; }
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
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant6 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant6?(AssistantStreamEvent @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `requires_action` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant7? Value7 { get; init; }
#else
        public global::G.AssistantStreamEventVariant7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant7 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant7?(AssistantStreamEvent @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant8? Value8 { get; init; }
#else
        public global::G.AssistantStreamEventVariant8? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant8 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant8?(AssistantStreamEvent @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant8? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) ends with status `incomplete`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant9? Value9 { get; init; }
#else
        public global::G.AssistantStreamEventVariant9? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant9 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant9?(AssistantStreamEvent @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant9? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant10? Value10 { get; init; }
#else
        public global::G.AssistantStreamEventVariant10? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant10 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant10?(AssistantStreamEvent @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant10? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `cancelling` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant11? Value11 { get; init; }
#else
        public global::G.AssistantStreamEventVariant11? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant11 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant11?(AssistantStreamEvent @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant11? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant12? Value12 { get; init; }
#else
        public global::G.AssistantStreamEventVariant12? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant12 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant12?(AssistantStreamEvent @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant12? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant13? Value13 { get; init; }
#else
        public global::G.AssistantStreamEventVariant13? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant13 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant13?(AssistantStreamEvent @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant13? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/runs/step-object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant14? Value14 { get; init; }
#else
        public global::G.AssistantStreamEventVariant14? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant14 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant14?(AssistantStreamEvent @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant14? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/runs/step-object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant15? Value15 { get; init; }
#else
        public global::G.AssistantStreamEventVariant15? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant15 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant15?(AssistantStreamEvent @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant15? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// Occurs when parts of a [run step](/docs/api-reference/runs/step-object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant16? Value16 { get; init; }
#else
        public global::G.AssistantStreamEventVariant16? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant16 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant16?(AssistantStreamEvent @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant16? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/runs/step-object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant17? Value17 { get; init; }
#else
        public global::G.AssistantStreamEventVariant17? Value17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant17 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant17?(AssistantStreamEvent @this) => @this.Value17;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant17? value)
        {
            Value17 = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/runs/step-object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant18? Value18 { get; init; }
#else
        public global::G.AssistantStreamEventVariant18? Value18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant18 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant18?(AssistantStreamEvent @this) => @this.Value18;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant18? value)
        {
            Value18 = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/runs/step-object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant19? Value19 { get; init; }
#else
        public global::G.AssistantStreamEventVariant19? Value19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant19 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant19?(AssistantStreamEvent @this) => @this.Value19;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant19? value)
        {
            Value19 = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/runs/step-object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant20? Value20 { get; init; }
#else
        public global::G.AssistantStreamEventVariant20? Value20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value20))]
#endif
        public bool IsValue20 => Value20 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant20 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant20?(AssistantStreamEvent @this) => @this.Value20;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant20? value)
        {
            Value20 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant21? Value21 { get; init; }
#else
        public global::G.AssistantStreamEventVariant21? Value21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value21))]
#endif
        public bool IsValue21 => Value21 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant21 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant21?(AssistantStreamEvent @this) => @this.Value21;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant21? value)
        {
            Value21 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant22? Value22 { get; init; }
#else
        public global::G.AssistantStreamEventVariant22? Value22 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value22))]
#endif
        public bool IsValue22 => Value22 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant22 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant22?(AssistantStreamEvent @this) => @this.Value22;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant22? value)
        {
            Value22 = value;
        }

        /// <summary>
        /// Occurs when parts of a [Message](/docs/api-reference/messages/object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant23? Value23 { get; init; }
#else
        public global::G.AssistantStreamEventVariant23? Value23 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value23))]
#endif
        public bool IsValue23 => Value23 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant23 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant23?(AssistantStreamEvent @this) => @this.Value23;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant23? value)
        {
            Value23 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant24? Value24 { get; init; }
#else
        public global::G.AssistantStreamEventVariant24? Value24 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value24))]
#endif
        public bool IsValue24 => Value24 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant24 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant24?(AssistantStreamEvent @this) => @this.Value24;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant24? value)
        {
            Value24 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) ends before it is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantStreamEventVariant25? Value25 { get; init; }
#else
        public global::G.AssistantStreamEventVariant25? Value25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value25))]
#endif
        public bool IsValue25 => Value25 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.AssistantStreamEventVariant25 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantStreamEventVariant25?(AssistantStreamEvent @this) => @this.Value25;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.AssistantStreamEventVariant25? value)
        {
            Value25 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::G.AssistantStreamEventDiscriminatorEvent? @event,
            global::G.ErrorEvent? value1,
            global::G.DoneEvent? value2,
            global::G.AssistantStreamEventVariant3? value3,
            global::G.AssistantStreamEventVariant4? value4,
            global::G.AssistantStreamEventVariant5? value5,
            global::G.AssistantStreamEventVariant6? value6,
            global::G.AssistantStreamEventVariant7? value7,
            global::G.AssistantStreamEventVariant8? value8,
            global::G.AssistantStreamEventVariant9? value9,
            global::G.AssistantStreamEventVariant10? value10,
            global::G.AssistantStreamEventVariant11? value11,
            global::G.AssistantStreamEventVariant12? value12,
            global::G.AssistantStreamEventVariant13? value13,
            global::G.AssistantStreamEventVariant14? value14,
            global::G.AssistantStreamEventVariant15? value15,
            global::G.AssistantStreamEventVariant16? value16,
            global::G.AssistantStreamEventVariant17? value17,
            global::G.AssistantStreamEventVariant18? value18,
            global::G.AssistantStreamEventVariant19? value19,
            global::G.AssistantStreamEventVariant20? value20,
            global::G.AssistantStreamEventVariant21? value21,
            global::G.AssistantStreamEventVariant22? value22,
            global::G.AssistantStreamEventVariant23? value23,
            global::G.AssistantStreamEventVariant24? value24,
            global::G.AssistantStreamEventVariant25? value25
            )
        {
            Event = @event;

            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
            Value17 = value17;
            Value18 = value18;
            Value19 = value19;
            Value20 = value20;
            Value21 = value21;
            Value22 = value22;
            Value23 = value23;
            Value24 = value24;
            Value25 = value25;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value25 as object ??
            Value24 as object ??
            Value23 as object ??
            Value22 as object ??
            Value21 as object ??
            Value20 as object ??
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
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
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && IsValue22 && !IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && IsValue23 && !IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && IsValue24 && !IsValue25 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 && !IsValue22 && !IsValue23 && !IsValue24 && IsValue25;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ErrorEvent?, TResult>? value1 = null,
            global::System.Func<global::G.DoneEvent?, TResult>? value2 = null,
            global::System.Func<global::G.AssistantStreamEventVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.AssistantStreamEventVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.AssistantStreamEventVariant5?, TResult>? value5 = null,
            global::System.Func<global::G.AssistantStreamEventVariant6?, TResult>? value6 = null,
            global::System.Func<global::G.AssistantStreamEventVariant7?, TResult>? value7 = null,
            global::System.Func<global::G.AssistantStreamEventVariant8?, TResult>? value8 = null,
            global::System.Func<global::G.AssistantStreamEventVariant9?, TResult>? value9 = null,
            global::System.Func<global::G.AssistantStreamEventVariant10?, TResult>? value10 = null,
            global::System.Func<global::G.AssistantStreamEventVariant11?, TResult>? value11 = null,
            global::System.Func<global::G.AssistantStreamEventVariant12?, TResult>? value12 = null,
            global::System.Func<global::G.AssistantStreamEventVariant13?, TResult>? value13 = null,
            global::System.Func<global::G.AssistantStreamEventVariant14?, TResult>? value14 = null,
            global::System.Func<global::G.AssistantStreamEventVariant15?, TResult>? value15 = null,
            global::System.Func<global::G.AssistantStreamEventVariant16?, TResult>? value16 = null,
            global::System.Func<global::G.AssistantStreamEventVariant17?, TResult>? value17 = null,
            global::System.Func<global::G.AssistantStreamEventVariant18?, TResult>? value18 = null,
            global::System.Func<global::G.AssistantStreamEventVariant19?, TResult>? value19 = null,
            global::System.Func<global::G.AssistantStreamEventVariant20?, TResult>? value20 = null,
            global::System.Func<global::G.AssistantStreamEventVariant21?, TResult>? value21 = null,
            global::System.Func<global::G.AssistantStreamEventVariant22?, TResult>? value22 = null,
            global::System.Func<global::G.AssistantStreamEventVariant23?, TResult>? value23 = null,
            global::System.Func<global::G.AssistantStreamEventVariant24?, TResult>? value24 = null,
            global::System.Func<global::G.AssistantStreamEventVariant25?, TResult>? value25 = null,
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
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }
            else if (IsValue20 && value20 != null)
            {
                return value20(Value20!);
            }
            else if (IsValue21 && value21 != null)
            {
                return value21(Value21!);
            }
            else if (IsValue22 && value22 != null)
            {
                return value22(Value22!);
            }
            else if (IsValue23 && value23 != null)
            {
                return value23(Value23!);
            }
            else if (IsValue24 && value24 != null)
            {
                return value24(Value24!);
            }
            else if (IsValue25 && value25 != null)
            {
                return value25(Value25!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ErrorEvent?>? value1 = null,
            global::System.Action<global::G.DoneEvent?>? value2 = null,
            global::System.Action<global::G.AssistantStreamEventVariant3?>? value3 = null,
            global::System.Action<global::G.AssistantStreamEventVariant4?>? value4 = null,
            global::System.Action<global::G.AssistantStreamEventVariant5?>? value5 = null,
            global::System.Action<global::G.AssistantStreamEventVariant6?>? value6 = null,
            global::System.Action<global::G.AssistantStreamEventVariant7?>? value7 = null,
            global::System.Action<global::G.AssistantStreamEventVariant8?>? value8 = null,
            global::System.Action<global::G.AssistantStreamEventVariant9?>? value9 = null,
            global::System.Action<global::G.AssistantStreamEventVariant10?>? value10 = null,
            global::System.Action<global::G.AssistantStreamEventVariant11?>? value11 = null,
            global::System.Action<global::G.AssistantStreamEventVariant12?>? value12 = null,
            global::System.Action<global::G.AssistantStreamEventVariant13?>? value13 = null,
            global::System.Action<global::G.AssistantStreamEventVariant14?>? value14 = null,
            global::System.Action<global::G.AssistantStreamEventVariant15?>? value15 = null,
            global::System.Action<global::G.AssistantStreamEventVariant16?>? value16 = null,
            global::System.Action<global::G.AssistantStreamEventVariant17?>? value17 = null,
            global::System.Action<global::G.AssistantStreamEventVariant18?>? value18 = null,
            global::System.Action<global::G.AssistantStreamEventVariant19?>? value19 = null,
            global::System.Action<global::G.AssistantStreamEventVariant20?>? value20 = null,
            global::System.Action<global::G.AssistantStreamEventVariant21?>? value21 = null,
            global::System.Action<global::G.AssistantStreamEventVariant22?>? value22 = null,
            global::System.Action<global::G.AssistantStreamEventVariant23?>? value23 = null,
            global::System.Action<global::G.AssistantStreamEventVariant24?>? value24 = null,
            global::System.Action<global::G.AssistantStreamEventVariant25?>? value25 = null,
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
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
            else if (IsValue20)
            {
                value20?.Invoke(Value20!);
            }
            else if (IsValue21)
            {
                value21?.Invoke(Value21!);
            }
            else if (IsValue22)
            {
                value22?.Invoke(Value22!);
            }
            else if (IsValue23)
            {
                value23?.Invoke(Value23!);
            }
            else if (IsValue24)
            {
                value24?.Invoke(Value24!);
            }
            else if (IsValue25)
            {
                value25?.Invoke(Value25!);
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
                typeof(global::G.ErrorEvent),
                Value2,
                typeof(global::G.DoneEvent),
                Value3,
                typeof(global::G.AssistantStreamEventVariant3),
                Value4,
                typeof(global::G.AssistantStreamEventVariant4),
                Value5,
                typeof(global::G.AssistantStreamEventVariant5),
                Value6,
                typeof(global::G.AssistantStreamEventVariant6),
                Value7,
                typeof(global::G.AssistantStreamEventVariant7),
                Value8,
                typeof(global::G.AssistantStreamEventVariant8),
                Value9,
                typeof(global::G.AssistantStreamEventVariant9),
                Value10,
                typeof(global::G.AssistantStreamEventVariant10),
                Value11,
                typeof(global::G.AssistantStreamEventVariant11),
                Value12,
                typeof(global::G.AssistantStreamEventVariant12),
                Value13,
                typeof(global::G.AssistantStreamEventVariant13),
                Value14,
                typeof(global::G.AssistantStreamEventVariant14),
                Value15,
                typeof(global::G.AssistantStreamEventVariant15),
                Value16,
                typeof(global::G.AssistantStreamEventVariant16),
                Value17,
                typeof(global::G.AssistantStreamEventVariant17),
                Value18,
                typeof(global::G.AssistantStreamEventVariant18),
                Value19,
                typeof(global::G.AssistantStreamEventVariant19),
                Value20,
                typeof(global::G.AssistantStreamEventVariant20),
                Value21,
                typeof(global::G.AssistantStreamEventVariant21),
                Value22,
                typeof(global::G.AssistantStreamEventVariant22),
                Value23,
                typeof(global::G.AssistantStreamEventVariant23),
                Value24,
                typeof(global::G.AssistantStreamEventVariant24),
                Value25,
                typeof(global::G.AssistantStreamEventVariant25),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorEvent?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DoneEvent?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant8?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant9?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant10?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant11?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant12?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant13?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant14?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant15?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant16?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant17?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant18?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant19?>.Default.Equals(Value19, other.Value19) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant20?>.Default.Equals(Value20, other.Value20) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant21?>.Default.Equals(Value21, other.Value21) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant22?>.Default.Equals(Value22, other.Value22) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant23?>.Default.Equals(Value23, other.Value23) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant24?>.Default.Equals(Value24, other.Value24) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantStreamEventVariant25?>.Default.Equals(Value25, other.Value25) 
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.AssistantStreamEvent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.AssistantStreamEvent),
                jsonSerializerContext) as global::G.AssistantStreamEvent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.AssistantStreamEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
