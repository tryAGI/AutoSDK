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
        public static implicit operator Delta(global::G.BetaTextContentBlockDelta value) => new Delta((global::G.BetaTextContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTextContentBlockDelta?(Delta @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.BetaTextContentBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.BetaInputJsonContentBlockDelta value) => new Delta((global::G.BetaInputJsonContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaInputJsonContentBlockDelta?(Delta @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.BetaInputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.BetaCitationsDelta value) => new Delta((global::G.BetaCitationsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaCitationsDelta?(Delta @this) => @this.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.BetaCitationsDelta? value)
        {
            CitationsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.BetaThinkingContentBlockDelta value) => new Delta((global::G.BetaThinkingContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaThinkingContentBlockDelta?(Delta @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.BetaThinkingContentBlockDelta? value)
        {
            ThinkingDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::G.BetaSignatureContentBlockDelta value) => new Delta((global::G.BetaSignatureContentBlockDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaSignatureContentBlockDelta?(Delta @this) => @this.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::G.BetaSignatureContentBlockDelta? value)
        {
            SignatureDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta(
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
            global::System.Func<global::G.BetaTextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::G.BetaInputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
            global::System.Func<global::G.BetaCitationsDelta?, TResult>? citationsDelta = null,
            global::System.Func<global::G.BetaThinkingContentBlockDelta?, TResult>? thinkingDelta = null,
            global::System.Func<global::G.BetaSignatureContentBlockDelta?, TResult>? signatureDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsInputJsonDelta && inputJsonDelta != null)
            {
                return inputJsonDelta(InputJsonDelta!);
            }
            else if (IsCitationsDelta && citationsDelta != null)
            {
                return citationsDelta(CitationsDelta!);
            }
            else if (IsThinkingDelta && thinkingDelta != null)
            {
                return thinkingDelta(ThinkingDelta!);
            }
            else if (IsSignatureDelta && signatureDelta != null)
            {
                return signatureDelta(SignatureDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaTextContentBlockDelta?>? textDelta = null,
            global::System.Action<global::G.BetaInputJsonContentBlockDelta?>? inputJsonDelta = null,
            global::System.Action<global::G.BetaCitationsDelta?>? citationsDelta = null,
            global::System.Action<global::G.BetaThinkingContentBlockDelta?>? thinkingDelta = null,
            global::System.Action<global::G.BetaSignatureContentBlockDelta?>? signatureDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsInputJsonDelta)
            {
                inputJsonDelta?.Invoke(InputJsonDelta!);
            }
            else if (IsCitationsDelta)
            {
                citationsDelta?.Invoke(CitationsDelta!);
            }
            else if (IsThinkingDelta)
            {
                thinkingDelta?.Invoke(ThinkingDelta!);
            }
            else if (IsSignatureDelta)
            {
                signatureDelta?.Invoke(SignatureDelta!);
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
        public bool Equals(Delta other)
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
