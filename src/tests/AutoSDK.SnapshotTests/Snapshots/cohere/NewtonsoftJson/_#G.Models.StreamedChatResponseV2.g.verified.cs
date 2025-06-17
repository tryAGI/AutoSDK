//HintName: G.Models.StreamedChatResponseV2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// StreamedChatResponse is returned in streaming mode (specified with `stream=True` in the request).
    /// </summary>
    public readonly partial struct StreamedChatResponseV2 : global::System.IEquatable<StreamedChatResponseV2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.StreamedChatResponseV2DiscriminatorType? Type { get; }

        /// <summary>
        /// A streamed event which signifies that a stream has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessageStartEvent? MessageStart { get; init; }
#else
        public global::G.ChatMessageStartEvent? MessageStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStart))]
#endif
        public bool IsMessageStart => MessageStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatMessageStartEvent value) => new StreamedChatResponseV2((global::G.ChatMessageStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageStartEvent?(StreamedChatResponseV2 @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatMessageStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that a new content block has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentStartEvent? ContentStart { get; init; }
#else
        public global::G.ChatContentStartEvent? ContentStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentStart))]
#endif
        public bool IsContentStart => ContentStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatContentStartEvent value) => new StreamedChatResponseV2((global::G.ChatContentStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentStartEvent?(StreamedChatResponseV2 @this) => @this.ContentStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatContentStartEvent? value)
        {
            ContentStart = value;
        }

        /// <summary>
        /// A streamed delta event which contains a delta of chat text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentDeltaEvent? ContentDelta { get; init; }
#else
        public global::G.ChatContentDeltaEvent? ContentDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDelta))]
#endif
        public bool IsContentDelta => ContentDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatContentDeltaEvent value) => new StreamedChatResponseV2((global::G.ChatContentDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentDeltaEvent?(StreamedChatResponseV2 @this) => @this.ContentDelta;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatContentDeltaEvent? value)
        {
            ContentDelta = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that the content block has ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentEndEvent? ContentEnd { get; init; }
#else
        public global::G.ChatContentEndEvent? ContentEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentEnd))]
#endif
        public bool IsContentEnd => ContentEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatContentEndEvent value) => new StreamedChatResponseV2((global::G.ChatContentEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentEndEvent?(StreamedChatResponseV2 @this) => @this.ContentEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatContentEndEvent? value)
        {
            ContentEnd = value;
        }

        /// <summary>
        /// A streamed event which contains a delta of tool plan text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolPlanDeltaEvent? ToolPlanDelta { get; init; }
#else
        public global::G.ChatToolPlanDeltaEvent? ToolPlanDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolPlanDelta))]
#endif
        public bool IsToolPlanDelta => ToolPlanDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolPlanDeltaEvent value) => new StreamedChatResponseV2((global::G.ChatToolPlanDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolPlanDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolPlanDelta;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolPlanDeltaEvent? value)
        {
            ToolPlanDelta = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has started streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallStartEvent? ToolCallStart { get; init; }
#else
        public global::G.ChatToolCallStartEvent? ToolCallStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallStart))]
#endif
        public bool IsToolCallStart => ToolCallStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolCallStartEvent value) => new StreamedChatResponseV2((global::G.ChatToolCallStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallStartEvent?(StreamedChatResponseV2 @this) => @this.ToolCallStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolCallStartEvent? value)
        {
            ToolCallStart = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a delta in tool call arguments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallDeltaEvent? ToolCallDelta { get; init; }
#else
        public global::G.ChatToolCallDeltaEvent? ToolCallDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallDelta))]
#endif
        public bool IsToolCallDelta => ToolCallDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolCallDeltaEvent value) => new StreamedChatResponseV2((global::G.ChatToolCallDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolCallDelta;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolCallDeltaEvent? value)
        {
            ToolCallDelta = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has finished streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallEndEvent? ToolCallEnd { get; init; }
#else
        public global::G.ChatToolCallEndEvent? ToolCallEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallEnd))]
#endif
        public bool IsToolCallEnd => ToolCallEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolCallEndEvent value) => new StreamedChatResponseV2((global::G.ChatToolCallEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallEndEvent?(StreamedChatResponseV2 @this) => @this.ToolCallEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolCallEndEvent? value)
        {
            ToolCallEnd = value;
        }

        /// <summary>
        /// A streamed event which signifies that the chat message has ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessageEndEvent? MessageEnd { get; init; }
#else
        public global::G.ChatMessageEndEvent? MessageEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageEnd))]
#endif
        public bool IsMessageEnd => MessageEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatMessageEndEvent value) => new StreamedChatResponseV2((global::G.ChatMessageEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageEndEvent?(StreamedChatResponseV2 @this) => @this.MessageEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatMessageEndEvent? value)
        {
            MessageEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatDebugEvent? Debug { get; init; }
#else
        public global::G.ChatDebugEvent? Debug { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Debug))]
#endif
        public bool IsDebug => Debug != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::G.ChatDebugEvent value) => new StreamedChatResponseV2((global::G.ChatDebugEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatDebugEvent?(StreamedChatResponseV2 @this) => @this.Debug;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatDebugEvent? value)
        {
            Debug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(
            global::G.StreamedChatResponseV2DiscriminatorType? type,
            global::G.ChatMessageStartEvent? messageStart,
            global::G.ChatContentStartEvent? contentStart,
            global::G.ChatContentDeltaEvent? contentDelta,
            global::G.ChatContentEndEvent? contentEnd,
            global::G.ChatToolPlanDeltaEvent? toolPlanDelta,
            global::G.ChatToolCallStartEvent? toolCallStart,
            global::G.ChatToolCallDeltaEvent? toolCallDelta,
            global::G.ChatToolCallEndEvent? toolCallEnd,
            global::G.ChatMessageEndEvent? messageEnd,
            global::G.ChatDebugEvent? debug
            )
        {
            Type = type;

            MessageStart = messageStart;
            ContentStart = contentStart;
            ContentDelta = contentDelta;
            ContentEnd = contentEnd;
            ToolPlanDelta = toolPlanDelta;
            ToolCallStart = toolCallStart;
            ToolCallDelta = toolCallDelta;
            ToolCallEnd = toolCallEnd;
            MessageEnd = messageEnd;
            Debug = debug;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Debug as object ??
            MessageEnd as object ??
            ToolCallEnd as object ??
            ToolCallDelta as object ??
            ToolCallStart as object ??
            ToolPlanDelta as object ??
            ContentEnd as object ??
            ContentDelta as object ??
            ContentStart as object ??
            MessageStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageStart?.ToString() ??
            ContentStart?.ToString() ??
            ContentDelta?.ToString() ??
            ContentEnd?.ToString() ??
            ToolPlanDelta?.ToString() ??
            ToolCallStart?.ToString() ??
            ToolCallDelta?.ToString() ??
            ToolCallEnd?.ToString() ??
            MessageEnd?.ToString() ??
            Debug?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatMessageStartEvent?, TResult>? messageStart = null,
            global::System.Func<global::G.ChatContentStartEvent?, TResult>? contentStart = null,
            global::System.Func<global::G.ChatContentDeltaEvent?, TResult>? contentDelta = null,
            global::System.Func<global::G.ChatContentEndEvent?, TResult>? contentEnd = null,
            global::System.Func<global::G.ChatToolPlanDeltaEvent?, TResult>? toolPlanDelta = null,
            global::System.Func<global::G.ChatToolCallStartEvent?, TResult>? toolCallStart = null,
            global::System.Func<global::G.ChatToolCallDeltaEvent?, TResult>? toolCallDelta = null,
            global::System.Func<global::G.ChatToolCallEndEvent?, TResult>? toolCallEnd = null,
            global::System.Func<global::G.ChatMessageEndEvent?, TResult>? messageEnd = null,
            global::System.Func<global::G.ChatDebugEvent?, TResult>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart && messageStart != null)
            {
                return messageStart(MessageStart!);
            }
            else if (IsContentStart && contentStart != null)
            {
                return contentStart(ContentStart!);
            }
            else if (IsContentDelta && contentDelta != null)
            {
                return contentDelta(ContentDelta!);
            }
            else if (IsContentEnd && contentEnd != null)
            {
                return contentEnd(ContentEnd!);
            }
            else if (IsToolPlanDelta && toolPlanDelta != null)
            {
                return toolPlanDelta(ToolPlanDelta!);
            }
            else if (IsToolCallStart && toolCallStart != null)
            {
                return toolCallStart(ToolCallStart!);
            }
            else if (IsToolCallDelta && toolCallDelta != null)
            {
                return toolCallDelta(ToolCallDelta!);
            }
            else if (IsToolCallEnd && toolCallEnd != null)
            {
                return toolCallEnd(ToolCallEnd!);
            }
            else if (IsMessageEnd && messageEnd != null)
            {
                return messageEnd(MessageEnd!);
            }
            else if (IsDebug && debug != null)
            {
                return debug(Debug!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatMessageStartEvent?>? messageStart = null,
            global::System.Action<global::G.ChatContentStartEvent?>? contentStart = null,
            global::System.Action<global::G.ChatContentDeltaEvent?>? contentDelta = null,
            global::System.Action<global::G.ChatContentEndEvent?>? contentEnd = null,
            global::System.Action<global::G.ChatToolPlanDeltaEvent?>? toolPlanDelta = null,
            global::System.Action<global::G.ChatToolCallStartEvent?>? toolCallStart = null,
            global::System.Action<global::G.ChatToolCallDeltaEvent?>? toolCallDelta = null,
            global::System.Action<global::G.ChatToolCallEndEvent?>? toolCallEnd = null,
            global::System.Action<global::G.ChatMessageEndEvent?>? messageEnd = null,
            global::System.Action<global::G.ChatDebugEvent?>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart)
            {
                messageStart?.Invoke(MessageStart!);
            }
            else if (IsContentStart)
            {
                contentStart?.Invoke(ContentStart!);
            }
            else if (IsContentDelta)
            {
                contentDelta?.Invoke(ContentDelta!);
            }
            else if (IsContentEnd)
            {
                contentEnd?.Invoke(ContentEnd!);
            }
            else if (IsToolPlanDelta)
            {
                toolPlanDelta?.Invoke(ToolPlanDelta!);
            }
            else if (IsToolCallStart)
            {
                toolCallStart?.Invoke(ToolCallStart!);
            }
            else if (IsToolCallDelta)
            {
                toolCallDelta?.Invoke(ToolCallDelta!);
            }
            else if (IsToolCallEnd)
            {
                toolCallEnd?.Invoke(ToolCallEnd!);
            }
            else if (IsMessageEnd)
            {
                messageEnd?.Invoke(MessageEnd!);
            }
            else if (IsDebug)
            {
                debug?.Invoke(Debug!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStart,
                typeof(global::G.ChatMessageStartEvent),
                ContentStart,
                typeof(global::G.ChatContentStartEvent),
                ContentDelta,
                typeof(global::G.ChatContentDeltaEvent),
                ContentEnd,
                typeof(global::G.ChatContentEndEvent),
                ToolPlanDelta,
                typeof(global::G.ChatToolPlanDeltaEvent),
                ToolCallStart,
                typeof(global::G.ChatToolCallStartEvent),
                ToolCallDelta,
                typeof(global::G.ChatToolCallDeltaEvent),
                ToolCallEnd,
                typeof(global::G.ChatToolCallEndEvent),
                MessageEnd,
                typeof(global::G.ChatMessageEndEvent),
                Debug,
                typeof(global::G.ChatDebugEvent),
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
        public bool Equals(StreamedChatResponseV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentStartEvent?>.Default.Equals(ContentStart, other.ContentStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentDeltaEvent?>.Default.Equals(ContentDelta, other.ContentDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentEndEvent?>.Default.Equals(ContentEnd, other.ContentEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolPlanDeltaEvent?>.Default.Equals(ToolPlanDelta, other.ToolPlanDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallStartEvent?>.Default.Equals(ToolCallStart, other.ToolCallStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallDeltaEvent?>.Default.Equals(ToolCallDelta, other.ToolCallDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallEndEvent?>.Default.Equals(ToolCallEnd, other.ToolCallEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessageEndEvent?>.Default.Equals(MessageEnd, other.MessageEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatDebugEvent?>.Default.Equals(Debug, other.Debug) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamedChatResponseV2 obj1, StreamedChatResponseV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamedChatResponseV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamedChatResponseV2 obj1, StreamedChatResponseV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamedChatResponseV2 o && Equals(o);
        }
    }
}
