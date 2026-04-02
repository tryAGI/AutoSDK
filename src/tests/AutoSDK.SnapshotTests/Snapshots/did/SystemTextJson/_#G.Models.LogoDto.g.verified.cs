//HintName: G.Models.LogoDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LogoDto : global::System.IEquatable<LogoDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LogoDtoVariant1? LogoDtoVariant1 { get; init; }
#else
        public global::G.LogoDtoVariant1? LogoDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LogoDtoVariant1))]
#endif
        public bool IsLogoDtoVariant1 => LogoDtoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? LogoDtoVariant2 { get; init; }
#else
        public bool? LogoDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LogoDtoVariant2))]
#endif
        public bool IsLogoDtoVariant2 => LogoDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LogoDto(global::G.LogoDtoVariant1 value) => new LogoDto((global::G.LogoDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LogoDtoVariant1?(LogoDto @this) => @this.LogoDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LogoDto(global::G.LogoDtoVariant1? value)
        {
            LogoDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LogoDto(bool value) => new LogoDto((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(LogoDto @this) => @this.LogoDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LogoDto(bool? value)
        {
            LogoDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LogoDto(
            global::G.LogoDtoVariant1? logoDtoVariant1,
            bool? logoDtoVariant2
            )
        {
            LogoDtoVariant1 = logoDtoVariant1;
            LogoDtoVariant2 = logoDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LogoDtoVariant2 as object ??
            LogoDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LogoDtoVariant1?.ToString() ??
            LogoDtoVariant2?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLogoDtoVariant1 || IsLogoDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LogoDtoVariant1?, TResult>? logoDtoVariant1 = null,
            global::System.Func<bool?, TResult>? logoDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogoDtoVariant1 && logoDtoVariant1 != null)
            {
                return logoDtoVariant1(LogoDtoVariant1!);
            }
            else if (IsLogoDtoVariant2 && logoDtoVariant2 != null)
            {
                return logoDtoVariant2(LogoDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LogoDtoVariant1?>? logoDtoVariant1 = null,
            global::System.Action<bool?>? logoDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogoDtoVariant1)
            {
                logoDtoVariant1?.Invoke(LogoDtoVariant1!);
            }
            else if (IsLogoDtoVariant2)
            {
                logoDtoVariant2?.Invoke(LogoDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LogoDtoVariant1,
                typeof(global::G.LogoDtoVariant1),
                LogoDtoVariant2,
                typeof(bool),
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
        public bool Equals(LogoDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LogoDtoVariant1?>.Default.Equals(LogoDtoVariant1, other.LogoDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(LogoDtoVariant2, other.LogoDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LogoDto obj1, LogoDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LogoDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LogoDto obj1, LogoDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LogoDto o && Equals(o);
        }
    }
}
