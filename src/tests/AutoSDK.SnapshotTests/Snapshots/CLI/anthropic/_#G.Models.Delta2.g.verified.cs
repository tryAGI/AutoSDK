//HintName: G.Models.Delta2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Delta2 : global::System.IEquatable<Delta2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaTextContentBlockDelta? TextDelta { get; init; }
#else
        public global::G.BetaTextContentBlockDelta? TextDelta { get; }
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
            out global::G.BetaTextContentBlockDelta? value)
        {
            value = TextDelta;
            return IsTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaTextContentBlockDelta PickTextDelta() => TextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaInputJsonContentBlockDelta? InputJsonDelta { get; init; }
#else
        public global::G.BetaInputJsonContentBlockDelta? InputJsonDelta { get; }
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
            out global::G.BetaInputJsonContentBlockDelta? value)
        {
            value = InputJsonDelta;
            return IsInputJsonDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaInputJsonContentBlockDelta PickInputJsonDelta() => InputJsonDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputJsonDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaCitationsDelta? CitationsDelta { get; init; }
#else
        public global::G.BetaCitationsDelta? CitationsDelta { get; }
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
            out global::G.BetaCitationsDelta? value)
        {
            value = CitationsDelta;
            return IsCitationsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaCitationsDelta PickCitationsDelta() => CitationsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CitationsDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaThinkingContentBlockDelta? ThinkingDelta { get; init; }
#else
        public global::G.BetaThinkingContentBlockDelta? ThinkingDelta { get; }
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
            out global::G.BetaThinkingContentBlockDelta? value)
        {
            value = ThinkingDelta;
            return IsThinkingDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaThinkingContentBlockDelta PickThinkingDelta() => ThinkingDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkingDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaSignatureContentBlockDelta? SignatureDelta { get; init; }
#else
        public global::G.BetaSignatureContentBlockDelta? SignatureDelta { get; }
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
            out global::G.BetaSignatureContentBlockDelta? value)
        {
            value = SignatureDelta;
            return IsSignatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaSignatureContentBlockDelta PickSignatureDelta() => SignatureDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SignatureDelta' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.BetaTextContentBlockDelta value) => new Delta2((global::G.BetaTextContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTextContentBlockDelta?(Delta2 @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.BetaTextContentBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta2 FromTextDelta(global::G.BetaTextContentBlockDelta? value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.BetaInputJsonContentBlockDelta value) => new Delta2((global::G.BetaInputJsonContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaInputJsonContentBlockDelta?(Delta2 @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.BetaInputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta2 FromInputJsonDelta(global::G.BetaInputJsonContentBlockDelta? value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.BetaCitationsDelta value) => new Delta2((global::G.BetaCitationsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaCitationsDelta?(Delta2 @this) => @this.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.BetaCitationsDelta? value)
        {
            CitationsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta2 FromCitationsDelta(global::G.BetaCitationsDelta? value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.BetaThinkingContentBlockDelta value) => new Delta2((global::G.BetaThinkingContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaThinkingContentBlockDelta?(Delta2 @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.BetaThinkingContentBlockDelta? value)
        {
            ThinkingDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta2 FromThinkingDelta(global::G.BetaThinkingContentBlockDelta? value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.BetaSignatureContentBlockDelta value) => new Delta2((global::G.BetaSignatureContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaSignatureContentBlockDelta?(Delta2 @this) => @this.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.BetaSignatureContentBlockDelta? value)
        {
            SignatureDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Delta2 FromSignatureDelta(global::G.BetaSignatureContentBlockDelta? value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public Delta2(
            global::G.BetaContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::G.BetaTextContentBlockDelta? textDelta,
            global::G.BetaInputJsonContentBlockDelta? inputJsonDelta,
            global::G.BetaCitationsDelta? citationsDelta,
            global::G.BetaThinkingContentBlockDelta? thinkingDelta,
            global::G.BetaSignatureContentBlockDelta? signatureDelta
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
            global::System.Func<global::G.BetaTextContentBlockDelta, TResult>? textDelta = null,
            global::System.Func<global::G.BetaInputJsonContentBlockDelta, TResult>? inputJsonDelta = null,
            global::System.Func<global::G.BetaCitationsDelta, TResult>? citationsDelta = null,
            global::System.Func<global::G.BetaThinkingContentBlockDelta, TResult>? thinkingDelta = null,
            global::System.Func<global::G.BetaSignatureContentBlockDelta, TResult>? signatureDelta = null,
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
            global::System.Action<global::G.BetaTextContentBlockDelta>? textDelta = null,

            global::System.Action<global::G.BetaInputJsonContentBlockDelta>? inputJsonDelta = null,

            global::System.Action<global::G.BetaCitationsDelta>? citationsDelta = null,

            global::System.Action<global::G.BetaThinkingContentBlockDelta>? thinkingDelta = null,

            global::System.Action<global::G.BetaSignatureContentBlockDelta>? signatureDelta = null,
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
            global::System.Action<global::G.BetaTextContentBlockDelta>? textDelta = null,
            global::System.Action<global::G.BetaInputJsonContentBlockDelta>? inputJsonDelta = null,
            global::System.Action<global::G.BetaCitationsDelta>? citationsDelta = null,
            global::System.Action<global::G.BetaThinkingContentBlockDelta>? thinkingDelta = null,
            global::System.Action<global::G.BetaSignatureContentBlockDelta>? signatureDelta = null,
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
                typeof(global::G.BetaTextContentBlockDelta),
                InputJsonDelta,
                typeof(global::G.BetaInputJsonContentBlockDelta),
                CitationsDelta,
                typeof(global::G.BetaCitationsDelta),
                ThinkingDelta,
                typeof(global::G.BetaThinkingContentBlockDelta),
                SignatureDelta,
                typeof(global::G.BetaSignatureContentBlockDelta),
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
        public bool Equals(Delta2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaTextContentBlockDelta?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaInputJsonContentBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaCitationsDelta?>.Default.Equals(CitationsDelta, other.CitationsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaThinkingContentBlockDelta?>.Default.Equals(ThinkingDelta, other.ThinkingDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaSignatureContentBlockDelta?>.Default.Equals(SignatureDelta, other.SignatureDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Delta2 obj1, Delta2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Delta2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Delta2 obj1, Delta2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Delta2 o && Equals(o);
        }
    }
}
