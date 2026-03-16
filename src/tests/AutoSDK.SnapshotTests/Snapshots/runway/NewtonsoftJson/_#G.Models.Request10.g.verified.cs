//HintName: G.Models.Request10.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Request10 : global::System.IEquatable<Request10>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestElevenVoiceIsolation? ElevenVoiceIsolation { get; init; }
#else
        public global::G.RequestElevenVoiceIsolation? ElevenVoiceIsolation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenVoiceIsolation))]
#endif
        public bool IsElevenVoiceIsolation => ElevenVoiceIsolation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request10(global::G.RequestElevenVoiceIsolation value) => new Request10((global::G.RequestElevenVoiceIsolation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestElevenVoiceIsolation?(Request10 @this) => @this.ElevenVoiceIsolation;

        /// <summary>
        /// 
        /// </summary>
        public Request10(global::G.RequestElevenVoiceIsolation? value)
        {
            ElevenVoiceIsolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenVoiceIsolation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenVoiceIsolation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenVoiceIsolation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RequestElevenVoiceIsolation?, TResult>? elevenVoiceIsolation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenVoiceIsolation && elevenVoiceIsolation != null)
            {
                return elevenVoiceIsolation(ElevenVoiceIsolation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RequestElevenVoiceIsolation?>? elevenVoiceIsolation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenVoiceIsolation)
            {
                elevenVoiceIsolation?.Invoke(ElevenVoiceIsolation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenVoiceIsolation,
                typeof(global::G.RequestElevenVoiceIsolation),
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
        public bool Equals(Request10 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestElevenVoiceIsolation?>.Default.Equals(ElevenVoiceIsolation, other.ElevenVoiceIsolation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request10 obj1, Request10 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request10>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request10 obj1, Request10 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request10 o && Equals(o);
        }
    }
}
