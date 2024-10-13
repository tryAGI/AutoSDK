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
#if NET6_0_OR_GREATER
        public global::G.ThreadStreamEvent? Thread { get; init; }
#else
        public global::G.ThreadStreamEvent? Thread { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thread))]
#endif
        public bool IsThread => Thread != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.ThreadStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThreadStreamEvent?(AssistantStreamEvent @this) => @this.Thread;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.ThreadStreamEvent? value)
        {
            Thread = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEvent? Run { get; init; }
#else
        public global::G.RunStreamEvent? Run { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Run))]
#endif
        public bool IsRun => Run != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.RunStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEvent?(AssistantStreamEvent @this) => @this.Run;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.RunStreamEvent? value)
        {
            Run = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEvent? RunStep { get; init; }
#else
        public global::G.RunStepStreamEvent? RunStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStep))]
#endif
        public bool IsRunStep => RunStep != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.RunStepStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEvent?(AssistantStreamEvent @this) => @this.RunStep;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.RunStepStreamEvent? value)
        {
            RunStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEvent? Message { get; init; }
#else
        public global::G.MessageStreamEvent? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.MessageStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEvent?(AssistantStreamEvent @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.MessageStreamEvent? value)
        {
            Message = value;
        }

        /// <summary>
        /// Occurs when an [error](/docs/guides/error-codes/api-errors) occurs. This can happen due to an internal server error or a timeout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorEvent? Error { get; init; }
#else
        public global::G.ErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.ErrorEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorEvent?(AssistantStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// Occurs when a stream ends.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DoneEvent? Done { get; init; }
#else
        public global::G.DoneEvent? Done { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::G.DoneEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DoneEvent?(AssistantStreamEvent @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::G.DoneEvent? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::G.ThreadStreamEvent? thread,
            global::G.RunStreamEvent? run,
            global::G.RunStepStreamEvent? runStep,
            global::G.MessageStreamEvent? message,
            global::G.ErrorEvent? error,
            global::G.DoneEvent? done
            )
        {
            Thread = thread;
            Run = run;
            RunStep = runStep;
            Message = message;
            Error = error;
            Done = done;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Done as object ??
            Error as object ??
            Message as object ??
            RunStep as object ??
            Run as object ??
            Thread as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && IsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ThreadStreamEvent?, TResult>? thread = null,
            global::System.Func<global::G.RunStreamEvent?, TResult>? run = null,
            global::System.Func<global::G.RunStepStreamEvent?, TResult>? runStep = null,
            global::System.Func<global::G.MessageStreamEvent?, TResult>? message = null,
            global::System.Func<global::G.ErrorEvent?, TResult>? error = null,
            global::System.Func<global::G.DoneEvent?, TResult>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread && thread != null)
            {
                return thread(Thread!);
            }
            else if (IsRun && run != null)
            {
                return run(Run!);
            }
            else if (IsRunStep && runStep != null)
            {
                return runStep(RunStep!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsDone && done != null)
            {
                return done(Done!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ThreadStreamEvent?>? thread = null,
            global::System.Action<global::G.RunStreamEvent?>? run = null,
            global::System.Action<global::G.RunStepStreamEvent?>? runStep = null,
            global::System.Action<global::G.MessageStreamEvent?>? message = null,
            global::System.Action<global::G.ErrorEvent?>? error = null,
            global::System.Action<global::G.DoneEvent?>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread)
            {
                thread?.Invoke(Thread!);
            }
            else if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsRunStep)
            {
                runStep?.Invoke(RunStep!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Thread,
                typeof(global::G.ThreadStreamEvent),
                Run,
                typeof(global::G.RunStreamEvent),
                RunStep,
                typeof(global::G.RunStepStreamEvent),
                Message,
                typeof(global::G.MessageStreamEvent),
                Error,
                typeof(global::G.ErrorEvent),
                Done,
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
                global::System.Collections.Generic.EqualityComparer<global::G.ThreadStreamEvent?>.Default.Equals(Thread, other.Thread) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEvent?>.Default.Equals(Run, other.Run) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEvent?>.Default.Equals(RunStep, other.RunStep) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEvent?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DoneEvent?>.Default.Equals(Done, other.Done) 
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.AssistantStreamEvent? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AssistantStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
