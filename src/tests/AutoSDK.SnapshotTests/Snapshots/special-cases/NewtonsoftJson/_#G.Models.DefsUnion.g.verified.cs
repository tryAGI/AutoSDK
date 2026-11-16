//HintName: G.Models.DefsUnion.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DefsUnion : global::System.IEquatable<DefsUnion>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DefsChunk? Chunk { get; init; }
#else
        public global::G.DefsChunk? Chunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chunk))]
#endif
        public bool IsChunk => Chunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DefsChunk? value)
        {
            value = Chunk;
            return IsChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DefsChunk PickChunk() => Chunk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chunk' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DefsError? Error { get; init; }
#else
        public global::G.DefsError? Error { get; }
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
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DefsError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DefsError PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DefsUnion(global::G.DefsChunk value) => new DefsUnion((global::G.DefsChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DefsChunk?(DefsUnion @this) => @this.Chunk;

        /// <summary>
        /// 
        /// </summary>
        public DefsUnion(global::G.DefsChunk? value)
        {
            Chunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DefsUnion FromChunk(global::G.DefsChunk? value) => new DefsUnion(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DefsUnion(global::G.DefsError value) => new DefsUnion((global::G.DefsError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DefsError?(DefsUnion @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public DefsUnion(global::G.DefsError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DefsUnion FromError(global::G.DefsError? value) => new DefsUnion(value);

        /// <summary>
        /// 
        /// </summary>
        public DefsUnion(
            global::G.DefsChunk? chunk,
            global::G.DefsError? error
            )
        {
            Chunk = chunk;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Chunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chunk?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChunk || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.DefsChunk, TResult>? chunk = null,
            global::System.Func<global::G.DefsError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chunk is { } __value0 && chunk != null)
            {
                return chunk(__value0);
            }
            else if (Error is { } __value1 && error != null)
            {
                return error(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.DefsChunk>? chunk = null,

            global::System.Action<global::G.DefsError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chunk is { } __value0)
            {
                chunk?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.DefsChunk>? chunk = null,
            global::System.Action<global::G.DefsError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chunk is { } __value0)
            {
                chunk?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chunk,
                typeof(global::G.DefsChunk),
                Error,
                typeof(global::G.DefsError),
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
        public bool Equals(DefsUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DefsChunk?>.Default.Equals(Chunk, other.Chunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DefsError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DefsUnion obj1, DefsUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DefsUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DefsUnion obj1, DefsUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DefsUnion o && Equals(o);
        }
    }
}
