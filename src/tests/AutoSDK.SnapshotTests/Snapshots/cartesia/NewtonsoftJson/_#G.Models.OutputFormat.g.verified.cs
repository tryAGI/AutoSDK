//HintName: G.Models.OutputFormat.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputFormat : global::System.IEquatable<OutputFormat>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>? RAWOutputFormat { get; init; }
#else
        public global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>? RAWOutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RAWOutputFormat))]
#endif
        public bool IsRAWOutputFormat => RAWOutputFormat != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>? WAVOutputFormat { get; init; }
#else
        public global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>? WAVOutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WAVOutputFormat))]
#endif
        public bool IsWAVOutputFormat => WAVOutputFormat != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>? MP3OutputFormat { get; init; }
#else
        public global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>? MP3OutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MP3OutputFormat))]
#endif
        public bool IsMP3OutputFormat => MP3OutputFormat != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat(global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat> value) => new OutputFormat((global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>?(OutputFormat @this) => @this.RAWOutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>? value)
        {
            RAWOutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat(global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?> value) => new OutputFormat((global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>?(OutputFormat @this) => @this.WAVOutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>? value)
        {
            WAVOutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat(global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat> value) => new OutputFormat((global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>?(OutputFormat @this) => @this.MP3OutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>? value)
        {
            MP3OutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(
            global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>? rAWOutputFormat,
            global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>? wAVOutputFormat,
            global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>? mP3OutputFormat
            )
        {
            RAWOutputFormat = rAWOutputFormat;
            WAVOutputFormat = wAVOutputFormat;
            MP3OutputFormat = mP3OutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MP3OutputFormat as object ??
            WAVOutputFormat as object ??
            RAWOutputFormat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RAWOutputFormat?.ToString() ??
            WAVOutputFormat?.ToString() ??
            MP3OutputFormat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRAWOutputFormat && !IsWAVOutputFormat && !IsMP3OutputFormat || !IsRAWOutputFormat && IsWAVOutputFormat && !IsMP3OutputFormat || !IsRAWOutputFormat && !IsWAVOutputFormat && IsMP3OutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>?, TResult>? rAWOutputFormat = null,
            global::System.Func<global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>?, TResult>? wAVOutputFormat = null,
            global::System.Func<global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>?, TResult>? mP3OutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRAWOutputFormat && rAWOutputFormat != null)
            {
                return rAWOutputFormat(RAWOutputFormat!);
            }
            else if (IsWAVOutputFormat && wAVOutputFormat != null)
            {
                return wAVOutputFormat(WAVOutputFormat!);
            }
            else if (IsMP3OutputFormat && mP3OutputFormat != null)
            {
                return mP3OutputFormat(MP3OutputFormat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>?>? rAWOutputFormat = null,
            global::System.Action<global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>?>? wAVOutputFormat = null,
            global::System.Action<global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>?>? mP3OutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRAWOutputFormat)
            {
                rAWOutputFormat?.Invoke(RAWOutputFormat!);
            }
            else if (IsWAVOutputFormat)
            {
                wAVOutputFormat?.Invoke(WAVOutputFormat!);
            }
            else if (IsMP3OutputFormat)
            {
                mP3OutputFormat?.Invoke(MP3OutputFormat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RAWOutputFormat,
                typeof(global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>),
                WAVOutputFormat,
                typeof(global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>),
                MP3OutputFormat,
                typeof(global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>),
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
        public bool Equals(OutputFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>?>.Default.Equals(RAWOutputFormat, other.RAWOutputFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>?>.Default.Equals(WAVOutputFormat, other.WAVOutputFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>?>.Default.Equals(MP3OutputFormat, other.MP3OutputFormat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputFormat obj1, OutputFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputFormat obj1, OutputFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputFormat o && Equals(o);
        }
    }
}
