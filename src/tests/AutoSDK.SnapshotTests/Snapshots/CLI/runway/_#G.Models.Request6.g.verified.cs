//HintName: G.Models.Request6.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request6 : global::System.IEquatable<Request6>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestElevenTextToSoundV2? ElevenTextToSoundV2 { get; init; }
#else
        public global::G.RequestElevenTextToSoundV2? ElevenTextToSoundV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenTextToSoundV2))]
#endif
        public bool IsElevenTextToSoundV2 => ElevenTextToSoundV2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request6(global::G.RequestElevenTextToSoundV2 value) => new Request6((global::G.RequestElevenTextToSoundV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestElevenTextToSoundV2?(Request6 @this) => @this.ElevenTextToSoundV2;

        /// <summary>
        /// 
        /// </summary>
        public Request6(global::G.RequestElevenTextToSoundV2? value)
        {
            ElevenTextToSoundV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenTextToSoundV2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenTextToSoundV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenTextToSoundV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RequestElevenTextToSoundV2?, TResult>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenTextToSoundV2 && elevenTextToSoundV2 != null)
            {
                return elevenTextToSoundV2(ElevenTextToSoundV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RequestElevenTextToSoundV2?>? elevenTextToSoundV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenTextToSoundV2)
            {
                elevenTextToSoundV2?.Invoke(ElevenTextToSoundV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenTextToSoundV2,
                typeof(global::G.RequestElevenTextToSoundV2),
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
        public bool Equals(Request6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestElevenTextToSoundV2?>.Default.Equals(ElevenTextToSoundV2, other.ElevenTextToSoundV2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request6 obj1, Request6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request6 obj1, Request6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request6 o && Equals(o);
        }
    }
}
