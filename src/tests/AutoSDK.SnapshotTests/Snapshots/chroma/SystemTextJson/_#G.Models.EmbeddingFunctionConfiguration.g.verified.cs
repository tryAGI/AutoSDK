//HintName: G.Models.EmbeddingFunctionConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingFunctionConfiguration : global::System.IEquatable<EmbeddingFunctionConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingFunctionConfigurationVariant1? EmbeddingFunctionConfigurationVariant1 { get; init; }
#else
        public global::G.EmbeddingFunctionConfigurationVariant1? EmbeddingFunctionConfigurationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingFunctionConfigurationVariant1))]
#endif
        public bool IsEmbeddingFunctionConfigurationVariant1 => EmbeddingFunctionConfigurationVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>? EmbeddingFunctionConfigurationVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>? EmbeddingFunctionConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingFunctionConfigurationVariant2))]
#endif
        public bool IsEmbeddingFunctionConfigurationVariant2 => EmbeddingFunctionConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingFunctionConfigurationVariant3? EmbeddingFunctionConfigurationVariant3 { get; init; }
#else
        public global::G.EmbeddingFunctionConfigurationVariant3? EmbeddingFunctionConfigurationVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingFunctionConfigurationVariant3))]
#endif
        public bool IsEmbeddingFunctionConfigurationVariant3 => EmbeddingFunctionConfigurationVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingFunctionConfiguration(global::G.EmbeddingFunctionConfigurationVariant1 value) => new EmbeddingFunctionConfiguration((global::G.EmbeddingFunctionConfigurationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingFunctionConfigurationVariant1?(EmbeddingFunctionConfiguration @this) => @this.EmbeddingFunctionConfigurationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingFunctionConfiguration(global::G.EmbeddingFunctionConfigurationVariant1? value)
        {
            EmbeddingFunctionConfigurationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingFunctionConfiguration(global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22> value) => new EmbeddingFunctionConfiguration((global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>?(EmbeddingFunctionConfiguration @this) => @this.EmbeddingFunctionConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingFunctionConfiguration(global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>? value)
        {
            EmbeddingFunctionConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingFunctionConfiguration(global::G.EmbeddingFunctionConfigurationVariant3 value) => new EmbeddingFunctionConfiguration((global::G.EmbeddingFunctionConfigurationVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingFunctionConfigurationVariant3?(EmbeddingFunctionConfiguration @this) => @this.EmbeddingFunctionConfigurationVariant3;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingFunctionConfiguration(global::G.EmbeddingFunctionConfigurationVariant3? value)
        {
            EmbeddingFunctionConfigurationVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingFunctionConfiguration(
            global::G.EmbeddingFunctionConfigurationVariant1? embeddingFunctionConfigurationVariant1,
            global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>? embeddingFunctionConfigurationVariant2,
            global::G.EmbeddingFunctionConfigurationVariant3? embeddingFunctionConfigurationVariant3
            )
        {
            EmbeddingFunctionConfigurationVariant1 = embeddingFunctionConfigurationVariant1;
            EmbeddingFunctionConfigurationVariant2 = embeddingFunctionConfigurationVariant2;
            EmbeddingFunctionConfigurationVariant3 = embeddingFunctionConfigurationVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingFunctionConfigurationVariant3 as object ??
            EmbeddingFunctionConfigurationVariant2 as object ??
            EmbeddingFunctionConfigurationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingFunctionConfigurationVariant1?.ToString() ??
            EmbeddingFunctionConfigurationVariant2?.ToString() ??
            EmbeddingFunctionConfigurationVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingFunctionConfigurationVariant1 && !IsEmbeddingFunctionConfigurationVariant2 && !IsEmbeddingFunctionConfigurationVariant3 || !IsEmbeddingFunctionConfigurationVariant1 && IsEmbeddingFunctionConfigurationVariant2 && !IsEmbeddingFunctionConfigurationVariant3 || !IsEmbeddingFunctionConfigurationVariant1 && !IsEmbeddingFunctionConfigurationVariant2 && IsEmbeddingFunctionConfigurationVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EmbeddingFunctionConfigurationVariant1?, TResult>? embeddingFunctionConfigurationVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>?, TResult>? embeddingFunctionConfigurationVariant2 = null,
            global::System.Func<global::G.EmbeddingFunctionConfigurationVariant3?, TResult>? embeddingFunctionConfigurationVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingFunctionConfigurationVariant1 && embeddingFunctionConfigurationVariant1 != null)
            {
                return embeddingFunctionConfigurationVariant1(EmbeddingFunctionConfigurationVariant1!);
            }
            else if (IsEmbeddingFunctionConfigurationVariant2 && embeddingFunctionConfigurationVariant2 != null)
            {
                return embeddingFunctionConfigurationVariant2(EmbeddingFunctionConfigurationVariant2!);
            }
            else if (IsEmbeddingFunctionConfigurationVariant3 && embeddingFunctionConfigurationVariant3 != null)
            {
                return embeddingFunctionConfigurationVariant3(EmbeddingFunctionConfigurationVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EmbeddingFunctionConfigurationVariant1?>? embeddingFunctionConfigurationVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>?>? embeddingFunctionConfigurationVariant2 = null,
            global::System.Action<global::G.EmbeddingFunctionConfigurationVariant3?>? embeddingFunctionConfigurationVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingFunctionConfigurationVariant1)
            {
                embeddingFunctionConfigurationVariant1?.Invoke(EmbeddingFunctionConfigurationVariant1!);
            }
            else if (IsEmbeddingFunctionConfigurationVariant2)
            {
                embeddingFunctionConfigurationVariant2?.Invoke(EmbeddingFunctionConfigurationVariant2!);
            }
            else if (IsEmbeddingFunctionConfigurationVariant3)
            {
                embeddingFunctionConfigurationVariant3?.Invoke(EmbeddingFunctionConfigurationVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingFunctionConfigurationVariant1,
                typeof(global::G.EmbeddingFunctionConfigurationVariant1),
                EmbeddingFunctionConfigurationVariant2,
                typeof(global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>),
                EmbeddingFunctionConfigurationVariant3,
                typeof(global::G.EmbeddingFunctionConfigurationVariant3),
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
        public bool Equals(EmbeddingFunctionConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingFunctionConfigurationVariant1?>.Default.Equals(EmbeddingFunctionConfigurationVariant1, other.EmbeddingFunctionConfigurationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>?>.Default.Equals(EmbeddingFunctionConfigurationVariant2, other.EmbeddingFunctionConfigurationVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingFunctionConfigurationVariant3?>.Default.Equals(EmbeddingFunctionConfigurationVariant3, other.EmbeddingFunctionConfigurationVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingFunctionConfiguration obj1, EmbeddingFunctionConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingFunctionConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingFunctionConfiguration obj1, EmbeddingFunctionConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingFunctionConfiguration o && Equals(o);
        }
    }
}
