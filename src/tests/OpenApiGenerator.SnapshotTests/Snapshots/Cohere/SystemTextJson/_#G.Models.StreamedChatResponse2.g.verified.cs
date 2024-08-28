//HintName: G.Models.StreamedChatResponse2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// StreamedChatResponse is returned in streaming mode (specified with `stream=True` in the request).
    /// </summary>
    public readonly partial struct StreamedChatResponse2 : global::System.IEquatable<StreamedChatResponse2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessageStartEvent? MessageStartEvent { get; init; }
#else
        public global::G.ChatMessageStartEvent? MessageStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStartEvent))]
#endif
        public bool IsMessageStartEvent => MessageStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatMessageStartEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageStartEvent?(StreamedChatResponse2 @this) => @this.MessageStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatMessageStartEvent? value)
        {
            MessageStartEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentStartEvent? ContentStartEvent { get; init; }
#else
        public global::G.ChatContentStartEvent? ContentStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentStartEvent))]
#endif
        public bool IsContentStartEvent => ContentStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatContentStartEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentStartEvent?(StreamedChatResponse2 @this) => @this.ContentStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatContentStartEvent? value)
        {
            ContentStartEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentDeltaEvent? ContentDeltaEvent { get; init; }
#else
        public global::G.ChatContentDeltaEvent? ContentDeltaEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDeltaEvent))]
#endif
        public bool IsContentDeltaEvent => ContentDeltaEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatContentDeltaEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentDeltaEvent?(StreamedChatResponse2 @this) => @this.ContentDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatContentDeltaEvent? value)
        {
            ContentDeltaEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatContentEndEvent? ContentEndEvent { get; init; }
#else
        public global::G.ChatContentEndEvent? ContentEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentEndEvent))]
#endif
        public bool IsContentEndEvent => ContentEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatContentEndEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentEndEvent?(StreamedChatResponse2 @this) => @this.ContentEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatContentEndEvent? value)
        {
            ContentEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolPlanDeltaEvent? ToolPlanDeltaEvent { get; init; }
#else
        public global::G.ChatToolPlanDeltaEvent? ToolPlanDeltaEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolPlanDeltaEvent))]
#endif
        public bool IsToolPlanDeltaEvent => ToolPlanDeltaEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatToolPlanDeltaEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolPlanDeltaEvent?(StreamedChatResponse2 @this) => @this.ToolPlanDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatToolPlanDeltaEvent? value)
        {
            ToolPlanDeltaEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallStartEvent? ToolCallStartEvent { get; init; }
#else
        public global::G.ChatToolCallStartEvent? ToolCallStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallStartEvent))]
#endif
        public bool IsToolCallStartEvent => ToolCallStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatToolCallStartEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallStartEvent?(StreamedChatResponse2 @this) => @this.ToolCallStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatToolCallStartEvent? value)
        {
            ToolCallStartEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallDeltaEvent? ToolCallDeltaEvent { get; init; }
#else
        public global::G.ChatToolCallDeltaEvent? ToolCallDeltaEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallDeltaEvent))]
#endif
        public bool IsToolCallDeltaEvent => ToolCallDeltaEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatToolCallDeltaEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallDeltaEvent?(StreamedChatResponse2 @this) => @this.ToolCallDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatToolCallDeltaEvent? value)
        {
            ToolCallDeltaEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallEndEvent? ToolCallEndEvent { get; init; }
#else
        public global::G.ChatToolCallEndEvent? ToolCallEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallEndEvent))]
#endif
        public bool IsToolCallEndEvent => ToolCallEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatToolCallEndEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallEndEvent?(StreamedChatResponse2 @this) => @this.ToolCallEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatToolCallEndEvent? value)
        {
            ToolCallEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessageEndEvent? MessageEndEvent { get; init; }
#else
        public global::G.ChatMessageEndEvent? MessageEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageEndEvent))]
#endif
        public bool IsMessageEndEvent => MessageEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse2(global::G.ChatMessageEndEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageEndEvent?(StreamedChatResponse2 @this) => @this.MessageEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::G.ChatMessageEndEvent? value)
        {
            MessageEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(
            global::G.ChatMessageStartEvent? messageStartEvent,
            global::G.ChatContentStartEvent? contentStartEvent,
            global::G.ChatContentDeltaEvent? contentDeltaEvent,
            global::G.ChatContentEndEvent? contentEndEvent,
            global::G.ChatToolPlanDeltaEvent? toolPlanDeltaEvent,
            global::G.ChatToolCallStartEvent? toolCallStartEvent,
            global::G.ChatToolCallDeltaEvent? toolCallDeltaEvent,
            global::G.ChatToolCallEndEvent? toolCallEndEvent,
            global::G.ChatMessageEndEvent? messageEndEvent
            )
        {
            MessageStartEvent = messageStartEvent;
            ContentStartEvent = contentStartEvent;
            ContentDeltaEvent = contentDeltaEvent;
            ContentEndEvent = contentEndEvent;
            ToolPlanDeltaEvent = toolPlanDeltaEvent;
            ToolCallStartEvent = toolCallStartEvent;
            ToolCallDeltaEvent = toolCallDeltaEvent;
            ToolCallEndEvent = toolCallEndEvent;
            MessageEndEvent = messageEndEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageEndEvent as object ??
            ToolCallEndEvent as object ??
            ToolCallDeltaEvent as object ??
            ToolCallStartEvent as object ??
            ToolPlanDeltaEvent as object ??
            ContentEndEvent as object ??
            ContentDeltaEvent as object ??
            ContentStartEvent as object ??
            MessageStartEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && IsMessageEndEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStartEvent,
                typeof(global::G.ChatMessageStartEvent),
                ContentStartEvent,
                typeof(global::G.ChatContentStartEvent),
                ContentDeltaEvent,
                typeof(global::G.ChatContentDeltaEvent),
                ContentEndEvent,
                typeof(global::G.ChatContentEndEvent),
                ToolPlanDeltaEvent,
                typeof(global::G.ChatToolPlanDeltaEvent),
                ToolCallStartEvent,
                typeof(global::G.ChatToolCallStartEvent),
                ToolCallDeltaEvent,
                typeof(global::G.ChatToolCallDeltaEvent),
                ToolCallEndEvent,
                typeof(global::G.ChatToolCallEndEvent),
                MessageEndEvent,
                typeof(global::G.ChatMessageEndEvent),
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
        public bool Equals(StreamedChatResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessageStartEvent?>.Default.Equals(MessageStartEvent, other.MessageStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentStartEvent?>.Default.Equals(ContentStartEvent, other.ContentStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentDeltaEvent?>.Default.Equals(ContentDeltaEvent, other.ContentDeltaEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentEndEvent?>.Default.Equals(ContentEndEvent, other.ContentEndEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolPlanDeltaEvent?>.Default.Equals(ToolPlanDeltaEvent, other.ToolPlanDeltaEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallStartEvent?>.Default.Equals(ToolCallStartEvent, other.ToolCallStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallDeltaEvent?>.Default.Equals(ToolCallDeltaEvent, other.ToolCallDeltaEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallEndEvent?>.Default.Equals(ToolCallEndEvent, other.ToolCallEndEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessageEndEvent?>.Default.Equals(MessageEndEvent, other.MessageEndEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamedChatResponse2 obj1, StreamedChatResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamedChatResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamedChatResponse2 obj1, StreamedChatResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamedChatResponse2 o && Equals(o);
        }
    }
}
