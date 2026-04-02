//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 { get; init; }
#else
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 { get; init; }
#else
        public int? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<int>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<int>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 != null;

        /// <summary>
        /// Use this option for multimodal input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 { get; init; }
#else
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(string? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(int value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(int? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items((global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items(
            string? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1,
            int? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2,
            global::System.Collections.Generic.IList<int>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3
            )
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 = null,
            global::System.Func<int?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<int>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 = null,
            global::System.Func<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1 = null,
            global::System.Action<int?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<int>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3 = null,
            global::System.Action<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1,
                typeof(string),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2,
                typeof(int),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3,
                typeof(global::System.Collections.Generic.IList<int>),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3,
                typeof(global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3),
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<int>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items o && Equals(o);
        }
    }
}
