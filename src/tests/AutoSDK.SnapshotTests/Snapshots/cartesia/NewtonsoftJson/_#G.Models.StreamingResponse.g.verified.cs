//HintName: G.Models.StreamingResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StreamingResponse : global::System.IEquatable<StreamingResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingResponseVariant1? StreamingResponseVariant1 { get; init; }
#else
        public global::G.StreamingResponseVariant1? StreamingResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingResponseVariant1))]
#endif
        public bool IsStreamingResponseVariant1 => StreamingResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingResponseVariant2? StreamingResponseVariant2 { get; init; }
#else
        public global::G.StreamingResponseVariant2? StreamingResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingResponseVariant2))]
#endif
        public bool IsStreamingResponseVariant2 => StreamingResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingResponseVariant3? StreamingResponseVariant3 { get; init; }
#else
        public global::G.StreamingResponseVariant3? StreamingResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingResponseVariant3))]
#endif
        public bool IsStreamingResponseVariant3 => StreamingResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingResponse(global::G.StreamingResponseVariant1 value) => new StreamingResponse((global::G.StreamingResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingResponseVariant1?(StreamingResponse @this) => @this.StreamingResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StreamingResponse(global::G.StreamingResponseVariant1? value)
        {
            StreamingResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingResponse(global::G.StreamingResponseVariant2 value) => new StreamingResponse((global::G.StreamingResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingResponseVariant2?(StreamingResponse @this) => @this.StreamingResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StreamingResponse(global::G.StreamingResponseVariant2? value)
        {
            StreamingResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingResponse(global::G.StreamingResponseVariant3 value) => new StreamingResponse((global::G.StreamingResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingResponseVariant3?(StreamingResponse @this) => @this.StreamingResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StreamingResponse(global::G.StreamingResponseVariant3? value)
        {
            StreamingResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamingResponse(
            global::G.StreamingResponseVariant1? streamingResponseVariant1,
            global::G.StreamingResponseVariant2? streamingResponseVariant2,
            global::G.StreamingResponseVariant3? streamingResponseVariant3
            )
        {
            StreamingResponseVariant1 = streamingResponseVariant1;
            StreamingResponseVariant2 = streamingResponseVariant2;
            StreamingResponseVariant3 = streamingResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamingResponseVariant3 as object ??
            StreamingResponseVariant2 as object ??
            StreamingResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamingResponseVariant1?.ToString() ??
            StreamingResponseVariant2?.ToString() ??
            StreamingResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamingResponseVariant1 && !IsStreamingResponseVariant2 && !IsStreamingResponseVariant3 || !IsStreamingResponseVariant1 && IsStreamingResponseVariant2 && !IsStreamingResponseVariant3 || !IsStreamingResponseVariant1 && !IsStreamingResponseVariant2 && IsStreamingResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StreamingResponseVariant1?, TResult>? streamingResponseVariant1 = null,
            global::System.Func<global::G.StreamingResponseVariant2?, TResult>? streamingResponseVariant2 = null,
            global::System.Func<global::G.StreamingResponseVariant3?, TResult>? streamingResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamingResponseVariant1 && streamingResponseVariant1 != null)
            {
                return streamingResponseVariant1(StreamingResponseVariant1!);
            }
            else if (IsStreamingResponseVariant2 && streamingResponseVariant2 != null)
            {
                return streamingResponseVariant2(StreamingResponseVariant2!);
            }
            else if (IsStreamingResponseVariant3 && streamingResponseVariant3 != null)
            {
                return streamingResponseVariant3(StreamingResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StreamingResponseVariant1?>? streamingResponseVariant1 = null,
            global::System.Action<global::G.StreamingResponseVariant2?>? streamingResponseVariant2 = null,
            global::System.Action<global::G.StreamingResponseVariant3?>? streamingResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamingResponseVariant1)
            {
                streamingResponseVariant1?.Invoke(StreamingResponseVariant1!);
            }
            else if (IsStreamingResponseVariant2)
            {
                streamingResponseVariant2?.Invoke(StreamingResponseVariant2!);
            }
            else if (IsStreamingResponseVariant3)
            {
                streamingResponseVariant3?.Invoke(StreamingResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamingResponseVariant1,
                typeof(global::G.StreamingResponseVariant1),
                StreamingResponseVariant2,
                typeof(global::G.StreamingResponseVariant2),
                StreamingResponseVariant3,
                typeof(global::G.StreamingResponseVariant3),
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
        public bool Equals(StreamingResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingResponseVariant1?>.Default.Equals(StreamingResponseVariant1, other.StreamingResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingResponseVariant2?>.Default.Equals(StreamingResponseVariant2, other.StreamingResponseVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingResponseVariant3?>.Default.Equals(StreamingResponseVariant3, other.StreamingResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamingResponse obj1, StreamingResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamingResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamingResponse obj1, StreamingResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamingResponse o && Equals(o);
        }
    }
}
