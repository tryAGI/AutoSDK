//HintName: G.Models.Tool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EndCallTool? EndCall { get; init; }
#else
        public global::G.EndCallTool? EndCall { get; }
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
        public global::G.TransferCallTool? TransferCall { get; init; }
#else
        public global::G.TransferCallTool? TransferCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferCall))]
#endif
        public bool IsTransferCall => TransferCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CheckAvailabilityCalTool? CheckAvailabilityCal { get; init; }
#else
        public global::G.CheckAvailabilityCalTool? CheckAvailabilityCal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CheckAvailabilityCal))]
#endif
        public bool IsCheckAvailabilityCal => CheckAvailabilityCal != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BookAppointmentCalTool? BookAppointmentCal { get; init; }
#else
        public global::G.BookAppointmentCalTool? BookAppointmentCal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BookAppointmentCal))]
#endif
        public bool IsBookAppointmentCal => BookAppointmentCal != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentSwapTool? AgentSwap { get; init; }
#else
        public global::G.AgentSwapTool? AgentSwap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSwap))]
#endif
        public bool IsAgentSwap => AgentSwap != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PressDigitTool? PressDigit { get; init; }
#else
        public global::G.PressDigitTool? PressDigit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PressDigit))]
#endif
        public bool IsPressDigit => PressDigit != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SendSMSTool? SendSM { get; init; }
#else
        public global::G.SendSMSTool? SendSM { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SendSM))]
#endif
        public bool IsSendSM => SendSM != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomTool? Custom { get; init; }
#else
        public global::G.CustomTool? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeTool? Code { get; init; }
#else
        public global::G.CodeTool? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExtractDynamicVariableTool? ExtractDynamicVariable { get; init; }
#else
        public global::G.ExtractDynamicVariableTool? ExtractDynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtractDynamicVariable))]
#endif
        public bool IsExtractDynamicVariable => ExtractDynamicVariable != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BridgeTransferTool? BridgeTransfer { get; init; }
#else
        public global::G.BridgeTransferTool? BridgeTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BridgeTransfer))]
#endif
        public bool IsBridgeTransfer => BridgeTransfer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CancelTransferTool? CancelTransfer { get; init; }
#else
        public global::G.CancelTransferTool? CancelTransfer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelTransfer))]
#endif
        public bool IsCancelTransfer => CancelTransfer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPTool? MCP { get; init; }
#else
        public global::G.MCPTool? MCP { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCP))]
#endif
        public bool IsMCP => MCP != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.EndCallTool value) => new Tool((global::G.EndCallTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndCallTool?(Tool @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.EndCallTool? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.TransferCallTool value) => new Tool((global::G.TransferCallTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferCallTool?(Tool @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.TransferCallTool? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.CheckAvailabilityCalTool value) => new Tool((global::G.CheckAvailabilityCalTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CheckAvailabilityCalTool?(Tool @this) => @this.CheckAvailabilityCal;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.CheckAvailabilityCalTool? value)
        {
            CheckAvailabilityCal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.BookAppointmentCalTool value) => new Tool((global::G.BookAppointmentCalTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BookAppointmentCalTool?(Tool @this) => @this.BookAppointmentCal;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.BookAppointmentCalTool? value)
        {
            BookAppointmentCal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.AgentSwapTool value) => new Tool((global::G.AgentSwapTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentSwapTool?(Tool @this) => @this.AgentSwap;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.AgentSwapTool? value)
        {
            AgentSwap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.PressDigitTool value) => new Tool((global::G.PressDigitTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PressDigitTool?(Tool @this) => @this.PressDigit;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.PressDigitTool? value)
        {
            PressDigit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.SendSMSTool value) => new Tool((global::G.SendSMSTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SendSMSTool?(Tool @this) => @this.SendSM;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.SendSMSTool? value)
        {
            SendSM = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.CustomTool value) => new Tool((global::G.CustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomTool?(Tool @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.CustomTool? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.CodeTool value) => new Tool((global::G.CodeTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeTool?(Tool @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.CodeTool? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ExtractDynamicVariableTool value) => new Tool((global::G.ExtractDynamicVariableTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExtractDynamicVariableTool?(Tool @this) => @this.ExtractDynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ExtractDynamicVariableTool? value)
        {
            ExtractDynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.BridgeTransferTool value) => new Tool((global::G.BridgeTransferTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BridgeTransferTool?(Tool @this) => @this.BridgeTransfer;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.BridgeTransferTool? value)
        {
            BridgeTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.CancelTransferTool value) => new Tool((global::G.CancelTransferTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CancelTransferTool?(Tool @this) => @this.CancelTransfer;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.CancelTransferTool? value)
        {
            CancelTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.MCPTool value) => new Tool((global::G.MCPTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPTool?(Tool @this) => @this.MCP;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.MCPTool? value)
        {
            MCP = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::G.EndCallTool? endCall,
            global::G.TransferCallTool? transferCall,
            global::G.CheckAvailabilityCalTool? checkAvailabilityCal,
            global::G.BookAppointmentCalTool? bookAppointmentCal,
            global::G.AgentSwapTool? agentSwap,
            global::G.PressDigitTool? pressDigit,
            global::G.SendSMSTool? sendSM,
            global::G.CustomTool? custom,
            global::G.CodeTool? code,
            global::G.ExtractDynamicVariableTool? extractDynamicVariable,
            global::G.BridgeTransferTool? bridgeTransfer,
            global::G.CancelTransferTool? cancelTransfer,
            global::G.MCPTool? mCP
            )
        {
            EndCall = endCall;
            TransferCall = transferCall;
            CheckAvailabilityCal = checkAvailabilityCal;
            BookAppointmentCal = bookAppointmentCal;
            AgentSwap = agentSwap;
            PressDigit = pressDigit;
            SendSM = sendSM;
            Custom = custom;
            Code = code;
            ExtractDynamicVariable = extractDynamicVariable;
            BridgeTransfer = bridgeTransfer;
            CancelTransfer = cancelTransfer;
            MCP = mCP;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCP as object ??
            CancelTransfer as object ??
            BridgeTransfer as object ??
            ExtractDynamicVariable as object ??
            Code as object ??
            Custom as object ??
            SendSM as object ??
            PressDigit as object ??
            AgentSwap as object ??
            BookAppointmentCal as object ??
            CheckAvailabilityCal as object ??
            TransferCall as object ??
            EndCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndCall?.ToString() ??
            TransferCall?.ToString() ??
            CheckAvailabilityCal?.ToString() ??
            BookAppointmentCal?.ToString() ??
            AgentSwap?.ToString() ??
            PressDigit?.ToString() ??
            SendSM?.ToString() ??
            Custom?.ToString() ??
            Code?.ToString() ??
            ExtractDynamicVariable?.ToString() ??
            BridgeTransfer?.ToString() ??
            CancelTransfer?.ToString() ??
            MCP?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && IsBridgeTransfer && !IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && IsCancelTransfer && !IsMCP || !IsEndCall && !IsTransferCall && !IsCheckAvailabilityCal && !IsBookAppointmentCal && !IsAgentSwap && !IsPressDigit && !IsSendSM && !IsCustom && !IsCode && !IsExtractDynamicVariable && !IsBridgeTransfer && !IsCancelTransfer && IsMCP;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EndCallTool?, TResult>? endCall = null,
            global::System.Func<global::G.TransferCallTool?, TResult>? transferCall = null,
            global::System.Func<global::G.CheckAvailabilityCalTool?, TResult>? checkAvailabilityCal = null,
            global::System.Func<global::G.BookAppointmentCalTool?, TResult>? bookAppointmentCal = null,
            global::System.Func<global::G.AgentSwapTool?, TResult>? agentSwap = null,
            global::System.Func<global::G.PressDigitTool?, TResult>? pressDigit = null,
            global::System.Func<global::G.SendSMSTool?, TResult>? sendSM = null,
            global::System.Func<global::G.CustomTool?, TResult>? custom = null,
            global::System.Func<global::G.CodeTool?, TResult>? code = null,
            global::System.Func<global::G.ExtractDynamicVariableTool?, TResult>? extractDynamicVariable = null,
            global::System.Func<global::G.BridgeTransferTool?, TResult>? bridgeTransfer = null,
            global::System.Func<global::G.CancelTransferTool?, TResult>? cancelTransfer = null,
            global::System.Func<global::G.MCPTool?, TResult>? mCP = null,
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
            else if (IsTransferCall && transferCall != null)
            {
                return transferCall(TransferCall!);
            }
            else if (IsCheckAvailabilityCal && checkAvailabilityCal != null)
            {
                return checkAvailabilityCal(CheckAvailabilityCal!);
            }
            else if (IsBookAppointmentCal && bookAppointmentCal != null)
            {
                return bookAppointmentCal(BookAppointmentCal!);
            }
            else if (IsAgentSwap && agentSwap != null)
            {
                return agentSwap(AgentSwap!);
            }
            else if (IsPressDigit && pressDigit != null)
            {
                return pressDigit(PressDigit!);
            }
            else if (IsSendSM && sendSM != null)
            {
                return sendSM(SendSM!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsExtractDynamicVariable && extractDynamicVariable != null)
            {
                return extractDynamicVariable(ExtractDynamicVariable!);
            }
            else if (IsBridgeTransfer && bridgeTransfer != null)
            {
                return bridgeTransfer(BridgeTransfer!);
            }
            else if (IsCancelTransfer && cancelTransfer != null)
            {
                return cancelTransfer(CancelTransfer!);
            }
            else if (IsMCP && mCP != null)
            {
                return mCP(MCP!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EndCallTool?>? endCall = null,
            global::System.Action<global::G.TransferCallTool?>? transferCall = null,
            global::System.Action<global::G.CheckAvailabilityCalTool?>? checkAvailabilityCal = null,
            global::System.Action<global::G.BookAppointmentCalTool?>? bookAppointmentCal = null,
            global::System.Action<global::G.AgentSwapTool?>? agentSwap = null,
            global::System.Action<global::G.PressDigitTool?>? pressDigit = null,
            global::System.Action<global::G.SendSMSTool?>? sendSM = null,
            global::System.Action<global::G.CustomTool?>? custom = null,
            global::System.Action<global::G.CodeTool?>? code = null,
            global::System.Action<global::G.ExtractDynamicVariableTool?>? extractDynamicVariable = null,
            global::System.Action<global::G.BridgeTransferTool?>? bridgeTransfer = null,
            global::System.Action<global::G.CancelTransferTool?>? cancelTransfer = null,
            global::System.Action<global::G.MCPTool?>? mCP = null,
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
            else if (IsTransferCall)
            {
                transferCall?.Invoke(TransferCall!);
            }
            else if (IsCheckAvailabilityCal)
            {
                checkAvailabilityCal?.Invoke(CheckAvailabilityCal!);
            }
            else if (IsBookAppointmentCal)
            {
                bookAppointmentCal?.Invoke(BookAppointmentCal!);
            }
            else if (IsAgentSwap)
            {
                agentSwap?.Invoke(AgentSwap!);
            }
            else if (IsPressDigit)
            {
                pressDigit?.Invoke(PressDigit!);
            }
            else if (IsSendSM)
            {
                sendSM?.Invoke(SendSM!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsExtractDynamicVariable)
            {
                extractDynamicVariable?.Invoke(ExtractDynamicVariable!);
            }
            else if (IsBridgeTransfer)
            {
                bridgeTransfer?.Invoke(BridgeTransfer!);
            }
            else if (IsCancelTransfer)
            {
                cancelTransfer?.Invoke(CancelTransfer!);
            }
            else if (IsMCP)
            {
                mCP?.Invoke(MCP!);
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
                typeof(global::G.EndCallTool),
                TransferCall,
                typeof(global::G.TransferCallTool),
                CheckAvailabilityCal,
                typeof(global::G.CheckAvailabilityCalTool),
                BookAppointmentCal,
                typeof(global::G.BookAppointmentCalTool),
                AgentSwap,
                typeof(global::G.AgentSwapTool),
                PressDigit,
                typeof(global::G.PressDigitTool),
                SendSM,
                typeof(global::G.SendSMSTool),
                Custom,
                typeof(global::G.CustomTool),
                Code,
                typeof(global::G.CodeTool),
                ExtractDynamicVariable,
                typeof(global::G.ExtractDynamicVariableTool),
                BridgeTransfer,
                typeof(global::G.BridgeTransferTool),
                CancelTransfer,
                typeof(global::G.CancelTransferTool),
                MCP,
                typeof(global::G.MCPTool),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EndCallTool?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferCallTool?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CheckAvailabilityCalTool?>.Default.Equals(CheckAvailabilityCal, other.CheckAvailabilityCal) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BookAppointmentCalTool?>.Default.Equals(BookAppointmentCal, other.BookAppointmentCal) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentSwapTool?>.Default.Equals(AgentSwap, other.AgentSwap) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PressDigitTool?>.Default.Equals(PressDigit, other.PressDigit) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SendSMSTool?>.Default.Equals(SendSM, other.SendSM) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CustomTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeTool?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExtractDynamicVariableTool?>.Default.Equals(ExtractDynamicVariable, other.ExtractDynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BridgeTransferTool?>.Default.Equals(BridgeTransfer, other.BridgeTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CancelTransferTool?>.Default.Equals(CancelTransfer, other.CancelTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPTool?>.Default.Equals(MCP, other.MCP) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
