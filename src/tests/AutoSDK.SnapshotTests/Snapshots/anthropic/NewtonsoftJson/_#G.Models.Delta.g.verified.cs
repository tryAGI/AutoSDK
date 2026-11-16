//HintName: G.Models.Delta.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Delta : global::System.IEquatable<Delta>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContentBlockDeltaEventDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContentBlockDelta? TextDelta { get; init; }
#else
        public global::G.TextContentBlockDelta? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TextContentBlockDelta? value)
        {
            value = TextDelta;
            return IsTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TextContentBlockDelta PickTextDelta() => TextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputJsonContentBlockDelta? InputJsonDelta { get; init; }
#else
        public global::G.InputJsonContentBlockDelta? InputJsonDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJsonDelta))]
#endif
        public bool IsInputJsonDelta => InputJsonDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputJsonDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputJsonContentBlockDelta? value)
        {
            value = InputJsonDelta;
            return IsInputJsonDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputJsonContentBlockDelta PickInputJsonDelta() => InputJsonDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputJsonDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CitationsDelta? CitationsDelta { get; init; }
#else
        public global::G.CitationsDelta? CitationsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationsDelta))]
#endif
        public bool IsCitationsDelta => CitationsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCitationsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CitationsDelta? value)
        {
            value = CitationsDelta;
            return IsCitationsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CitationsDelta PickCitationsDelta() => CitationsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CitationsDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ThinkingContentBlockDelta? ThinkingDelta { get; init; }
#else
        public global::G.ThinkingContentBlockDelta? ThinkingDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingDelta))]
#endif
        public bool IsThinkingDelta => ThinkingDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinkingDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ThinkingContentBlockDelta? value)
        {
            value = ThinkingDelta;
            return IsThinkingDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ThinkingContentBlockDelta PickThinkingDelta() => ThinkingDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkingDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SignatureContentBlockDelta? SignatureDelta { get; init; }
#else
        public global::G.SignatureContentBlockDelta? SignatureDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SignatureDelta))]
#endif
        public bool IsSignatureDelta => SignatureDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSignatureDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SignatureContentBlockDelta? value)
        {
            value = SignatureDelta;
            return IsSignatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SignatureContentBlockDelta PickSignatureDelta() => SignatureDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SignatureDelta' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.TextContentBlockDelta value) => new Delta((global::G.TextContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContentBlockDelta?(Delta @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.TextContentBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta FromTextDelta(global::G.TextContentBlockDelta? value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.InputJsonContentBlockDelta value) => new Delta((global::G.InputJsonContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputJsonContentBlockDelta?(Delta @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.InputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta FromInputJsonDelta(global::G.InputJsonContentBlockDelta? value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.CitationsDelta value) => new Delta((global::G.CitationsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CitationsDelta?(Delta @this) => @this.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.CitationsDelta? value)
        {
            CitationsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta FromCitationsDelta(global::G.CitationsDelta? value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.ThinkingContentBlockDelta value) => new Delta((global::G.ThinkingContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThinkingContentBlockDelta?(Delta @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.ThinkingContentBlockDelta? value)
        {
            ThinkingDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta FromThinkingDelta(global::G.ThinkingContentBlockDelta? value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.SignatureContentBlockDelta value) => new Delta((global::G.SignatureContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SignatureContentBlockDelta?(Delta @this) => @this.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.SignatureContentBlockDelta? value)
        {
            SignatureDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta FromSignatureDelta(global::G.SignatureContentBlockDelta? value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public Delta(
            global::G.ContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::G.TextContentBlockDelta? textDelta,
            global::G.InputJsonContentBlockDelta? inputJsonDelta,
            global::G.CitationsDelta? citationsDelta,
            global::G.ThinkingContentBlockDelta? thinkingDelta,
            global::G.SignatureContentBlockDelta? signatureDelta
            )
        {
            Type = type;

            TextDelta = textDelta;
            InputJsonDelta = inputJsonDelta;
            CitationsDelta = citationsDelta;
            ThinkingDelta = thinkingDelta;
            SignatureDelta = signatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SignatureDelta as object ??
            ThinkingDelta as object ??
            CitationsDelta as object ??
            InputJsonDelta as object ??
            TextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextDelta?.ToString() ??
            InputJsonDelta?.ToString() ??
            CitationsDelta?.ToString() ??
            ThinkingDelta?.ToString() ??
            SignatureDelta?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && IsSignatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContentBlockDelta, TResult>? textDelta = null,
            global::System.Func<global::G.InputJsonContentBlockDelta, TResult>? inputJsonDelta = null,
            global::System.Func<global::G.CitationsDelta, TResult>? citationsDelta = null,
            global::System.Func<global::G.ThinkingContentBlockDelta, TResult>? thinkingDelta = null,
            global::System.Func<global::G.SignatureContentBlockDelta, TResult>? signatureDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextDelta is { } __value0 && textDelta != null)
            {
                return textDelta(__value0);
            }
            else if (InputJsonDelta is { } __value1 && inputJsonDelta != null)
            {
                return inputJsonDelta(__value1);
            }
            else if (CitationsDelta is { } __value2 && citationsDelta != null)
            {
                return citationsDelta(__value2);
            }
            else if (ThinkingDelta is { } __value3 && thinkingDelta != null)
            {
                return thinkingDelta(__value3);
            }
            else if (SignatureDelta is { } __value4 && signatureDelta != null)
            {
                return signatureDelta(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextContentBlockDelta>? textDelta = null,

            global::System.Action<global::G.InputJsonContentBlockDelta>? inputJsonDelta = null,

            global::System.Action<global::G.CitationsDelta>? citationsDelta = null,

            global::System.Action<global::G.ThinkingContentBlockDelta>? thinkingDelta = null,

            global::System.Action<global::G.SignatureContentBlockDelta>? signatureDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextDelta is { } __value0)
            {
                textDelta?.Invoke(__value0);
            }
            else if (InputJsonDelta is { } __value1)
            {
                inputJsonDelta?.Invoke(__value1);
            }
            else if (CitationsDelta is { } __value2)
            {
                citationsDelta?.Invoke(__value2);
            }
            else if (ThinkingDelta is { } __value3)
            {
                thinkingDelta?.Invoke(__value3);
            }
            else if (SignatureDelta is { } __value4)
            {
                signatureDelta?.Invoke(__value4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.TextContentBlockDelta>? textDelta = null,
            global::System.Action<global::G.InputJsonContentBlockDelta>? inputJsonDelta = null,
            global::System.Action<global::G.CitationsDelta>? citationsDelta = null,
            global::System.Action<global::G.ThinkingContentBlockDelta>? thinkingDelta = null,
            global::System.Action<global::G.SignatureContentBlockDelta>? signatureDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextDelta is { } __value0)
            {
                textDelta?.Invoke(__value0);
            }
            else if (InputJsonDelta is { } __value1)
            {
                inputJsonDelta?.Invoke(__value1);
            }
            else if (CitationsDelta is { } __value2)
            {
                citationsDelta?.Invoke(__value2);
            }
            else if (ThinkingDelta is { } __value3)
            {
                thinkingDelta?.Invoke(__value3);
            }
            else if (SignatureDelta is { } __value4)
            {
                signatureDelta?.Invoke(__value4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextDelta,
                typeof(global::G.TextContentBlockDelta),
                InputJsonDelta,
                typeof(global::G.InputJsonContentBlockDelta),
                CitationsDelta,
                typeof(global::G.CitationsDelta),
                ThinkingDelta,
                typeof(global::G.ThinkingContentBlockDelta),
                SignatureDelta,
                typeof(global::G.SignatureContentBlockDelta),
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
        public bool Equals(Delta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContentBlockDelta?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputJsonContentBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CitationsDelta?>.Default.Equals(CitationsDelta, other.CitationsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ThinkingContentBlockDelta?>.Default.Equals(ThinkingDelta, other.ThinkingDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SignatureContentBlockDelta?>.Default.Equals(SignatureDelta, other.SignatureDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Delta obj1, Delta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Delta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Delta obj1, Delta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Delta o && Equals(o);
        }
    }
}
