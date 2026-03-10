//HintName: G.Models.Params3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params3 : global::System.IEquatable<Params3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SystemToolConfigOutputParamsDiscriminatorSystemToolType? SystemToolType { get; }

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
        public global::G.TransferToNumberToolConfigOutput? TransferToNumber { get; init; }
#else
        public global::G.TransferToNumberToolConfigOutput? TransferToNumber { get; }
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
        /// Allows the agent to play DTMF tones during a phone call.<br/>
        /// This tool can be used to interact with automated phone systems, such as<br/>
        /// navigating phone menus, entering extensions, or inputting numeric codes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PlayDTMFToolConfig? PlayKeypadTouchTone { get; init; }
#else
        public global::G.PlayDTMFToolConfig? PlayKeypadTouchTone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlayKeypadTouchTone))]
#endif
        public bool IsPlayKeypadTouchTone => PlayKeypadTouchTone != null;

        /// <summary>
        /// Allows the agent to detect when a voicemail system is encountered.<br/>
        /// This tool should be invoked by the LLM when it detects that the call has been<br/>
        /// answered by a voicemail system rather than a human. If a voicemail message<br/>
        /// is configured, it will be played; otherwise the call will end immediately.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VoicemailDetectionToolConfig? VoicemailDetection { get; init; }
#else
        public global::G.VoicemailDetectionToolConfig? VoicemailDetection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoicemailDetection))]
#endif
        public bool IsVoicemailDetection => VoicemailDetection != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MemoryEntrySearchToolConfig? MemoryEntrySearch { get; init; }
#else
        public global::G.MemoryEntrySearchToolConfig? MemoryEntrySearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntrySearch))]
#endif
        public bool IsMemoryEntrySearch => MemoryEntrySearch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MemoryEntryCreateToolConfig? MemoryEntryCreate { get; init; }
#else
        public global::G.MemoryEntryCreateToolConfig? MemoryEntryCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntryCreate))]
#endif
        public bool IsMemoryEntryCreate => MemoryEntryCreate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MemoryEntryUpdateToolConfig? MemoryEntryUpdate { get; init; }
#else
        public global::G.MemoryEntryUpdateToolConfig? MemoryEntryUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntryUpdate))]
#endif
        public bool IsMemoryEntryUpdate => MemoryEntryUpdate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MemoryEntryDeleteToolConfig? MemoryEntryDelete { get; init; }
#else
        public global::G.MemoryEntryDeleteToolConfig? MemoryEntryDelete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntryDelete))]
#endif
        public bool IsMemoryEntryDelete => MemoryEntryDelete != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentPromptChangeToolConfig? AgentPromptChange { get; init; }
#else
        public global::G.AgentPromptChangeToolConfig? AgentPromptChange { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentPromptChange))]
#endif
        public bool IsAgentPromptChange => AgentPromptChange != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.EndCallToolConfig value) => new Params3((global::G.EndCallToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndCallToolConfig?(Params3 @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.EndCallToolConfig? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.LanguageDetectionToolConfig value) => new Params3((global::G.LanguageDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LanguageDetectionToolConfig?(Params3 @this) => @this.LanguageDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.LanguageDetectionToolConfig? value)
        {
            LanguageDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.TransferToAgentToolConfig value) => new Params3((global::G.TransferToAgentToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToAgentToolConfig?(Params3 @this) => @this.TransferToAgent;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.TransferToAgentToolConfig? value)
        {
            TransferToAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.TransferToNumberToolConfigOutput value) => new Params3((global::G.TransferToNumberToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToNumberToolConfigOutput?(Params3 @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.TransferToNumberToolConfigOutput? value)
        {
            TransferToNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.SkipTurnToolConfig value) => new Params3((global::G.SkipTurnToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SkipTurnToolConfig?(Params3 @this) => @this.SkipTurn;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.SkipTurnToolConfig? value)
        {
            SkipTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.PlayDTMFToolConfig value) => new Params3((global::G.PlayDTMFToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PlayDTMFToolConfig?(Params3 @this) => @this.PlayKeypadTouchTone;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.PlayDTMFToolConfig? value)
        {
            PlayKeypadTouchTone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.VoicemailDetectionToolConfig value) => new Params3((global::G.VoicemailDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoicemailDetectionToolConfig?(Params3 @this) => @this.VoicemailDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.VoicemailDetectionToolConfig? value)
        {
            VoicemailDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.MemoryEntrySearchToolConfig value) => new Params3((global::G.MemoryEntrySearchToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MemoryEntrySearchToolConfig?(Params3 @this) => @this.MemoryEntrySearch;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.MemoryEntrySearchToolConfig? value)
        {
            MemoryEntrySearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.MemoryEntryCreateToolConfig value) => new Params3((global::G.MemoryEntryCreateToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MemoryEntryCreateToolConfig?(Params3 @this) => @this.MemoryEntryCreate;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.MemoryEntryCreateToolConfig? value)
        {
            MemoryEntryCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.MemoryEntryUpdateToolConfig value) => new Params3((global::G.MemoryEntryUpdateToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MemoryEntryUpdateToolConfig?(Params3 @this) => @this.MemoryEntryUpdate;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.MemoryEntryUpdateToolConfig? value)
        {
            MemoryEntryUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.MemoryEntryDeleteToolConfig value) => new Params3((global::G.MemoryEntryDeleteToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MemoryEntryDeleteToolConfig?(Params3 @this) => @this.MemoryEntryDelete;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.MemoryEntryDeleteToolConfig? value)
        {
            MemoryEntryDelete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::G.AgentPromptChangeToolConfig value) => new Params3((global::G.AgentPromptChangeToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentPromptChangeToolConfig?(Params3 @this) => @this.AgentPromptChange;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::G.AgentPromptChangeToolConfig? value)
        {
            AgentPromptChange = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params3(
            global::G.SystemToolConfigOutputParamsDiscriminatorSystemToolType? systemToolType,
            global::G.EndCallToolConfig? endCall,
            global::G.LanguageDetectionToolConfig? languageDetection,
            global::G.TransferToAgentToolConfig? transferToAgent,
            global::G.TransferToNumberToolConfigOutput? transferToNumber,
            global::G.SkipTurnToolConfig? skipTurn,
            global::G.PlayDTMFToolConfig? playKeypadTouchTone,
            global::G.VoicemailDetectionToolConfig? voicemailDetection,
            global::G.MemoryEntrySearchToolConfig? memoryEntrySearch,
            global::G.MemoryEntryCreateToolConfig? memoryEntryCreate,
            global::G.MemoryEntryUpdateToolConfig? memoryEntryUpdate,
            global::G.MemoryEntryDeleteToolConfig? memoryEntryDelete,
            global::G.AgentPromptChangeToolConfig? agentPromptChange
            )
        {
            SystemToolType = systemToolType;

            EndCall = endCall;
            LanguageDetection = languageDetection;
            TransferToAgent = transferToAgent;
            TransferToNumber = transferToNumber;
            SkipTurn = skipTurn;
            PlayKeypadTouchTone = playKeypadTouchTone;
            VoicemailDetection = voicemailDetection;
            MemoryEntrySearch = memoryEntrySearch;
            MemoryEntryCreate = memoryEntryCreate;
            MemoryEntryUpdate = memoryEntryUpdate;
            MemoryEntryDelete = memoryEntryDelete;
            AgentPromptChange = agentPromptChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentPromptChange as object ??
            MemoryEntryDelete as object ??
            MemoryEntryUpdate as object ??
            MemoryEntryCreate as object ??
            MemoryEntrySearch as object ??
            VoicemailDetection as object ??
            PlayKeypadTouchTone as object ??
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
            SkipTurn?.ToString() ??
            PlayKeypadTouchTone?.ToString() ??
            VoicemailDetection?.ToString() ??
            MemoryEntrySearch?.ToString() ??
            MemoryEntryCreate?.ToString() ??
            MemoryEntryUpdate?.ToString() ??
            MemoryEntryDelete?.ToString() ??
            AgentPromptChange?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && IsAgentPromptChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EndCallToolConfig?, TResult>? endCall = null,
            global::System.Func<global::G.LanguageDetectionToolConfig?, TResult>? languageDetection = null,
            global::System.Func<global::G.TransferToAgentToolConfig?, TResult>? transferToAgent = null,
            global::System.Func<global::G.TransferToNumberToolConfigOutput?, TResult>? transferToNumber = null,
            global::System.Func<global::G.SkipTurnToolConfig?, TResult>? skipTurn = null,
            global::System.Func<global::G.PlayDTMFToolConfig?, TResult>? playKeypadTouchTone = null,
            global::System.Func<global::G.VoicemailDetectionToolConfig?, TResult>? voicemailDetection = null,
            global::System.Func<global::G.MemoryEntrySearchToolConfig?, TResult>? memoryEntrySearch = null,
            global::System.Func<global::G.MemoryEntryCreateToolConfig?, TResult>? memoryEntryCreate = null,
            global::System.Func<global::G.MemoryEntryUpdateToolConfig?, TResult>? memoryEntryUpdate = null,
            global::System.Func<global::G.MemoryEntryDeleteToolConfig?, TResult>? memoryEntryDelete = null,
            global::System.Func<global::G.AgentPromptChangeToolConfig?, TResult>? agentPromptChange = null,
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
            else if (IsPlayKeypadTouchTone && playKeypadTouchTone != null)
            {
                return playKeypadTouchTone(PlayKeypadTouchTone!);
            }
            else if (IsVoicemailDetection && voicemailDetection != null)
            {
                return voicemailDetection(VoicemailDetection!);
            }
            else if (IsMemoryEntrySearch && memoryEntrySearch != null)
            {
                return memoryEntrySearch(MemoryEntrySearch!);
            }
            else if (IsMemoryEntryCreate && memoryEntryCreate != null)
            {
                return memoryEntryCreate(MemoryEntryCreate!);
            }
            else if (IsMemoryEntryUpdate && memoryEntryUpdate != null)
            {
                return memoryEntryUpdate(MemoryEntryUpdate!);
            }
            else if (IsMemoryEntryDelete && memoryEntryDelete != null)
            {
                return memoryEntryDelete(MemoryEntryDelete!);
            }
            else if (IsAgentPromptChange && agentPromptChange != null)
            {
                return agentPromptChange(AgentPromptChange!);
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
            global::System.Action<global::G.TransferToNumberToolConfigOutput?>? transferToNumber = null,
            global::System.Action<global::G.SkipTurnToolConfig?>? skipTurn = null,
            global::System.Action<global::G.PlayDTMFToolConfig?>? playKeypadTouchTone = null,
            global::System.Action<global::G.VoicemailDetectionToolConfig?>? voicemailDetection = null,
            global::System.Action<global::G.MemoryEntrySearchToolConfig?>? memoryEntrySearch = null,
            global::System.Action<global::G.MemoryEntryCreateToolConfig?>? memoryEntryCreate = null,
            global::System.Action<global::G.MemoryEntryUpdateToolConfig?>? memoryEntryUpdate = null,
            global::System.Action<global::G.MemoryEntryDeleteToolConfig?>? memoryEntryDelete = null,
            global::System.Action<global::G.AgentPromptChangeToolConfig?>? agentPromptChange = null,
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
            else if (IsPlayKeypadTouchTone)
            {
                playKeypadTouchTone?.Invoke(PlayKeypadTouchTone!);
            }
            else if (IsVoicemailDetection)
            {
                voicemailDetection?.Invoke(VoicemailDetection!);
            }
            else if (IsMemoryEntrySearch)
            {
                memoryEntrySearch?.Invoke(MemoryEntrySearch!);
            }
            else if (IsMemoryEntryCreate)
            {
                memoryEntryCreate?.Invoke(MemoryEntryCreate!);
            }
            else if (IsMemoryEntryUpdate)
            {
                memoryEntryUpdate?.Invoke(MemoryEntryUpdate!);
            }
            else if (IsMemoryEntryDelete)
            {
                memoryEntryDelete?.Invoke(MemoryEntryDelete!);
            }
            else if (IsAgentPromptChange)
            {
                agentPromptChange?.Invoke(AgentPromptChange!);
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
                typeof(global::G.TransferToNumberToolConfigOutput),
                SkipTurn,
                typeof(global::G.SkipTurnToolConfig),
                PlayKeypadTouchTone,
                typeof(global::G.PlayDTMFToolConfig),
                VoicemailDetection,
                typeof(global::G.VoicemailDetectionToolConfig),
                MemoryEntrySearch,
                typeof(global::G.MemoryEntrySearchToolConfig),
                MemoryEntryCreate,
                typeof(global::G.MemoryEntryCreateToolConfig),
                MemoryEntryUpdate,
                typeof(global::G.MemoryEntryUpdateToolConfig),
                MemoryEntryDelete,
                typeof(global::G.MemoryEntryDeleteToolConfig),
                AgentPromptChange,
                typeof(global::G.AgentPromptChangeToolConfig),
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
        public bool Equals(Params3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EndCallToolConfig?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LanguageDetectionToolConfig?>.Default.Equals(LanguageDetection, other.LanguageDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToAgentToolConfig?>.Default.Equals(TransferToAgent, other.TransferToAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToNumberToolConfigOutput?>.Default.Equals(TransferToNumber, other.TransferToNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SkipTurnToolConfig?>.Default.Equals(SkipTurn, other.SkipTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PlayDTMFToolConfig?>.Default.Equals(PlayKeypadTouchTone, other.PlayKeypadTouchTone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoicemailDetectionToolConfig?>.Default.Equals(VoicemailDetection, other.VoicemailDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MemoryEntrySearchToolConfig?>.Default.Equals(MemoryEntrySearch, other.MemoryEntrySearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MemoryEntryCreateToolConfig?>.Default.Equals(MemoryEntryCreate, other.MemoryEntryCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MemoryEntryUpdateToolConfig?>.Default.Equals(MemoryEntryUpdate, other.MemoryEntryUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MemoryEntryDeleteToolConfig?>.Default.Equals(MemoryEntryDelete, other.MemoryEntryDelete) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentPromptChangeToolConfig?>.Default.Equals(AgentPromptChange, other.AgentPromptChange) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params3 obj1, Params3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params3 obj1, Params3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params3 o && Equals(o);
        }
    }
}
