//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 { get; init; }
#else
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<double>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<double>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(string? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput(
            string? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1,
            global::System.Collections.Generic.IList<string>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2,
            global::System.Collections.Generic.IList<double>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4,
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4
            )
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 = embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = embeddingsPostRequestBodyContentApplicationJsonSchemaInput4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 as object ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4?.ToString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 || !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<double>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 && embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4 && embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaInput4(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<double>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>?>? embeddingsPostRequestBodyContentApplicationJsonSchemaInput4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4!);
            }
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaInput4?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1,
                typeof(string),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3,
                typeof(global::System.Collections.Generic.IList<double>),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>),
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4,
                typeof(global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>),
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<double>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput o && Equals(o);
        }
    }
}
