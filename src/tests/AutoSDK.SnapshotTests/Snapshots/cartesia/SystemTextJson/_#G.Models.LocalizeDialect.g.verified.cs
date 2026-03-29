//HintName: G.Models.LocalizeDialect.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).
    /// </summary>
    public readonly partial struct LocalizeDialect : global::System.IEquatable<LocalizeDialect>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalizeEnglishDialect? LocalizeEnglishDialect { get; init; }
#else
        public global::G.LocalizeEnglishDialect? LocalizeEnglishDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizeEnglishDialect))]
#endif
        public bool IsLocalizeEnglishDialect => LocalizeEnglishDialect != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalizeSpanishDialect? LocalizeSpanishDialect { get; init; }
#else
        public global::G.LocalizeSpanishDialect? LocalizeSpanishDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizeSpanishDialect))]
#endif
        public bool IsLocalizeSpanishDialect => LocalizeSpanishDialect != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalizePortugueseDialect? LocalizePortugueseDialect { get; init; }
#else
        public global::G.LocalizePortugueseDialect? LocalizePortugueseDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizePortugueseDialect))]
#endif
        public bool IsLocalizePortugueseDialect => LocalizePortugueseDialect != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalizeFrenchDialect? LocalizeFrenchDialect { get; init; }
#else
        public global::G.LocalizeFrenchDialect? LocalizeFrenchDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizeFrenchDialect))]
#endif
        public bool IsLocalizeFrenchDialect => LocalizeFrenchDialect != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::G.LocalizeEnglishDialect value) => new LocalizeDialect((global::G.LocalizeEnglishDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalizeEnglishDialect?(LocalizeDialect @this) => @this.LocalizeEnglishDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::G.LocalizeEnglishDialect? value)
        {
            LocalizeEnglishDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::G.LocalizeSpanishDialect value) => new LocalizeDialect((global::G.LocalizeSpanishDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalizeSpanishDialect?(LocalizeDialect @this) => @this.LocalizeSpanishDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::G.LocalizeSpanishDialect? value)
        {
            LocalizeSpanishDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::G.LocalizePortugueseDialect value) => new LocalizeDialect((global::G.LocalizePortugueseDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalizePortugueseDialect?(LocalizeDialect @this) => @this.LocalizePortugueseDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::G.LocalizePortugueseDialect? value)
        {
            LocalizePortugueseDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::G.LocalizeFrenchDialect value) => new LocalizeDialect((global::G.LocalizeFrenchDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalizeFrenchDialect?(LocalizeDialect @this) => @this.LocalizeFrenchDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::G.LocalizeFrenchDialect? value)
        {
            LocalizeFrenchDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(
            global::G.LocalizeEnglishDialect? localizeEnglishDialect,
            global::G.LocalizeSpanishDialect? localizeSpanishDialect,
            global::G.LocalizePortugueseDialect? localizePortugueseDialect,
            global::G.LocalizeFrenchDialect? localizeFrenchDialect
            )
        {
            LocalizeEnglishDialect = localizeEnglishDialect;
            LocalizeSpanishDialect = localizeSpanishDialect;
            LocalizePortugueseDialect = localizePortugueseDialect;
            LocalizeFrenchDialect = localizeFrenchDialect;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LocalizeFrenchDialect as object ??
            LocalizePortugueseDialect as object ??
            LocalizeSpanishDialect as object ??
            LocalizeEnglishDialect as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LocalizeEnglishDialect?.ToValueString() ??
            LocalizeSpanishDialect?.ToValueString() ??
            LocalizePortugueseDialect?.ToValueString() ??
            LocalizeFrenchDialect?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocalizeEnglishDialect && !IsLocalizeSpanishDialect && !IsLocalizePortugueseDialect && !IsLocalizeFrenchDialect || !IsLocalizeEnglishDialect && IsLocalizeSpanishDialect && !IsLocalizePortugueseDialect && !IsLocalizeFrenchDialect || !IsLocalizeEnglishDialect && !IsLocalizeSpanishDialect && IsLocalizePortugueseDialect && !IsLocalizeFrenchDialect || !IsLocalizeEnglishDialect && !IsLocalizeSpanishDialect && !IsLocalizePortugueseDialect && IsLocalizeFrenchDialect;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LocalizeEnglishDialect?, TResult>? localizeEnglishDialect = null,
            global::System.Func<global::G.LocalizeSpanishDialect?, TResult>? localizeSpanishDialect = null,
            global::System.Func<global::G.LocalizePortugueseDialect?, TResult>? localizePortugueseDialect = null,
            global::System.Func<global::G.LocalizeFrenchDialect?, TResult>? localizeFrenchDialect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocalizeEnglishDialect && localizeEnglishDialect != null)
            {
                return localizeEnglishDialect(LocalizeEnglishDialect!);
            }
            else if (IsLocalizeSpanishDialect && localizeSpanishDialect != null)
            {
                return localizeSpanishDialect(LocalizeSpanishDialect!);
            }
            else if (IsLocalizePortugueseDialect && localizePortugueseDialect != null)
            {
                return localizePortugueseDialect(LocalizePortugueseDialect!);
            }
            else if (IsLocalizeFrenchDialect && localizeFrenchDialect != null)
            {
                return localizeFrenchDialect(LocalizeFrenchDialect!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LocalizeEnglishDialect?>? localizeEnglishDialect = null,
            global::System.Action<global::G.LocalizeSpanishDialect?>? localizeSpanishDialect = null,
            global::System.Action<global::G.LocalizePortugueseDialect?>? localizePortugueseDialect = null,
            global::System.Action<global::G.LocalizeFrenchDialect?>? localizeFrenchDialect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocalizeEnglishDialect)
            {
                localizeEnglishDialect?.Invoke(LocalizeEnglishDialect!);
            }
            else if (IsLocalizeSpanishDialect)
            {
                localizeSpanishDialect?.Invoke(LocalizeSpanishDialect!);
            }
            else if (IsLocalizePortugueseDialect)
            {
                localizePortugueseDialect?.Invoke(LocalizePortugueseDialect!);
            }
            else if (IsLocalizeFrenchDialect)
            {
                localizeFrenchDialect?.Invoke(LocalizeFrenchDialect!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LocalizeEnglishDialect,
                typeof(global::G.LocalizeEnglishDialect),
                LocalizeSpanishDialect,
                typeof(global::G.LocalizeSpanishDialect),
                LocalizePortugueseDialect,
                typeof(global::G.LocalizePortugueseDialect),
                LocalizeFrenchDialect,
                typeof(global::G.LocalizeFrenchDialect),
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
        public bool Equals(LocalizeDialect other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LocalizeEnglishDialect?>.Default.Equals(LocalizeEnglishDialect, other.LocalizeEnglishDialect) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalizeSpanishDialect?>.Default.Equals(LocalizeSpanishDialect, other.LocalizeSpanishDialect) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalizePortugueseDialect?>.Default.Equals(LocalizePortugueseDialect, other.LocalizePortugueseDialect) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalizeFrenchDialect?>.Default.Equals(LocalizeFrenchDialect, other.LocalizeFrenchDialect) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LocalizeDialect obj1, LocalizeDialect obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LocalizeDialect>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LocalizeDialect obj1, LocalizeDialect obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LocalizeDialect o && Equals(o);
        }
    }
}
