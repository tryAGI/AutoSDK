//HintName: G.Models.MatchCondition.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Match filter request
    /// </summary>
    public readonly partial struct MatchCondition : global::System.IEquatable<MatchCondition>
    {
        /// <summary>
        /// Exact match of the given value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchValue? Value { get; init; }
#else
        public global::G.MatchValue? Value { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value))]
#endif
        public bool IsValue => Value != null;

        /// <summary>
        /// Full-text match of the strings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchText? Text { get; init; }
#else
        public global::G.MatchText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// Full-text match of at least one token of the string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchTextAny? TextAny { get; init; }
#else
        public global::G.MatchTextAny? TextAny { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextAny))]
#endif
        public bool IsTextAny => TextAny != null;

        /// <summary>
        /// Full-text phrase match of the string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchPhrase? Phrase { get; init; }
#else
        public global::G.MatchPhrase? Phrase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Phrase))]
#endif
        public bool IsPhrase => Phrase != null;

        /// <summary>
        /// Exact match on any of the given values
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchAny? Any { get; init; }
#else
        public global::G.MatchAny? Any { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Any))]
#endif
        public bool IsAny => Any != null;

        /// <summary>
        /// Should have at least one value not matching the any given values
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchExcept? Except { get; init; }
#else
        public global::G.MatchExcept? Except { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Except))]
#endif
        public bool IsExcept => Except != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MatchCondition(global::G.MatchValue value) => new MatchCondition((global::G.MatchValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchValue?(MatchCondition @this) => @this.Value;

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(global::G.MatchValue? value)
        {
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MatchCondition(global::G.MatchText value) => new MatchCondition((global::G.MatchText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchText?(MatchCondition @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(global::G.MatchText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MatchCondition(global::G.MatchTextAny value) => new MatchCondition((global::G.MatchTextAny?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchTextAny?(MatchCondition @this) => @this.TextAny;

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(global::G.MatchTextAny? value)
        {
            TextAny = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MatchCondition(global::G.MatchPhrase value) => new MatchCondition((global::G.MatchPhrase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchPhrase?(MatchCondition @this) => @this.Phrase;

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(global::G.MatchPhrase? value)
        {
            Phrase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MatchCondition(global::G.MatchAny value) => new MatchCondition((global::G.MatchAny?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchAny?(MatchCondition @this) => @this.Any;

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(global::G.MatchAny? value)
        {
            Any = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MatchCondition(global::G.MatchExcept value) => new MatchCondition((global::G.MatchExcept?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchExcept?(MatchCondition @this) => @this.Except;

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(global::G.MatchExcept? value)
        {
            Except = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MatchCondition(
            global::G.MatchValue? value,
            global::G.MatchText? text,
            global::G.MatchTextAny? textAny,
            global::G.MatchPhrase? phrase,
            global::G.MatchAny? any,
            global::G.MatchExcept? except
            )
        {
            Value = value;
            Text = text;
            TextAny = textAny;
            Phrase = phrase;
            Any = any;
            Except = except;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Except as object ??
            Any as object ??
            Phrase as object ??
            TextAny as object ??
            Text as object ??
            Value as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value?.ToString() ??
            Text?.ToString() ??
            TextAny?.ToString() ??
            Phrase?.ToString() ??
            Any?.ToString() ??
            Except?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue || IsText || IsTextAny || IsPhrase || IsAny || IsExcept;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MatchValue?, TResult>? value = null,
            global::System.Func<global::G.MatchText?, TResult>? text = null,
            global::System.Func<global::G.MatchTextAny?, TResult>? textAny = null,
            global::System.Func<global::G.MatchPhrase?, TResult>? phrase = null,
            global::System.Func<global::G.MatchAny?, TResult>? any = null,
            global::System.Func<global::G.MatchExcept?, TResult>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue && value != null)
            {
                return value(Value!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsTextAny && textAny != null)
            {
                return textAny(TextAny!);
            }
            else if (IsPhrase && phrase != null)
            {
                return phrase(Phrase!);
            }
            else if (IsAny && any != null)
            {
                return any(Any!);
            }
            else if (IsExcept && except != null)
            {
                return except(Except!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MatchValue?>? value = null,
            global::System.Action<global::G.MatchText?>? text = null,
            global::System.Action<global::G.MatchTextAny?>? textAny = null,
            global::System.Action<global::G.MatchPhrase?>? phrase = null,
            global::System.Action<global::G.MatchAny?>? any = null,
            global::System.Action<global::G.MatchExcept?>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue)
            {
                value?.Invoke(Value!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsTextAny)
            {
                textAny?.Invoke(TextAny!);
            }
            else if (IsPhrase)
            {
                phrase?.Invoke(Phrase!);
            }
            else if (IsAny)
            {
                any?.Invoke(Any!);
            }
            else if (IsExcept)
            {
                except?.Invoke(Except!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value,
                typeof(global::G.MatchValue),
                Text,
                typeof(global::G.MatchText),
                TextAny,
                typeof(global::G.MatchTextAny),
                Phrase,
                typeof(global::G.MatchPhrase),
                Any,
                typeof(global::G.MatchAny),
                Except,
                typeof(global::G.MatchExcept),
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
        public bool Equals(MatchCondition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MatchValue?>.Default.Equals(Value, other.Value) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchTextAny?>.Default.Equals(TextAny, other.TextAny) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchPhrase?>.Default.Equals(Phrase, other.Phrase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchAny?>.Default.Equals(Any, other.Any) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchExcept?>.Default.Equals(Except, other.Except) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MatchCondition obj1, MatchCondition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MatchCondition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MatchCondition obj1, MatchCondition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MatchCondition o && Equals(o);
        }
    }
}
