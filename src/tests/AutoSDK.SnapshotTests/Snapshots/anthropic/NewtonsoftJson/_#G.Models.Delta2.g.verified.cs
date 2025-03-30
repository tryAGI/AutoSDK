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
        public static implicit operator Delta2(global::G.TextContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContentBlockDelta?(Delta2 @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.TextContentBlockDelta? value)
        {
            TextDelta = value;
        }

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
        public static implicit operator Delta2(global::G.InputJsonContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputJsonContentBlockDelta?(Delta2 @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.InputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

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
        public static implicit operator Delta2(global::G.CitationsDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CitationsDelta?(Delta2 @this) => @this.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.CitationsDelta? value)
        {
            CitationsDelta = value;
        }

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
        public static implicit operator Delta2(global::G.ThinkingContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThinkingContentBlockDelta?(Delta2 @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.ThinkingContentBlockDelta? value)
        {
            ThinkingDelta = value;
        }

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
        public static implicit operator Delta2(global::G.SignatureContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SignatureContentBlockDelta?(Delta2 @this) => @this.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.SignatureContentBlockDelta? value)
        {
            SignatureDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta2(
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
            global::System.Func<global::G.TextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::G.InputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
            global::System.Func<global::G.CitationsDelta?, TResult>? citationsDelta = null,
            global::System.Func<global::G.ThinkingContentBlockDelta?, TResult>? thinkingDelta = null,
            global::System.Func<global::G.SignatureContentBlockDelta?, TResult>? signatureDelta = null,
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
            global::System.Action<global::G.TextContentBlockDelta?>? textDelta = null,
            global::System.Action<global::G.InputJsonContentBlockDelta?>? inputJsonDelta = null,
            global::System.Action<global::G.CitationsDelta?>? citationsDelta = null,
            global::System.Action<global::G.ThinkingContentBlockDelta?>? thinkingDelta = null,
            global::System.Action<global::G.SignatureContentBlockDelta?>? signatureDelta = null,
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
        public bool Equals(Delta2 other)
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
