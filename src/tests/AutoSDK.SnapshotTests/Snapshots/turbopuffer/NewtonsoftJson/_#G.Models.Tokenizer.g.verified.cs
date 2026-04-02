//HintName: G.Models.Tokenizer.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The tokenizer to use for full-text search on an attribute. Defaults to `word_v3`.
    /// </summary>
    public readonly partial struct Tokenizer : global::System.IEquatable<Tokenizer>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TokenizerVariant1 { get; init; }
#else
        public string? TokenizerVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizerVariant1))]
#endif
        public bool IsTokenizerVariant1 => TokenizerVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TokenizerVariant2 { get; init; }
#else
        public string? TokenizerVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizerVariant2))]
#endif
        public bool IsTokenizerVariant2 => TokenizerVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TokenizerVariant3 { get; init; }
#else
        public string? TokenizerVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizerVariant3))]
#endif
        public bool IsTokenizerVariant3 => TokenizerVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TokenizerVariant4 { get; init; }
#else
        public string? TokenizerVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizerVariant4))]
#endif
        public bool IsTokenizerVariant4 => TokenizerVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TokenizerVariant5 { get; init; }
#else
        public string? TokenizerVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenizerVariant5))]
#endif
        public bool IsTokenizerVariant5 => TokenizerVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tokenizer(string value) => new Tokenizer((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Tokenizer @this) => @this.TokenizerVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Tokenizer(string? value)
        {
            TokenizerVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tokenizer(
            string? tokenizerVariant1,
            string? tokenizerVariant2,
            string? tokenizerVariant3,
            string? tokenizerVariant4,
            string? tokenizerVariant5
            )
        {
            TokenizerVariant1 = tokenizerVariant1;
            TokenizerVariant2 = tokenizerVariant2;
            TokenizerVariant3 = tokenizerVariant3;
            TokenizerVariant4 = tokenizerVariant4;
            TokenizerVariant5 = tokenizerVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TokenizerVariant5 as object ??
            TokenizerVariant4 as object ??
            TokenizerVariant3 as object ??
            TokenizerVariant2 as object ??
            TokenizerVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TokenizerVariant1?.ToString() ??
            TokenizerVariant2?.ToString() ??
            TokenizerVariant3?.ToString() ??
            TokenizerVariant4?.ToString() ??
            TokenizerVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTokenizerVariant1 && !IsTokenizerVariant2 && !IsTokenizerVariant3 && !IsTokenizerVariant4 && !IsTokenizerVariant5 || !IsTokenizerVariant1 && IsTokenizerVariant2 && !IsTokenizerVariant3 && !IsTokenizerVariant4 && !IsTokenizerVariant5 || !IsTokenizerVariant1 && !IsTokenizerVariant2 && IsTokenizerVariant3 && !IsTokenizerVariant4 && !IsTokenizerVariant5 || !IsTokenizerVariant1 && !IsTokenizerVariant2 && !IsTokenizerVariant3 && IsTokenizerVariant4 && !IsTokenizerVariant5 || !IsTokenizerVariant1 && !IsTokenizerVariant2 && !IsTokenizerVariant3 && !IsTokenizerVariant4 && IsTokenizerVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? tokenizerVariant1 = null,
            global::System.Func<string?, TResult>? tokenizerVariant2 = null,
            global::System.Func<string?, TResult>? tokenizerVariant3 = null,
            global::System.Func<string?, TResult>? tokenizerVariant4 = null,
            global::System.Func<string?, TResult>? tokenizerVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTokenizerVariant1 && tokenizerVariant1 != null)
            {
                return tokenizerVariant1(TokenizerVariant1!);
            }
            else if (IsTokenizerVariant2 && tokenizerVariant2 != null)
            {
                return tokenizerVariant2(TokenizerVariant2!);
            }
            else if (IsTokenizerVariant3 && tokenizerVariant3 != null)
            {
                return tokenizerVariant3(TokenizerVariant3!);
            }
            else if (IsTokenizerVariant4 && tokenizerVariant4 != null)
            {
                return tokenizerVariant4(TokenizerVariant4!);
            }
            else if (IsTokenizerVariant5 && tokenizerVariant5 != null)
            {
                return tokenizerVariant5(TokenizerVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? tokenizerVariant1 = null,
            global::System.Action<string?>? tokenizerVariant2 = null,
            global::System.Action<string?>? tokenizerVariant3 = null,
            global::System.Action<string?>? tokenizerVariant4 = null,
            global::System.Action<string?>? tokenizerVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTokenizerVariant1)
            {
                tokenizerVariant1?.Invoke(TokenizerVariant1!);
            }
            else if (IsTokenizerVariant2)
            {
                tokenizerVariant2?.Invoke(TokenizerVariant2!);
            }
            else if (IsTokenizerVariant3)
            {
                tokenizerVariant3?.Invoke(TokenizerVariant3!);
            }
            else if (IsTokenizerVariant4)
            {
                tokenizerVariant4?.Invoke(TokenizerVariant4!);
            }
            else if (IsTokenizerVariant5)
            {
                tokenizerVariant5?.Invoke(TokenizerVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TokenizerVariant1,
                typeof(string),
                TokenizerVariant2,
                typeof(string),
                TokenizerVariant3,
                typeof(string),
                TokenizerVariant4,
                typeof(string),
                TokenizerVariant5,
                typeof(string),
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
        public bool Equals(Tokenizer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TokenizerVariant1, other.TokenizerVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TokenizerVariant2, other.TokenizerVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TokenizerVariant3, other.TokenizerVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TokenizerVariant4, other.TokenizerVariant4) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TokenizerVariant5, other.TokenizerVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tokenizer obj1, Tokenizer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tokenizer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tokenizer obj1, Tokenizer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tokenizer o && Equals(o);
        }
    }
}
