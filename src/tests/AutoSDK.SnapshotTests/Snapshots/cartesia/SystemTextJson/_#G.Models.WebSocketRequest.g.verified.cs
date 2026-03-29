//HintName: G.Models.WebSocketRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebSocketRequest : global::System.IEquatable<WebSocketRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationRequest? GenerationRequest { get; init; }
#else
        public global::G.GenerationRequest? GenerationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationRequest))]
#endif
        public bool IsGenerationRequest => GenerationRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CancelContextRequest? CancelContextRequest { get; init; }
#else
        public global::G.CancelContextRequest? CancelContextRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelContextRequest))]
#endif
        public bool IsCancelContextRequest => CancelContextRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketRequest(global::G.GenerationRequest value) => new WebSocketRequest((global::G.GenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationRequest?(WebSocketRequest @this) => @this.GenerationRequest;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketRequest(global::G.GenerationRequest? value)
        {
            GenerationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketRequest(global::G.CancelContextRequest value) => new WebSocketRequest((global::G.CancelContextRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CancelContextRequest?(WebSocketRequest @this) => @this.CancelContextRequest;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketRequest(global::G.CancelContextRequest? value)
        {
            CancelContextRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebSocketRequest(
            global::G.GenerationRequest? generationRequest,
            global::G.CancelContextRequest? cancelContextRequest
            )
        {
            GenerationRequest = generationRequest;
            CancelContextRequest = cancelContextRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CancelContextRequest as object ??
            GenerationRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationRequest?.ToString() ??
            CancelContextRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationRequest && !IsCancelContextRequest || !IsGenerationRequest && IsCancelContextRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerationRequest?, TResult>? generationRequest = null,
            global::System.Func<global::G.CancelContextRequest?, TResult>? cancelContextRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationRequest && generationRequest != null)
            {
                return generationRequest(GenerationRequest!);
            }
            else if (IsCancelContextRequest && cancelContextRequest != null)
            {
                return cancelContextRequest(CancelContextRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerationRequest?>? generationRequest = null,
            global::System.Action<global::G.CancelContextRequest?>? cancelContextRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationRequest)
            {
                generationRequest?.Invoke(GenerationRequest!);
            }
            else if (IsCancelContextRequest)
            {
                cancelContextRequest?.Invoke(CancelContextRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationRequest,
                typeof(global::G.GenerationRequest),
                CancelContextRequest,
                typeof(global::G.CancelContextRequest),
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
        public bool Equals(WebSocketRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationRequest?>.Default.Equals(GenerationRequest, other.GenerationRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CancelContextRequest?>.Default.Equals(CancelContextRequest, other.CancelContextRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSocketRequest obj1, WebSocketRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSocketRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSocketRequest obj1, WebSocketRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSocketRequest o && Equals(o);
        }
    }
}
