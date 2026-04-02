//HintName: G.Models.ConversationFlowNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationFlowNode : global::System.IEquatable<ConversationFlowNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationNode? ConversationNode { get; init; }
#else
        public global::G.ConversationNode? ConversationNode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationNode))]
#endif
        public bool IsConversationNode => ConversationNode != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EndNode? End { get; init; }
#else
        public global::G.EndNode? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionNode? Function { get; init; }
#else
        public global::G.FunctionNode? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeNode? Code { get; init; }
#else
        public global::G.CodeNode? Code { get; }
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
        public global::G.TransferCallNode? TransferCall { get; init; }
#else
        public global::G.TransferCallNode? TransferCall { get; }
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
        public global::G.PressDigitNode? PressDigit { get; init; }
#else
        public global::G.PressDigitNode? PressDigit { get; }
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
        public global::G.BranchNode? Branch { get; init; }
#else
        public global::G.BranchNode? Branch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsNode? Sms { get; init; }
#else
        public global::G.SmsNode? Sms { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sms))]
#endif
        public bool IsSms => Sms != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExtractDynamicVariablesNode? ExtractDynamicVariables { get; init; }
#else
        public global::G.ExtractDynamicVariablesNode? ExtractDynamicVariables { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtractDynamicVariables))]
#endif
        public bool IsExtractDynamicVariables => ExtractDynamicVariables != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentSwapNode? AgentSwap { get; init; }
#else
        public global::G.AgentSwapNode? AgentSwap { get; }
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
        public global::G.MCPNode? Mcp { get; init; }
#else
        public global::G.MCPNode? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComponentNode? Component { get; init; }
#else
        public global::G.ComponentNode? Component { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Component))]
#endif
        public bool IsComponent => Component != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BridgeTransferNode? BridgeTransfer { get; init; }
#else
        public global::G.BridgeTransferNode? BridgeTransfer { get; }
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
        public global::G.CancelTransferNode? CancelTransfer { get; init; }
#else
        public global::G.CancelTransferNode? CancelTransfer { get; }
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
        public static implicit operator ConversationFlowNode(global::G.ConversationNode value) => new ConversationFlowNode((global::G.ConversationNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationNode?(ConversationFlowNode @this) => @this.ConversationNode;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.ConversationNode? value)
        {
            ConversationNode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.EndNode value) => new ConversationFlowNode((global::G.EndNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndNode?(ConversationFlowNode @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.EndNode? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.FunctionNode value) => new ConversationFlowNode((global::G.FunctionNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionNode?(ConversationFlowNode @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.FunctionNode? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.CodeNode value) => new ConversationFlowNode((global::G.CodeNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeNode?(ConversationFlowNode @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.CodeNode? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.TransferCallNode value) => new ConversationFlowNode((global::G.TransferCallNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferCallNode?(ConversationFlowNode @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.TransferCallNode? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.PressDigitNode value) => new ConversationFlowNode((global::G.PressDigitNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PressDigitNode?(ConversationFlowNode @this) => @this.PressDigit;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.PressDigitNode? value)
        {
            PressDigit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.BranchNode value) => new ConversationFlowNode((global::G.BranchNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BranchNode?(ConversationFlowNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.BranchNode? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.SmsNode value) => new ConversationFlowNode((global::G.SmsNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsNode?(ConversationFlowNode @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.SmsNode? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.ExtractDynamicVariablesNode value) => new ConversationFlowNode((global::G.ExtractDynamicVariablesNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExtractDynamicVariablesNode?(ConversationFlowNode @this) => @this.ExtractDynamicVariables;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.ExtractDynamicVariablesNode? value)
        {
            ExtractDynamicVariables = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.AgentSwapNode value) => new ConversationFlowNode((global::G.AgentSwapNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentSwapNode?(ConversationFlowNode @this) => @this.AgentSwap;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.AgentSwapNode? value)
        {
            AgentSwap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.MCPNode value) => new ConversationFlowNode((global::G.MCPNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPNode?(ConversationFlowNode @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.MCPNode? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.ComponentNode value) => new ConversationFlowNode((global::G.ComponentNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComponentNode?(ConversationFlowNode @this) => @this.Component;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.ComponentNode? value)
        {
            Component = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.BridgeTransferNode value) => new ConversationFlowNode((global::G.BridgeTransferNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BridgeTransferNode?(ConversationFlowNode @this) => @this.BridgeTransfer;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.BridgeTransferNode? value)
        {
            BridgeTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.CancelTransferNode value) => new ConversationFlowNode((global::G.CancelTransferNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CancelTransferNode?(ConversationFlowNode @this) => @this.CancelTransfer;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.CancelTransferNode? value)
        {
            CancelTransfer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(
            global::G.ConversationNode? conversationNode,
            global::G.EndNode? end,
            global::G.FunctionNode? function,
            global::G.CodeNode? code,
            global::G.TransferCallNode? transferCall,
            global::G.PressDigitNode? pressDigit,
            global::G.BranchNode? branch,
            global::G.SmsNode? sms,
            global::G.ExtractDynamicVariablesNode? extractDynamicVariables,
            global::G.AgentSwapNode? agentSwap,
            global::G.MCPNode? mcp,
            global::G.ComponentNode? component,
            global::G.BridgeTransferNode? bridgeTransfer,
            global::G.CancelTransferNode? cancelTransfer
            )
        {
            ConversationNode = conversationNode;
            End = end;
            Function = function;
            Code = code;
            TransferCall = transferCall;
            PressDigit = pressDigit;
            Branch = branch;
            Sms = sms;
            ExtractDynamicVariables = extractDynamicVariables;
            AgentSwap = agentSwap;
            Mcp = mcp;
            Component = component;
            BridgeTransfer = bridgeTransfer;
            CancelTransfer = cancelTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CancelTransfer as object ??
            BridgeTransfer as object ??
            Component as object ??
            Mcp as object ??
            AgentSwap as object ??
            ExtractDynamicVariables as object ??
            Sms as object ??
            Branch as object ??
            PressDigit as object ??
            TransferCall as object ??
            Code as object ??
            Function as object ??
            End as object ??
            ConversationNode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationNode?.ToString() ??
            End?.ToString() ??
            Function?.ToString() ??
            Code?.ToString() ??
            TransferCall?.ToString() ??
            PressDigit?.ToString() ??
            Branch?.ToString() ??
            Sms?.ToString() ??
            ExtractDynamicVariables?.ToString() ??
            AgentSwap?.ToString() ??
            Mcp?.ToString() ??
            Component?.ToString() ??
            BridgeTransfer?.ToString() ??
            CancelTransfer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && IsMcp && !IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && IsComponent && !IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && IsBridgeTransfer && !IsCancelTransfer || !IsConversationNode && !IsEnd && !IsFunction && !IsCode && !IsTransferCall && !IsPressDigit && !IsBranch && !IsSms && !IsExtractDynamicVariables && !IsAgentSwap && !IsMcp && !IsComponent && !IsBridgeTransfer && IsCancelTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConversationNode?, TResult>? conversationNode = null,
            global::System.Func<global::G.EndNode?, TResult>? end = null,
            global::System.Func<global::G.FunctionNode?, TResult>? function = null,
            global::System.Func<global::G.CodeNode?, TResult>? code = null,
            global::System.Func<global::G.TransferCallNode?, TResult>? transferCall = null,
            global::System.Func<global::G.PressDigitNode?, TResult>? pressDigit = null,
            global::System.Func<global::G.BranchNode?, TResult>? branch = null,
            global::System.Func<global::G.SmsNode?, TResult>? sms = null,
            global::System.Func<global::G.ExtractDynamicVariablesNode?, TResult>? extractDynamicVariables = null,
            global::System.Func<global::G.AgentSwapNode?, TResult>? agentSwap = null,
            global::System.Func<global::G.MCPNode?, TResult>? mcp = null,
            global::System.Func<global::G.ComponentNode?, TResult>? component = null,
            global::System.Func<global::G.BridgeTransferNode?, TResult>? bridgeTransfer = null,
            global::System.Func<global::G.CancelTransferNode?, TResult>? cancelTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationNode && conversationNode != null)
            {
                return conversationNode(ConversationNode!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsTransferCall && transferCall != null)
            {
                return transferCall(TransferCall!);
            }
            else if (IsPressDigit && pressDigit != null)
            {
                return pressDigit(PressDigit!);
            }
            else if (IsBranch && branch != null)
            {
                return branch(Branch!);
            }
            else if (IsSms && sms != null)
            {
                return sms(Sms!);
            }
            else if (IsExtractDynamicVariables && extractDynamicVariables != null)
            {
                return extractDynamicVariables(ExtractDynamicVariables!);
            }
            else if (IsAgentSwap && agentSwap != null)
            {
                return agentSwap(AgentSwap!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsComponent && component != null)
            {
                return component(Component!);
            }
            else if (IsBridgeTransfer && bridgeTransfer != null)
            {
                return bridgeTransfer(BridgeTransfer!);
            }
            else if (IsCancelTransfer && cancelTransfer != null)
            {
                return cancelTransfer(CancelTransfer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationNode?>? conversationNode = null,
            global::System.Action<global::G.EndNode?>? end = null,
            global::System.Action<global::G.FunctionNode?>? function = null,
            global::System.Action<global::G.CodeNode?>? code = null,
            global::System.Action<global::G.TransferCallNode?>? transferCall = null,
            global::System.Action<global::G.PressDigitNode?>? pressDigit = null,
            global::System.Action<global::G.BranchNode?>? branch = null,
            global::System.Action<global::G.SmsNode?>? sms = null,
            global::System.Action<global::G.ExtractDynamicVariablesNode?>? extractDynamicVariables = null,
            global::System.Action<global::G.AgentSwapNode?>? agentSwap = null,
            global::System.Action<global::G.MCPNode?>? mcp = null,
            global::System.Action<global::G.ComponentNode?>? component = null,
            global::System.Action<global::G.BridgeTransferNode?>? bridgeTransfer = null,
            global::System.Action<global::G.CancelTransferNode?>? cancelTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationNode)
            {
                conversationNode?.Invoke(ConversationNode!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsTransferCall)
            {
                transferCall?.Invoke(TransferCall!);
            }
            else if (IsPressDigit)
            {
                pressDigit?.Invoke(PressDigit!);
            }
            else if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
            else if (IsExtractDynamicVariables)
            {
                extractDynamicVariables?.Invoke(ExtractDynamicVariables!);
            }
            else if (IsAgentSwap)
            {
                agentSwap?.Invoke(AgentSwap!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsComponent)
            {
                component?.Invoke(Component!);
            }
            else if (IsBridgeTransfer)
            {
                bridgeTransfer?.Invoke(BridgeTransfer!);
            }
            else if (IsCancelTransfer)
            {
                cancelTransfer?.Invoke(CancelTransfer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationNode,
                typeof(global::G.ConversationNode),
                End,
                typeof(global::G.EndNode),
                Function,
                typeof(global::G.FunctionNode),
                Code,
                typeof(global::G.CodeNode),
                TransferCall,
                typeof(global::G.TransferCallNode),
                PressDigit,
                typeof(global::G.PressDigitNode),
                Branch,
                typeof(global::G.BranchNode),
                Sms,
                typeof(global::G.SmsNode),
                ExtractDynamicVariables,
                typeof(global::G.ExtractDynamicVariablesNode),
                AgentSwap,
                typeof(global::G.AgentSwapNode),
                Mcp,
                typeof(global::G.MCPNode),
                Component,
                typeof(global::G.ComponentNode),
                BridgeTransfer,
                typeof(global::G.BridgeTransferNode),
                CancelTransfer,
                typeof(global::G.CancelTransferNode),
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
        public bool Equals(ConversationFlowNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationNode?>.Default.Equals(ConversationNode, other.ConversationNode) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EndNode?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionNode?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeNode?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferCallNode?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PressDigitNode?>.Default.Equals(PressDigit, other.PressDigit) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BranchNode?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsNode?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExtractDynamicVariablesNode?>.Default.Equals(ExtractDynamicVariables, other.ExtractDynamicVariables) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentSwapNode?>.Default.Equals(AgentSwap, other.AgentSwap) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPNode?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComponentNode?>.Default.Equals(Component, other.Component) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BridgeTransferNode?>.Default.Equals(BridgeTransfer, other.BridgeTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CancelTransferNode?>.Default.Equals(CancelTransfer, other.CancelTransfer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationFlowNode obj1, ConversationFlowNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationFlowNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationFlowNode obj1, ConversationFlowNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationFlowNode o && Equals(o);
        }
    }
}
