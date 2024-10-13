//HintName: G.Models.StreamedChatResponseV2.g.cs
using System.Linq;
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
        /// A streamed event which signifies that a stream has started.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatMessageStartEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageStartEvent?(StreamedChatResponseV2 @this) => @this.MessageStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatMessageStartEvent? value)
        {
            MessageStartEvent = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that a new content block has started.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatContentStartEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentStartEvent?(StreamedChatResponseV2 @this) => @this.ContentStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatContentStartEvent? value)
        {
            ContentStartEvent = value;
        }

        /// <summary>
        /// A streamed delta event which contains a delta of chat text content.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatContentDeltaEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentDeltaEvent?(StreamedChatResponseV2 @this) => @this.ContentDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatContentDeltaEvent? value)
        {
            ContentDeltaEvent = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that the content block has ended.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatContentEndEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentEndEvent?(StreamedChatResponseV2 @this) => @this.ContentEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatContentEndEvent? value)
        {
            ContentEndEvent = value;
        }

        /// <summary>
        /// A streamed event which contains a delta of tool plan text.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolPlanDeltaEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolPlanDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolPlanDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolPlanDeltaEvent? value)
        {
            ToolPlanDeltaEvent = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has started streaming.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolCallStartEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallStartEvent?(StreamedChatResponseV2 @this) => @this.ToolCallStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolCallStartEvent? value)
        {
            ToolCallStartEvent = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a delta in tool call arguments.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolCallDeltaEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolCallDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolCallDeltaEvent? value)
        {
            ToolCallDeltaEvent = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has finished streaming.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatToolCallEndEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallEndEvent?(StreamedChatResponseV2 @this) => @this.ToolCallEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatToolCallEndEvent? value)
        {
            ToolCallEndEvent = value;
        }

        /// <summary>
        /// A streamed event which signifies that the chat message has ended.
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
        public static implicit operator StreamedChatResponseV2(global::G.ChatMessageEndEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageEndEvent?(StreamedChatResponseV2 @this) => @this.MessageEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::G.ChatMessageEndEvent? value)
        {
            MessageEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(
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
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatMessageStartEvent?, TResult>? messageStartEvent = null,
            global::System.Func<global::G.ChatContentStartEvent?, TResult>? contentStartEvent = null,
            global::System.Func<global::G.ChatContentDeltaEvent?, TResult>? contentDeltaEvent = null,
            global::System.Func<global::G.ChatContentEndEvent?, TResult>? contentEndEvent = null,
            global::System.Func<global::G.ChatToolPlanDeltaEvent?, TResult>? toolPlanDeltaEvent = null,
            global::System.Func<global::G.ChatToolCallStartEvent?, TResult>? toolCallStartEvent = null,
            global::System.Func<global::G.ChatToolCallDeltaEvent?, TResult>? toolCallDeltaEvent = null,
            global::System.Func<global::G.ChatToolCallEndEvent?, TResult>? toolCallEndEvent = null,
            global::System.Func<global::G.ChatMessageEndEvent?, TResult>? messageEndEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStartEvent && messageStartEvent != null)
            {
                return messageStartEvent(MessageStartEvent!);
            }
            else if (IsContentStartEvent && contentStartEvent != null)
            {
                return contentStartEvent(ContentStartEvent!);
            }
            else if (IsContentDeltaEvent && contentDeltaEvent != null)
            {
                return contentDeltaEvent(ContentDeltaEvent!);
            }
            else if (IsContentEndEvent && contentEndEvent != null)
            {
                return contentEndEvent(ContentEndEvent!);
            }
            else if (IsToolPlanDeltaEvent && toolPlanDeltaEvent != null)
            {
                return toolPlanDeltaEvent(ToolPlanDeltaEvent!);
            }
            else if (IsToolCallStartEvent && toolCallStartEvent != null)
            {
                return toolCallStartEvent(ToolCallStartEvent!);
            }
            else if (IsToolCallDeltaEvent && toolCallDeltaEvent != null)
            {
                return toolCallDeltaEvent(ToolCallDeltaEvent!);
            }
            else if (IsToolCallEndEvent && toolCallEndEvent != null)
            {
                return toolCallEndEvent(ToolCallEndEvent!);
            }
            else if (IsMessageEndEvent && messageEndEvent != null)
            {
                return messageEndEvent(MessageEndEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatMessageStartEvent?>? messageStartEvent = null,
            global::System.Action<global::G.ChatContentStartEvent?>? contentStartEvent = null,
            global::System.Action<global::G.ChatContentDeltaEvent?>? contentDeltaEvent = null,
            global::System.Action<global::G.ChatContentEndEvent?>? contentEndEvent = null,
            global::System.Action<global::G.ChatToolPlanDeltaEvent?>? toolPlanDeltaEvent = null,
            global::System.Action<global::G.ChatToolCallStartEvent?>? toolCallStartEvent = null,
            global::System.Action<global::G.ChatToolCallDeltaEvent?>? toolCallDeltaEvent = null,
            global::System.Action<global::G.ChatToolCallEndEvent?>? toolCallEndEvent = null,
            global::System.Action<global::G.ChatMessageEndEvent?>? messageEndEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStartEvent)
            {
                messageStartEvent?.Invoke(MessageStartEvent!);
            }
            else if (IsContentStartEvent)
            {
                contentStartEvent?.Invoke(ContentStartEvent!);
            }
            else if (IsContentDeltaEvent)
            {
                contentDeltaEvent?.Invoke(ContentDeltaEvent!);
            }
            else if (IsContentEndEvent)
            {
                contentEndEvent?.Invoke(ContentEndEvent!);
            }
            else if (IsToolPlanDeltaEvent)
            {
                toolPlanDeltaEvent?.Invoke(ToolPlanDeltaEvent!);
            }
            else if (IsToolCallStartEvent)
            {
                toolCallStartEvent?.Invoke(ToolCallStartEvent!);
            }
            else if (IsToolCallDeltaEvent)
            {
                toolCallDeltaEvent?.Invoke(ToolCallDeltaEvent!);
            }
            else if (IsToolCallEndEvent)
            {
                toolCallEndEvent?.Invoke(ToolCallEndEvent!);
            }
            else if (IsMessageEndEvent)
            {
                messageEndEvent?.Invoke(MessageEndEvent!);
            }
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
        public bool Equals(StreamedChatResponseV2 other)
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


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.StreamedChatResponseV2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.StreamedChatResponseV2),
                jsonSerializerContext) as global::G.StreamedChatResponseV2?;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.StreamedChatResponseV2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.StreamedChatResponseV2>(
                json,
                jsonSerializerOptions);
        }

    }
}
