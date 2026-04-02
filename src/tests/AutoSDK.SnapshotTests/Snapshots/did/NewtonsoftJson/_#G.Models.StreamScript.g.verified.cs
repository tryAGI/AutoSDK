//HintName: G.Models.StreamScript.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StreamScript : global::System.IEquatable<StreamScript>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamScriptVariant1? StreamScriptVariant1 { get; init; }
#else
        public global::G.StreamScriptVariant1? StreamScriptVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamScriptVariant1))]
#endif
        public bool IsStreamScriptVariant1 => StreamScriptVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamScriptVariant2? StreamScriptVariant2 { get; init; }
#else
        public global::G.StreamScriptVariant2? StreamScriptVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamScriptVariant2))]
#endif
        public bool IsStreamScriptVariant2 => StreamScriptVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamScript(global::G.StreamScriptVariant1 value) => new StreamScript((global::G.StreamScriptVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamScriptVariant1?(StreamScript @this) => @this.StreamScriptVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StreamScript(global::G.StreamScriptVariant1? value)
        {
            StreamScriptVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamScript(global::G.StreamScriptVariant2 value) => new StreamScript((global::G.StreamScriptVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamScriptVariant2?(StreamScript @this) => @this.StreamScriptVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StreamScript(global::G.StreamScriptVariant2? value)
        {
            StreamScriptVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamScript(
            global::G.StreamScriptVariant1? streamScriptVariant1,
            global::G.StreamScriptVariant2? streamScriptVariant2
            )
        {
            StreamScriptVariant1 = streamScriptVariant1;
            StreamScriptVariant2 = streamScriptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamScriptVariant2 as object ??
            StreamScriptVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamScriptVariant1?.ToString() ??
            StreamScriptVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamScriptVariant1 || IsStreamScriptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StreamScriptVariant1?, TResult>? streamScriptVariant1 = null,
            global::System.Func<global::G.StreamScriptVariant2?, TResult>? streamScriptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamScriptVariant1 && streamScriptVariant1 != null)
            {
                return streamScriptVariant1(StreamScriptVariant1!);
            }
            else if (IsStreamScriptVariant2 && streamScriptVariant2 != null)
            {
                return streamScriptVariant2(StreamScriptVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StreamScriptVariant1?>? streamScriptVariant1 = null,
            global::System.Action<global::G.StreamScriptVariant2?>? streamScriptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamScriptVariant1)
            {
                streamScriptVariant1?.Invoke(StreamScriptVariant1!);
            }
            else if (IsStreamScriptVariant2)
            {
                streamScriptVariant2?.Invoke(StreamScriptVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamScriptVariant1,
                typeof(global::G.StreamScriptVariant1),
                StreamScriptVariant2,
                typeof(global::G.StreamScriptVariant2),
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
        public bool Equals(StreamScript other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StreamScriptVariant1?>.Default.Equals(StreamScriptVariant1, other.StreamScriptVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamScriptVariant2?>.Default.Equals(StreamScriptVariant2, other.StreamScriptVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamScript obj1, StreamScript obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamScript>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamScript obj1, StreamScript obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamScript o && Equals(o);
        }
    }
}
