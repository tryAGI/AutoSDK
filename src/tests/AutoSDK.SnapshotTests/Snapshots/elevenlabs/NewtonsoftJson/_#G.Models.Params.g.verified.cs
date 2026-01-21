//HintName: G.Models.Params.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params : global::System.IEquatable<Params>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType? SystemToolType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EndCallToolConfig? EndCall { get; init; }
#else
        public global::G.EndCallToolConfig? EndCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCall))]
#endif
        public bool IsEndCall => EndCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LanguageDetectionToolConfig? LanguageDetection { get; init; }
#else
        public global::G.LanguageDetectionToolConfig? LanguageDetection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LanguageDetection))]
#endif
        public bool IsLanguageDetection => LanguageDetection != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToAgentToolConfig? TransferToAgent { get; init; }
#else
        public global::G.TransferToAgentToolConfig? TransferToAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToAgent))]
#endif
        public bool IsTransferToAgent => TransferToAgent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToNumberToolConfig? TransferToNumber { get; init; }
#else
        public global::G.TransferToNumberToolConfig? TransferToNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumber))]
#endif
        public bool IsTransferToNumber => TransferToNumber != null;

        /// <summary>
        /// Allows the agent to explicitly skip its turn.<br/>
        /// This tool should be invoked by the LLM when the user indicates they would like<br/>
        /// to think or take a short pause before continuing the conversation—e.g. when<br/>
        /// they say: "Give me a second", "Let me think", or "One moment please".  After<br/>
        /// calling this tool, the assistant should not speak until the user speaks<br/>
        /// again, or another normal turn-taking condition is met.  The tool itself has<br/>
        /// no parameters and performs no side-effects other than informing the backend<br/>
        /// that the current turn generation is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SkipTurnToolConfig? SkipTurn { get; init; }
#else
        public global::G.SkipTurnToolConfig? SkipTurn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkipTurn))]
#endif
        public bool IsSkipTurn => SkipTurn != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.EndCallToolConfig value) => new Params((global::G.EndCallToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndCallToolConfig?(Params @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.EndCallToolConfig? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.LanguageDetectionToolConfig value) => new Params((global::G.LanguageDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LanguageDetectionToolConfig?(Params @this) => @this.LanguageDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.LanguageDetectionToolConfig? value)
        {
            LanguageDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.TransferToAgentToolConfig value) => new Params((global::G.TransferToAgentToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToAgentToolConfig?(Params @this) => @this.TransferToAgent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.TransferToAgentToolConfig? value)
        {
            TransferToAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.TransferToNumberToolConfig value) => new Params((global::G.TransferToNumberToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToNumberToolConfig?(Params @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.TransferToNumberToolConfig? value)
        {
            TransferToNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::G.SkipTurnToolConfig value) => new Params((global::G.SkipTurnToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SkipTurnToolConfig?(Params @this) => @this.SkipTurn;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::G.SkipTurnToolConfig? value)
        {
            SkipTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params(
            global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType? systemToolType,
            global::G.EndCallToolConfig? endCall,
            global::G.LanguageDetectionToolConfig? languageDetection,
            global::G.TransferToAgentToolConfig? transferToAgent,
            global::G.TransferToNumberToolConfig? transferToNumber,
            global::G.SkipTurnToolConfig? skipTurn
            )
        {
            SystemToolType = systemToolType;

            EndCall = endCall;
            LanguageDetection = languageDetection;
            TransferToAgent = transferToAgent;
            TransferToNumber = transferToNumber;
            SkipTurn = skipTurn;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SkipTurn as object ??
            TransferToNumber as object ??
            TransferToAgent as object ??
            LanguageDetection as object ??
            EndCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndCall?.ToString() ??
            LanguageDetection?.ToString() ??
            TransferToAgent?.ToString() ??
            TransferToNumber?.ToString() ??
            SkipTurn?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber && !IsSkipTurn || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && IsSkipTurn;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EndCallToolConfig?, TResult>? endCall = null,
            global::System.Func<global::G.LanguageDetectionToolConfig?, TResult>? languageDetection = null,
            global::System.Func<global::G.TransferToAgentToolConfig?, TResult>? transferToAgent = null,
            global::System.Func<global::G.TransferToNumberToolConfig?, TResult>? transferToNumber = null,
            global::System.Func<global::G.SkipTurnToolConfig?, TResult>? skipTurn = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall && endCall != null)
            {
                return endCall(EndCall!);
            }
            else if (IsLanguageDetection && languageDetection != null)
            {
                return languageDetection(LanguageDetection!);
            }
            else if (IsTransferToAgent && transferToAgent != null)
            {
                return transferToAgent(TransferToAgent!);
            }
            else if (IsTransferToNumber && transferToNumber != null)
            {
                return transferToNumber(TransferToNumber!);
            }
            else if (IsSkipTurn && skipTurn != null)
            {
                return skipTurn(SkipTurn!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EndCallToolConfig?>? endCall = null,
            global::System.Action<global::G.LanguageDetectionToolConfig?>? languageDetection = null,
            global::System.Action<global::G.TransferToAgentToolConfig?>? transferToAgent = null,
            global::System.Action<global::G.TransferToNumberToolConfig?>? transferToNumber = null,
            global::System.Action<global::G.SkipTurnToolConfig?>? skipTurn = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsLanguageDetection)
            {
                languageDetection?.Invoke(LanguageDetection!);
            }
            else if (IsTransferToAgent)
            {
                transferToAgent?.Invoke(TransferToAgent!);
            }
            else if (IsTransferToNumber)
            {
                transferToNumber?.Invoke(TransferToNumber!);
            }
            else if (IsSkipTurn)
            {
                skipTurn?.Invoke(SkipTurn!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndCall,
                typeof(global::G.EndCallToolConfig),
                LanguageDetection,
                typeof(global::G.LanguageDetectionToolConfig),
                TransferToAgent,
                typeof(global::G.TransferToAgentToolConfig),
                TransferToNumber,
                typeof(global::G.TransferToNumberToolConfig),
                SkipTurn,
                typeof(global::G.SkipTurnToolConfig),
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
        public bool Equals(Params other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EndCallToolConfig?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LanguageDetectionToolConfig?>.Default.Equals(LanguageDetection, other.LanguageDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToAgentToolConfig?>.Default.Equals(TransferToAgent, other.TransferToAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToNumberToolConfig?>.Default.Equals(TransferToNumber, other.TransferToNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SkipTurnToolConfig?>.Default.Equals(SkipTurn, other.SkipTurn) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params obj1, Params obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params obj1, Params obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params o && Equals(o);
        }
    }
}
