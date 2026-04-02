//HintName: G.Models.AnthropicBeta.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicBeta : global::System.IEquatable<AnthropicBeta>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnthropicBetaVariant1 { get; init; }
#else
        public string? AnthropicBetaVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBetaVariant1))]
#endif
        public bool IsAnthropicBetaVariant1 => AnthropicBetaVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnthropicBetaEnum? Enum { get; init; }
#else
        public global::G.AnthropicBetaEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicBeta(string value) => new AnthropicBeta((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnthropicBeta @this) => @this.AnthropicBetaVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBeta(string? value)
        {
            AnthropicBetaVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicBeta(global::G.AnthropicBetaEnum value) => new AnthropicBeta((global::G.AnthropicBetaEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnthropicBetaEnum?(AnthropicBeta @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBeta(global::G.AnthropicBetaEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBeta(
            string? anthropicBetaVariant1,
            global::G.AnthropicBetaEnum? @enum
            )
        {
            AnthropicBetaVariant1 = anthropicBetaVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            AnthropicBetaVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBetaVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBetaVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? anthropicBetaVariant1 = null,
            global::System.Func<global::G.AnthropicBetaEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBetaVariant1 && anthropicBetaVariant1 != null)
            {
                return anthropicBetaVariant1(AnthropicBetaVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? anthropicBetaVariant1 = null,
            global::System.Action<global::G.AnthropicBetaEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBetaVariant1)
            {
                anthropicBetaVariant1?.Invoke(AnthropicBetaVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicBetaVariant1,
                typeof(string),
                Enum,
                typeof(global::G.AnthropicBetaEnum),
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
        public bool Equals(AnthropicBeta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnthropicBetaVariant1, other.AnthropicBetaVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnthropicBetaEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicBeta obj1, AnthropicBeta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicBeta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicBeta obj1, AnthropicBeta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicBeta o && Equals(o);
        }
    }
}
