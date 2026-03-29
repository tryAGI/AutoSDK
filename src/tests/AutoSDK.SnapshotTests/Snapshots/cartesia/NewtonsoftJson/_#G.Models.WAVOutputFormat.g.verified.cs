//HintName: G.Models.WAVOutputFormat.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WAVOutputFormat : global::System.IEquatable<WAVOutputFormat>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RawOutputFormat? RawOutputFormat { get; init; }
#else
        public global::G.RawOutputFormat? RawOutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RawOutputFormat))]
#endif
        public bool IsRawOutputFormat => RawOutputFormat != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WAVOutputFormat(global::G.RawOutputFormat value) => new WAVOutputFormat((global::G.RawOutputFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RawOutputFormat?(WAVOutputFormat @this) => @this.RawOutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public WAVOutputFormat(global::G.RawOutputFormat? value)
        {
            RawOutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RawOutputFormat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RawOutputFormat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRawOutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RawOutputFormat?, TResult>? rawOutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawOutputFormat && rawOutputFormat != null)
            {
                return rawOutputFormat(RawOutputFormat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RawOutputFormat?>? rawOutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawOutputFormat)
            {
                rawOutputFormat?.Invoke(RawOutputFormat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RawOutputFormat,
                typeof(global::G.RawOutputFormat),
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
        public bool Equals(WAVOutputFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RawOutputFormat?>.Default.Equals(RawOutputFormat, other.RawOutputFormat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WAVOutputFormat obj1, WAVOutputFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WAVOutputFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WAVOutputFormat obj1, WAVOutputFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WAVOutputFormat o && Equals(o);
        }
    }
}
