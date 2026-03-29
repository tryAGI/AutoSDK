//HintName: G.Models.Formats.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Text response format configuration
    /// </summary>
    public readonly partial struct Formats : global::System.IEquatable<Formats>
    {
        /// <summary>
        /// Plain text response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FormatTextConfig? FormatTextConfig { get; init; }
#else
        public global::G.FormatTextConfig? FormatTextConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormatTextConfig))]
#endif
        public bool IsFormatTextConfig => FormatTextConfig != null;

        /// <summary>
        /// JSON object response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FormatJsonObjectConfig? FormatJsonObjectConfig { get; init; }
#else
        public global::G.FormatJsonObjectConfig? FormatJsonObjectConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormatJsonObjectConfig))]
#endif
        public bool IsFormatJsonObjectConfig => FormatJsonObjectConfig != null;

        /// <summary>
        /// JSON schema constrained response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FormatJsonSchemaConfig? FormatJsonSchemaConfig { get; init; }
#else
        public global::G.FormatJsonSchemaConfig? FormatJsonSchemaConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormatJsonSchemaConfig))]
#endif
        public bool IsFormatJsonSchemaConfig => FormatJsonSchemaConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Formats(global::G.FormatTextConfig value) => new Formats((global::G.FormatTextConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FormatTextConfig?(Formats @this) => @this.FormatTextConfig;

        /// <summary>
        /// 
        /// </summary>
        public Formats(global::G.FormatTextConfig? value)
        {
            FormatTextConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Formats(global::G.FormatJsonObjectConfig value) => new Formats((global::G.FormatJsonObjectConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FormatJsonObjectConfig?(Formats @this) => @this.FormatJsonObjectConfig;

        /// <summary>
        /// 
        /// </summary>
        public Formats(global::G.FormatJsonObjectConfig? value)
        {
            FormatJsonObjectConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Formats(global::G.FormatJsonSchemaConfig value) => new Formats((global::G.FormatJsonSchemaConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FormatJsonSchemaConfig?(Formats @this) => @this.FormatJsonSchemaConfig;

        /// <summary>
        /// 
        /// </summary>
        public Formats(global::G.FormatJsonSchemaConfig? value)
        {
            FormatJsonSchemaConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Formats(
            global::G.FormatTextConfig? formatTextConfig,
            global::G.FormatJsonObjectConfig? formatJsonObjectConfig,
            global::G.FormatJsonSchemaConfig? formatJsonSchemaConfig
            )
        {
            FormatTextConfig = formatTextConfig;
            FormatJsonObjectConfig = formatJsonObjectConfig;
            FormatJsonSchemaConfig = formatJsonSchemaConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FormatJsonSchemaConfig as object ??
            FormatJsonObjectConfig as object ??
            FormatTextConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FormatTextConfig?.ToString() ??
            FormatJsonObjectConfig?.ToString() ??
            FormatJsonSchemaConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFormatTextConfig && !IsFormatJsonObjectConfig && !IsFormatJsonSchemaConfig || !IsFormatTextConfig && IsFormatJsonObjectConfig && !IsFormatJsonSchemaConfig || !IsFormatTextConfig && !IsFormatJsonObjectConfig && IsFormatJsonSchemaConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FormatTextConfig?, TResult>? formatTextConfig = null,
            global::System.Func<global::G.FormatJsonObjectConfig?, TResult>? formatJsonObjectConfig = null,
            global::System.Func<global::G.FormatJsonSchemaConfig?, TResult>? formatJsonSchemaConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFormatTextConfig && formatTextConfig != null)
            {
                return formatTextConfig(FormatTextConfig!);
            }
            else if (IsFormatJsonObjectConfig && formatJsonObjectConfig != null)
            {
                return formatJsonObjectConfig(FormatJsonObjectConfig!);
            }
            else if (IsFormatJsonSchemaConfig && formatJsonSchemaConfig != null)
            {
                return formatJsonSchemaConfig(FormatJsonSchemaConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FormatTextConfig?>? formatTextConfig = null,
            global::System.Action<global::G.FormatJsonObjectConfig?>? formatJsonObjectConfig = null,
            global::System.Action<global::G.FormatJsonSchemaConfig?>? formatJsonSchemaConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFormatTextConfig)
            {
                formatTextConfig?.Invoke(FormatTextConfig!);
            }
            else if (IsFormatJsonObjectConfig)
            {
                formatJsonObjectConfig?.Invoke(FormatJsonObjectConfig!);
            }
            else if (IsFormatJsonSchemaConfig)
            {
                formatJsonSchemaConfig?.Invoke(FormatJsonSchemaConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FormatTextConfig,
                typeof(global::G.FormatTextConfig),
                FormatJsonObjectConfig,
                typeof(global::G.FormatJsonObjectConfig),
                FormatJsonSchemaConfig,
                typeof(global::G.FormatJsonSchemaConfig),
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
        public bool Equals(Formats other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FormatTextConfig?>.Default.Equals(FormatTextConfig, other.FormatTextConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FormatJsonObjectConfig?>.Default.Equals(FormatJsonObjectConfig, other.FormatJsonObjectConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FormatJsonSchemaConfig?>.Default.Equals(FormatJsonSchemaConfig, other.FormatJsonSchemaConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Formats obj1, Formats obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Formats>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Formats obj1, Formats obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Formats o && Equals(o);
        }
    }
}
