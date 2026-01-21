//HintName: G.Models.SummarizeDocumentStreamedResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when the document summarization request is streamed.
    /// </summary>
    public readonly partial struct SummarizeDocumentStreamedResponse : global::System.IEquatable<SummarizeDocumentStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SummarizeDocumentStreamedResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// The chunk response from the generation, which may be a partial generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamGenerationChunk? GenerationChunk { get; init; }
#else
        public global::G.StreamGenerationChunk? GenerationChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationChunk))]
#endif
        public bool IsGenerationChunk => GenerationChunk != null;

        /// <summary>
        /// Event containing information on how the generation was accomplished.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationInfo? GenerationInfo { get; init; }
#else
        public global::G.GenerationInfo? GenerationInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationInfo))]
#endif
        public bool IsGenerationInfo => GenerationInfo != null;

        /// <summary>
        /// The end of generation. There may still be more information such as the<br/>
        /// factual consistency score, but generation has stopped.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamGenerationEnd? GenerationEnd { get; init; }
#else
        public global::G.StreamGenerationEnd? GenerationEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationEnd))]
#endif
        public bool IsGenerationEnd => GenerationEnd != null;

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamResponseEnd? End { get; init; }
#else
        public global::G.StreamResponseEnd? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamError? Error { get; init; }
#else
        public global::G.StreamError? Error { get; }
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
        public static implicit operator SummarizeDocumentStreamedResponse(global::G.StreamGenerationChunk value) => new SummarizeDocumentStreamedResponse((global::G.StreamGenerationChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamGenerationChunk?(SummarizeDocumentStreamedResponse @this) => @this.GenerationChunk;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::G.StreamGenerationChunk? value)
        {
            GenerationChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummarizeDocumentStreamedResponse(global::G.GenerationInfo value) => new SummarizeDocumentStreamedResponse((global::G.GenerationInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationInfo?(SummarizeDocumentStreamedResponse @this) => @this.GenerationInfo;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::G.GenerationInfo? value)
        {
            GenerationInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummarizeDocumentStreamedResponse(global::G.StreamGenerationEnd value) => new SummarizeDocumentStreamedResponse((global::G.StreamGenerationEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamGenerationEnd?(SummarizeDocumentStreamedResponse @this) => @this.GenerationEnd;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::G.StreamGenerationEnd? value)
        {
            GenerationEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummarizeDocumentStreamedResponse(global::G.StreamResponseEnd value) => new SummarizeDocumentStreamedResponse((global::G.StreamResponseEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamResponseEnd?(SummarizeDocumentStreamedResponse @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::G.StreamResponseEnd? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummarizeDocumentStreamedResponse(global::G.StreamError value) => new SummarizeDocumentStreamedResponse((global::G.StreamError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamError?(SummarizeDocumentStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::G.StreamError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(
            global::G.SummarizeDocumentStreamedResponseDiscriminatorType? type,
            global::G.StreamGenerationChunk? generationChunk,
            global::G.GenerationInfo? generationInfo,
            global::G.StreamGenerationEnd? generationEnd,
            global::G.StreamResponseEnd? end,
            global::G.StreamError? error
            )
        {
            Type = type;

            GenerationChunk = generationChunk;
            GenerationInfo = generationInfo;
            GenerationEnd = generationEnd;
            End = end;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            End as object ??
            GenerationEnd as object ??
            GenerationInfo as object ??
            GenerationChunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationChunk?.ToString() ??
            GenerationInfo?.ToString() ??
            GenerationEnd?.ToString() ??
            End?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationChunk && !IsGenerationInfo && !IsGenerationEnd && !IsEnd && !IsError || !IsGenerationChunk && IsGenerationInfo && !IsGenerationEnd && !IsEnd && !IsError || !IsGenerationChunk && !IsGenerationInfo && IsGenerationEnd && !IsEnd && !IsError || !IsGenerationChunk && !IsGenerationInfo && !IsGenerationEnd && IsEnd && !IsError || !IsGenerationChunk && !IsGenerationInfo && !IsGenerationEnd && !IsEnd && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StreamGenerationChunk?, TResult>? generationChunk = null,
            global::System.Func<global::G.GenerationInfo?, TResult>? generationInfo = null,
            global::System.Func<global::G.StreamGenerationEnd?, TResult>? generationEnd = null,
            global::System.Func<global::G.StreamResponseEnd?, TResult>? end = null,
            global::System.Func<global::G.StreamError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationChunk && generationChunk != null)
            {
                return generationChunk(GenerationChunk!);
            }
            else if (IsGenerationInfo && generationInfo != null)
            {
                return generationInfo(GenerationInfo!);
            }
            else if (IsGenerationEnd && generationEnd != null)
            {
                return generationEnd(GenerationEnd!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StreamGenerationChunk?>? generationChunk = null,
            global::System.Action<global::G.GenerationInfo?>? generationInfo = null,
            global::System.Action<global::G.StreamGenerationEnd?>? generationEnd = null,
            global::System.Action<global::G.StreamResponseEnd?>? end = null,
            global::System.Action<global::G.StreamError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationChunk)
            {
                generationChunk?.Invoke(GenerationChunk!);
            }
            else if (IsGenerationInfo)
            {
                generationInfo?.Invoke(GenerationInfo!);
            }
            else if (IsGenerationEnd)
            {
                generationEnd?.Invoke(GenerationEnd!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationChunk,
                typeof(global::G.StreamGenerationChunk),
                GenerationInfo,
                typeof(global::G.GenerationInfo),
                GenerationEnd,
                typeof(global::G.StreamGenerationEnd),
                End,
                typeof(global::G.StreamResponseEnd),
                Error,
                typeof(global::G.StreamError),
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
        public bool Equals(SummarizeDocumentStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StreamGenerationChunk?>.Default.Equals(GenerationChunk, other.GenerationChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationInfo?>.Default.Equals(GenerationInfo, other.GenerationInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamGenerationEnd?>.Default.Equals(GenerationEnd, other.GenerationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamResponseEnd?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SummarizeDocumentStreamedResponse obj1, SummarizeDocumentStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SummarizeDocumentStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SummarizeDocumentStreamedResponse obj1, SummarizeDocumentStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SummarizeDocumentStreamedResponse o && Equals(o);
        }
    }
}
