//HintName: G.Models.StreamedChatResponse.g.cs
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
        public global::G.StreamedChatResponseDiscriminatorEventType? EventType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamStartEvent? StreamStart { get; init; }
#else
        public global::G.ChatStreamStartEvent? StreamStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamStart))]
#endif
        public bool IsStreamStart => StreamStart != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatStreamStartEvent? value)
        {
            value = StreamStart;
            return IsStreamStart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatStreamStartEvent PickStreamStart() => StreamStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamStart' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatSearchQueriesGenerationEvent? SearchQueriesGeneration { get; init; }
#else
        public global::G.ChatSearchQueriesGenerationEvent? SearchQueriesGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchQueriesGeneration))]
#endif
        public bool IsSearchQueriesGeneration => SearchQueriesGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchQueriesGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatSearchQueriesGenerationEvent? value)
        {
            value = SearchQueriesGeneration;
            return IsSearchQueriesGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatSearchQueriesGenerationEvent PickSearchQueriesGeneration() => SearchQueriesGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchQueriesGeneration' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatSearchResultsEvent? SearchResults { get; init; }
#else
        public global::G.ChatSearchResultsEvent? SearchResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResults))]
#endif
        public bool IsSearchResults => SearchResults != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchResults(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatSearchResultsEvent? value)
        {
            value = SearchResults;
            return IsSearchResults;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatSearchResultsEvent PickSearchResults() => SearchResults is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResults' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatTextGenerationEvent? TextGeneration { get; init; }
#else
        public global::G.ChatTextGenerationEvent? TextGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGeneration))]
#endif
        public bool IsTextGeneration => TextGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatTextGenerationEvent? value)
        {
            value = TextGeneration;
            return IsTextGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatTextGenerationEvent PickTextGeneration() => TextGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextGeneration' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCitationGenerationEvent? CitationGeneration { get; init; }
#else
        public global::G.ChatCitationGenerationEvent? CitationGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationGeneration))]
#endif
        public bool IsCitationGeneration => CitationGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCitationGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatCitationGenerationEvent? value)
        {
            value = CitationGeneration;
            return IsCitationGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCitationGenerationEvent PickCitationGeneration() => CitationGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CitationGeneration' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallsGenerationEvent? ToolCallsGeneration { get; init; }
#else
        public global::G.ChatToolCallsGenerationEvent? ToolCallsGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsGeneration))]
#endif
        public bool IsToolCallsGeneration => ToolCallsGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolCallsGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatToolCallsGenerationEvent? value)
        {
            value = ToolCallsGeneration;
            return IsToolCallsGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatToolCallsGenerationEvent PickToolCallsGeneration() => ToolCallsGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallsGeneration' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEndEvent? StreamEnd { get; init; }
#else
        public global::G.ChatStreamEndEvent? StreamEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnd))]
#endif
        public bool IsStreamEnd => StreamEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatStreamEndEvent? value)
        {
            value = StreamEnd;
            return IsStreamEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatStreamEndEvent PickStreamEnd() => StreamEnd is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEnd' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallsChunkEvent? ToolCallsChunk { get; init; }
#else
        public global::G.ChatToolCallsChunkEvent? ToolCallsChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsChunk))]
#endif
        public bool IsToolCallsChunk => ToolCallsChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolCallsChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatToolCallsChunkEvent? value)
        {
            value = ToolCallsChunk;
            return IsToolCallsChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatToolCallsChunkEvent PickToolCallsChunk() => ToolCallsChunk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallsChunk' but the value was {ToString()}.");

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
        public bool TryPickDebug(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatDebugEvent? value)
        {
            value = Debug;
            return IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatDebugEvent PickDebug() => Debug is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Debug' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatStreamStartEvent value) => new StreamedChatResponse((global::G.ChatStreamStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamStartEvent?(StreamedChatResponse @this) => @this.StreamStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatStreamStartEvent? value)
        {
            StreamStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromStreamStart(global::G.ChatStreamStartEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatSearchQueriesGenerationEvent value) => new StreamedChatResponse((global::G.ChatSearchQueriesGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchQueriesGenerationEvent?(StreamedChatResponse @this) => @this.SearchQueriesGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatSearchQueriesGenerationEvent? value)
        {
            SearchQueriesGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromSearchQueriesGeneration(global::G.ChatSearchQueriesGenerationEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatSearchResultsEvent value) => new StreamedChatResponse((global::G.ChatSearchResultsEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchResultsEvent?(StreamedChatResponse @this) => @this.SearchResults;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatSearchResultsEvent? value)
        {
            SearchResults = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromSearchResults(global::G.ChatSearchResultsEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatTextGenerationEvent value) => new StreamedChatResponse((global::G.ChatTextGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatTextGenerationEvent?(StreamedChatResponse @this) => @this.TextGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatTextGenerationEvent? value)
        {
            TextGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromTextGeneration(global::G.ChatTextGenerationEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatCitationGenerationEvent value) => new StreamedChatResponse((global::G.ChatCitationGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCitationGenerationEvent?(StreamedChatResponse @this) => @this.CitationGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatCitationGenerationEvent? value)
        {
            CitationGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromCitationGeneration(global::G.ChatCitationGenerationEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatToolCallsGenerationEvent value) => new StreamedChatResponse((global::G.ChatToolCallsGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallsGenerationEvent?(StreamedChatResponse @this) => @this.ToolCallsGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatToolCallsGenerationEvent? value)
        {
            ToolCallsGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromToolCallsGeneration(global::G.ChatToolCallsGenerationEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatStreamEndEvent value) => new StreamedChatResponse((global::G.ChatStreamEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEndEvent?(StreamedChatResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatStreamEndEvent? value)
        {
            StreamEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromStreamEnd(global::G.ChatStreamEndEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatToolCallsChunkEvent value) => new StreamedChatResponse((global::G.ChatToolCallsChunkEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallsChunkEvent?(StreamedChatResponse @this) => @this.ToolCallsChunk;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatToolCallsChunkEvent? value)
        {
            ToolCallsChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromToolCallsChunk(global::G.ChatToolCallsChunkEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::G.ChatDebugEvent value) => new StreamedChatResponse((global::G.ChatDebugEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatDebugEvent?(StreamedChatResponse @this) => @this.Debug;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::G.ChatDebugEvent? value)
        {
            Debug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamedChatResponse FromDebug(global::G.ChatDebugEvent? value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(
            global::G.StreamedChatResponseDiscriminatorEventType? eventType,
            global::G.ChatStreamStartEvent? streamStart,
            global::G.ChatSearchQueriesGenerationEvent? searchQueriesGeneration,
            global::G.ChatSearchResultsEvent? searchResults,
            global::G.ChatTextGenerationEvent? textGeneration,
            global::G.ChatCitationGenerationEvent? citationGeneration,
            global::G.ChatToolCallsGenerationEvent? toolCallsGeneration,
            global::G.ChatStreamEndEvent? streamEnd,
            global::G.ChatToolCallsChunkEvent? toolCallsChunk,
            global::G.ChatDebugEvent? debug
            )
        {
            EventType = eventType;

            StreamStart = streamStart;
            SearchQueriesGeneration = searchQueriesGeneration;
            SearchResults = searchResults;
            TextGeneration = textGeneration;
            CitationGeneration = citationGeneration;
            ToolCallsGeneration = toolCallsGeneration;
            StreamEnd = streamEnd;
            ToolCallsChunk = toolCallsChunk;
            Debug = debug;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Debug as object ??
            ToolCallsChunk as object ??
            StreamEnd as object ??
            ToolCallsGeneration as object ??
            CitationGeneration as object ??
            TextGeneration as object ??
            SearchResults as object ??
            SearchQueriesGeneration as object ??
            StreamStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamStart?.ToString() ??
            SearchQueriesGeneration?.ToString() ??
            SearchResults?.ToString() ??
            TextGeneration?.ToString() ??
            CitationGeneration?.ToString() ??
            ToolCallsGeneration?.ToString() ??
            StreamEnd?.ToString() ??
            ToolCallsChunk?.ToString() ??
            Debug?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamStartEvent?, TResult>? streamStart = null,
            global::System.Func<global::G.ChatSearchQueriesGenerationEvent?, TResult>? searchQueriesGeneration = null,
            global::System.Func<global::G.ChatSearchResultsEvent?, TResult>? searchResults = null,
            global::System.Func<global::G.ChatTextGenerationEvent?, TResult>? textGeneration = null,
            global::System.Func<global::G.ChatCitationGenerationEvent?, TResult>? citationGeneration = null,
            global::System.Func<global::G.ChatToolCallsGenerationEvent?, TResult>? toolCallsGeneration = null,
            global::System.Func<global::G.ChatStreamEndEvent?, TResult>? streamEnd = null,
            global::System.Func<global::G.ChatToolCallsChunkEvent?, TResult>? toolCallsChunk = null,
            global::System.Func<global::G.ChatDebugEvent?, TResult>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StreamStart is { } __value0 && streamStart != null)
            {
                return streamStart(__value0);
            }
            else if (SearchQueriesGeneration is { } __value1 && searchQueriesGeneration != null)
            {
                return searchQueriesGeneration(__value1);
            }
            else if (SearchResults is { } __value2 && searchResults != null)
            {
                return searchResults(__value2);
            }
            else if (TextGeneration is { } __value3 && textGeneration != null)
            {
                return textGeneration(__value3);
            }
            else if (CitationGeneration is { } __value4 && citationGeneration != null)
            {
                return citationGeneration(__value4);
            }
            else if (ToolCallsGeneration is { } __value5 && toolCallsGeneration != null)
            {
                return toolCallsGeneration(__value5);
            }
            else if (StreamEnd is { } __value6 && streamEnd != null)
            {
                return streamEnd(__value6);
            }
            else if (ToolCallsChunk is { } __value7 && toolCallsChunk != null)
            {
                return toolCallsChunk(__value7);
            }
            else if (Debug is { } __value8 && debug != null)
            {
                return debug(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamStartEvent?>? streamStart = null,

            global::System.Action<global::G.ChatSearchQueriesGenerationEvent?>? searchQueriesGeneration = null,

            global::System.Action<global::G.ChatSearchResultsEvent?>? searchResults = null,

            global::System.Action<global::G.ChatTextGenerationEvent?>? textGeneration = null,

            global::System.Action<global::G.ChatCitationGenerationEvent?>? citationGeneration = null,

            global::System.Action<global::G.ChatToolCallsGenerationEvent?>? toolCallsGeneration = null,

            global::System.Action<global::G.ChatStreamEndEvent?>? streamEnd = null,

            global::System.Action<global::G.ChatToolCallsChunkEvent?>? toolCallsChunk = null,

            global::System.Action<global::G.ChatDebugEvent?>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StreamStart is { } __value0)
            {
                streamStart?.Invoke(__value0);
            }
            else if (SearchQueriesGeneration is { } __value1)
            {
                searchQueriesGeneration?.Invoke(__value1);
            }
            else if (SearchResults is { } __value2)
            {
                searchResults?.Invoke(__value2);
            }
            else if (TextGeneration is { } __value3)
            {
                textGeneration?.Invoke(__value3);
            }
            else if (CitationGeneration is { } __value4)
            {
                citationGeneration?.Invoke(__value4);
            }
            else if (ToolCallsGeneration is { } __value5)
            {
                toolCallsGeneration?.Invoke(__value5);
            }
            else if (StreamEnd is { } __value6)
            {
                streamEnd?.Invoke(__value6);
            }
            else if (ToolCallsChunk is { } __value7)
            {
                toolCallsChunk?.Invoke(__value7);
            }
            else if (Debug is { } __value8)
            {
                debug?.Invoke(__value8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ChatStreamStartEvent?>? streamStart = null,
            global::System.Action<global::G.ChatSearchQueriesGenerationEvent?>? searchQueriesGeneration = null,
            global::System.Action<global::G.ChatSearchResultsEvent?>? searchResults = null,
            global::System.Action<global::G.ChatTextGenerationEvent?>? textGeneration = null,
            global::System.Action<global::G.ChatCitationGenerationEvent?>? citationGeneration = null,
            global::System.Action<global::G.ChatToolCallsGenerationEvent?>? toolCallsGeneration = null,
            global::System.Action<global::G.ChatStreamEndEvent?>? streamEnd = null,
            global::System.Action<global::G.ChatToolCallsChunkEvent?>? toolCallsChunk = null,
            global::System.Action<global::G.ChatDebugEvent?>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StreamStart is { } __value0)
            {
                streamStart?.Invoke(__value0);
            }
            else if (SearchQueriesGeneration is { } __value1)
            {
                searchQueriesGeneration?.Invoke(__value1);
            }
            else if (SearchResults is { } __value2)
            {
                searchResults?.Invoke(__value2);
            }
            else if (TextGeneration is { } __value3)
            {
                textGeneration?.Invoke(__value3);
            }
            else if (CitationGeneration is { } __value4)
            {
                citationGeneration?.Invoke(__value4);
            }
            else if (ToolCallsGeneration is { } __value5)
            {
                toolCallsGeneration?.Invoke(__value5);
            }
            else if (StreamEnd is { } __value6)
            {
                streamEnd?.Invoke(__value6);
            }
            else if (ToolCallsChunk is { } __value7)
            {
                toolCallsChunk?.Invoke(__value7);
            }
            else if (Debug is { } __value8)
            {
                debug?.Invoke(__value8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamStart,
                typeof(global::G.ChatStreamStartEvent),
                SearchQueriesGeneration,
                typeof(global::G.ChatSearchQueriesGenerationEvent),
                SearchResults,
                typeof(global::G.ChatSearchResultsEvent),
                TextGeneration,
                typeof(global::G.ChatTextGenerationEvent),
                CitationGeneration,
                typeof(global::G.ChatCitationGenerationEvent),
                ToolCallsGeneration,
                typeof(global::G.ChatToolCallsGenerationEvent),
                StreamEnd,
                typeof(global::G.ChatStreamEndEvent),
                ToolCallsChunk,
                typeof(global::G.ChatToolCallsChunkEvent),
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
        public bool Equals(StreamedChatResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamStartEvent?>.Default.Equals(StreamStart, other.StreamStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchQueriesGenerationEvent?>.Default.Equals(SearchQueriesGeneration, other.SearchQueriesGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchResultsEvent?>.Default.Equals(SearchResults, other.SearchResults) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatTextGenerationEvent?>.Default.Equals(TextGeneration, other.TextGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCitationGenerationEvent?>.Default.Equals(CitationGeneration, other.CitationGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallsGenerationEvent?>.Default.Equals(ToolCallsGeneration, other.ToolCallsGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEndEvent?>.Default.Equals(StreamEnd, other.StreamEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallsChunkEvent?>.Default.Equals(ToolCallsChunk, other.ToolCallsChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatDebugEvent?>.Default.Equals(Debug, other.Debug) 
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
