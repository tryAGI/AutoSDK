//HintName: G.Models.StreamedChatResponse.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// StreamedChatResponse is returned in streaming mode (specified with `stream=True` in the request).
    /// </summary>
    public readonly partial struct StreamedChatResponse : global::System.IEquatable<StreamedChatResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamStartEvent? StreamStartEvent { get; init; }
#else
        public global::G.ChatStreamStartEvent? StreamStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamStartEvent))]
#endif
        public bool IsStreamStartEvent => StreamStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatStreamStartEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamStartEvent?(StreamedChatResponse @this) => @this.StreamStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatStreamStartEvent? value)
        {
            StreamStartEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatSearchQueriesGenerationEvent? SearchQueriesGenerationEvent { get; init; }
#else
        public global::G.ChatSearchQueriesGenerationEvent? SearchQueriesGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchQueriesGenerationEvent))]
#endif
        public bool IsSearchQueriesGenerationEvent => SearchQueriesGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatSearchQueriesGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchQueriesGenerationEvent?(StreamedChatResponse @this) => @this.SearchQueriesGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatSearchQueriesGenerationEvent? value)
        {
            SearchQueriesGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatSearchResultsEvent? SearchResultsEvent { get; init; }
#else
        public global::G.ChatSearchResultsEvent? SearchResultsEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResultsEvent))]
#endif
        public bool IsSearchResultsEvent => SearchResultsEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatSearchResultsEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchResultsEvent?(StreamedChatResponse @this) => @this.SearchResultsEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatSearchResultsEvent? value)
        {
            SearchResultsEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatTextGenerationEvent? TextGenerationEvent { get; init; }
#else
        public global::G.ChatTextGenerationEvent? TextGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGenerationEvent))]
#endif
        public bool IsTextGenerationEvent => TextGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatTextGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatTextGenerationEvent?(StreamedChatResponse @this) => @this.TextGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatTextGenerationEvent? value)
        {
            TextGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCitationGenerationEvent? CitationGenerationEvent { get; init; }
#else
        public global::G.ChatCitationGenerationEvent? CitationGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationGenerationEvent))]
#endif
        public bool IsCitationGenerationEvent => CitationGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatCitationGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCitationGenerationEvent?(StreamedChatResponse @this) => @this.CitationGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatCitationGenerationEvent? value)
        {
            CitationGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallsGenerationEvent? ToolCallsGenerationEvent { get; init; }
#else
        public global::G.ChatToolCallsGenerationEvent? ToolCallsGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsGenerationEvent))]
#endif
        public bool IsToolCallsGenerationEvent => ToolCallsGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatToolCallsGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallsGenerationEvent?(StreamedChatResponse @this) => @this.ToolCallsGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatToolCallsGenerationEvent? value)
        {
            ToolCallsGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEndEvent? StreamEndEvent { get; init; }
#else
        public global::G.ChatStreamEndEvent? StreamEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEndEvent))]
#endif
        public bool IsStreamEndEvent => StreamEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatStreamEndEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEndEvent?(StreamedChatResponse @this) => @this.StreamEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatStreamEndEvent? value)
        {
            StreamEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallsChunkEvent? ToolCallsChunkEvent { get; init; }
#else
        public global::G.ChatToolCallsChunkEvent? ToolCallsChunkEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsChunkEvent))]
#endif
        public bool IsToolCallsChunkEvent => ToolCallsChunkEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatToolCallsChunkEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallsChunkEvent?(StreamedChatResponse @this) => @this.ToolCallsChunkEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatToolCallsChunkEvent? value)
        {
            ToolCallsChunkEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(
            global::G.ChatStreamStartEvent? streamStartEvent,
            global::G.ChatSearchQueriesGenerationEvent? searchQueriesGenerationEvent,
            global::G.ChatSearchResultsEvent? searchResultsEvent,
            global::G.ChatTextGenerationEvent? textGenerationEvent,
            global::G.ChatCitationGenerationEvent? citationGenerationEvent,
            global::G.ChatToolCallsGenerationEvent? toolCallsGenerationEvent,
            global::G.ChatStreamEndEvent? streamEndEvent,
            global::G.ChatToolCallsChunkEvent? toolCallsChunkEvent
            )
        {
            StreamStartEvent = streamStartEvent;
            SearchQueriesGenerationEvent = searchQueriesGenerationEvent;
            SearchResultsEvent = searchResultsEvent;
            TextGenerationEvent = textGenerationEvent;
            CitationGenerationEvent = citationGenerationEvent;
            ToolCallsGenerationEvent = toolCallsGenerationEvent;
            StreamEndEvent = streamEndEvent;
            ToolCallsChunkEvent = toolCallsChunkEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCallsChunkEvent as object ??
            StreamEndEvent as object ??
            ToolCallsGenerationEvent as object ??
            CitationGenerationEvent as object ??
            TextGenerationEvent as object ??
            SearchResultsEvent as object ??
            SearchQueriesGenerationEvent as object ??
            StreamStartEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && IsToolCallsChunkEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamStartEvent?, TResult>? streamStartEvent = null,
            global::System.Func<global::G.ChatSearchQueriesGenerationEvent?, TResult>? searchQueriesGenerationEvent = null,
            global::System.Func<global::G.ChatSearchResultsEvent?, TResult>? searchResultsEvent = null,
            global::System.Func<global::G.ChatTextGenerationEvent?, TResult>? textGenerationEvent = null,
            global::System.Func<global::G.ChatCitationGenerationEvent?, TResult>? citationGenerationEvent = null,
            global::System.Func<global::G.ChatToolCallsGenerationEvent?, TResult>? toolCallsGenerationEvent = null,
            global::System.Func<global::G.ChatStreamEndEvent?, TResult>? streamEndEvent = null,
            global::System.Func<global::G.ChatToolCallsChunkEvent?, TResult>? toolCallsChunkEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStartEvent && streamStartEvent != null)
            {
                return streamStartEvent(StreamStartEvent!);
            }
            else if (IsSearchQueriesGenerationEvent && searchQueriesGenerationEvent != null)
            {
                return searchQueriesGenerationEvent(SearchQueriesGenerationEvent!);
            }
            else if (IsSearchResultsEvent && searchResultsEvent != null)
            {
                return searchResultsEvent(SearchResultsEvent!);
            }
            else if (IsTextGenerationEvent && textGenerationEvent != null)
            {
                return textGenerationEvent(TextGenerationEvent!);
            }
            else if (IsCitationGenerationEvent && citationGenerationEvent != null)
            {
                return citationGenerationEvent(CitationGenerationEvent!);
            }
            else if (IsToolCallsGenerationEvent && toolCallsGenerationEvent != null)
            {
                return toolCallsGenerationEvent(ToolCallsGenerationEvent!);
            }
            else if (IsStreamEndEvent && streamEndEvent != null)
            {
                return streamEndEvent(StreamEndEvent!);
            }
            else if (IsToolCallsChunkEvent && toolCallsChunkEvent != null)
            {
                return toolCallsChunkEvent(ToolCallsChunkEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamStartEvent?>? streamStartEvent = null,
            global::System.Action<global::G.ChatSearchQueriesGenerationEvent?>? searchQueriesGenerationEvent = null,
            global::System.Action<global::G.ChatSearchResultsEvent?>? searchResultsEvent = null,
            global::System.Action<global::G.ChatTextGenerationEvent?>? textGenerationEvent = null,
            global::System.Action<global::G.ChatCitationGenerationEvent?>? citationGenerationEvent = null,
            global::System.Action<global::G.ChatToolCallsGenerationEvent?>? toolCallsGenerationEvent = null,
            global::System.Action<global::G.ChatStreamEndEvent?>? streamEndEvent = null,
            global::System.Action<global::G.ChatToolCallsChunkEvent?>? toolCallsChunkEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStartEvent)
            {
                streamStartEvent?.Invoke(StreamStartEvent!);
            }
            else if (IsSearchQueriesGenerationEvent)
            {
                searchQueriesGenerationEvent?.Invoke(SearchQueriesGenerationEvent!);
            }
            else if (IsSearchResultsEvent)
            {
                searchResultsEvent?.Invoke(SearchResultsEvent!);
            }
            else if (IsTextGenerationEvent)
            {
                textGenerationEvent?.Invoke(TextGenerationEvent!);
            }
            else if (IsCitationGenerationEvent)
            {
                citationGenerationEvent?.Invoke(CitationGenerationEvent!);
            }
            else if (IsToolCallsGenerationEvent)
            {
                toolCallsGenerationEvent?.Invoke(ToolCallsGenerationEvent!);
            }
            else if (IsStreamEndEvent)
            {
                streamEndEvent?.Invoke(StreamEndEvent!);
            }
            else if (IsToolCallsChunkEvent)
            {
                toolCallsChunkEvent?.Invoke(ToolCallsChunkEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamStartEvent,
                typeof(global::G.ChatStreamStartEvent),
                SearchQueriesGenerationEvent,
                typeof(global::G.ChatSearchQueriesGenerationEvent),
                SearchResultsEvent,
                typeof(global::G.ChatSearchResultsEvent),
                TextGenerationEvent,
                typeof(global::G.ChatTextGenerationEvent),
                CitationGenerationEvent,
                typeof(global::G.ChatCitationGenerationEvent),
                ToolCallsGenerationEvent,
                typeof(global::G.ChatToolCallsGenerationEvent),
                StreamEndEvent,
                typeof(global::G.ChatStreamEndEvent),
                ToolCallsChunkEvent,
                typeof(global::G.ChatToolCallsChunkEvent),
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
        public bool Equals(StreamedChatResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamStartEvent?>.Default.Equals(StreamStartEvent, other.StreamStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchQueriesGenerationEvent?>.Default.Equals(SearchQueriesGenerationEvent, other.SearchQueriesGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchResultsEvent?>.Default.Equals(SearchResultsEvent, other.SearchResultsEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatTextGenerationEvent?>.Default.Equals(TextGenerationEvent, other.TextGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCitationGenerationEvent?>.Default.Equals(CitationGenerationEvent, other.CitationGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallsGenerationEvent?>.Default.Equals(ToolCallsGenerationEvent, other.ToolCallsGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEndEvent?>.Default.Equals(StreamEndEvent, other.StreamEndEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallsChunkEvent?>.Default.Equals(ToolCallsChunkEvent, other.ToolCallsChunkEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamedChatResponse obj1, StreamedChatResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamedChatResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamedChatResponse obj1, StreamedChatResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamedChatResponse o && Equals(o);
        }
    }
}
