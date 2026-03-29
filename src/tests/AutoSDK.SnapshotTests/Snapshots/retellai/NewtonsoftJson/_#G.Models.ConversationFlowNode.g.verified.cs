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
        public global::G.ConversationNode? Value1 { get; init; }
#else
        public global::G.ConversationNode? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EndNode? Value2 { get; init; }
#else
        public global::G.EndNode? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionNode? Value3 { get; init; }
#else
        public global::G.FunctionNode? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeNode? Value4 { get; init; }
#else
        public global::G.CodeNode? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferCallNode? Value5 { get; init; }
#else
        public global::G.TransferCallNode? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PressDigitNode? Value6 { get; init; }
#else
        public global::G.PressDigitNode? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BranchNode? Value7 { get; init; }
#else
        public global::G.BranchNode? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsNode? Value8 { get; init; }
#else
        public global::G.SmsNode? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExtractDynamicVariablesNode? Value9 { get; init; }
#else
        public global::G.ExtractDynamicVariablesNode? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentSwapNode? Value10 { get; init; }
#else
        public global::G.AgentSwapNode? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPNode? Value11 { get; init; }
#else
        public global::G.MCPNode? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComponentNode? Value12 { get; init; }
#else
        public global::G.ComponentNode? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BridgeTransferNode? Value13 { get; init; }
#else
        public global::G.BridgeTransferNode? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CancelTransferNode? Value14 { get; init; }
#else
        public global::G.CancelTransferNode? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.ConversationNode value) => new ConversationFlowNode((global::G.ConversationNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationNode?(ConversationFlowNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.ConversationNode? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.EndNode value) => new ConversationFlowNode((global::G.EndNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndNode?(ConversationFlowNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.EndNode? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.FunctionNode value) => new ConversationFlowNode((global::G.FunctionNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionNode?(ConversationFlowNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.FunctionNode? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.CodeNode value) => new ConversationFlowNode((global::G.CodeNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeNode?(ConversationFlowNode @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.CodeNode? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.TransferCallNode value) => new ConversationFlowNode((global::G.TransferCallNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferCallNode?(ConversationFlowNode @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.TransferCallNode? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.PressDigitNode value) => new ConversationFlowNode((global::G.PressDigitNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PressDigitNode?(ConversationFlowNode @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.PressDigitNode? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.BranchNode value) => new ConversationFlowNode((global::G.BranchNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BranchNode?(ConversationFlowNode @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.BranchNode? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.SmsNode value) => new ConversationFlowNode((global::G.SmsNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsNode?(ConversationFlowNode @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.SmsNode? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.ExtractDynamicVariablesNode value) => new ConversationFlowNode((global::G.ExtractDynamicVariablesNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExtractDynamicVariablesNode?(ConversationFlowNode @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.ExtractDynamicVariablesNode? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.AgentSwapNode value) => new ConversationFlowNode((global::G.AgentSwapNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentSwapNode?(ConversationFlowNode @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.AgentSwapNode? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.MCPNode value) => new ConversationFlowNode((global::G.MCPNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPNode?(ConversationFlowNode @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.MCPNode? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.ComponentNode value) => new ConversationFlowNode((global::G.ComponentNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComponentNode?(ConversationFlowNode @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.ComponentNode? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.BridgeTransferNode value) => new ConversationFlowNode((global::G.BridgeTransferNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BridgeTransferNode?(ConversationFlowNode @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.BridgeTransferNode? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationFlowNode(global::G.CancelTransferNode value) => new ConversationFlowNode((global::G.CancelTransferNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CancelTransferNode?(ConversationFlowNode @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(global::G.CancelTransferNode? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationFlowNode(
            global::G.ConversationNode? value1,
            global::G.EndNode? value2,
            global::G.FunctionNode? value3,
            global::G.CodeNode? value4,
            global::G.TransferCallNode? value5,
            global::G.PressDigitNode? value6,
            global::G.BranchNode? value7,
            global::G.SmsNode? value8,
            global::G.ExtractDynamicVariablesNode? value9,
            global::G.AgentSwapNode? value10,
            global::G.MCPNode? value11,
            global::G.ComponentNode? value12,
            global::G.BridgeTransferNode? value13,
            global::G.CancelTransferNode? value14
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() ??
            Value14?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConversationNode?, TResult>? value1 = null,
            global::System.Func<global::G.EndNode?, TResult>? value2 = null,
            global::System.Func<global::G.FunctionNode?, TResult>? value3 = null,
            global::System.Func<global::G.CodeNode?, TResult>? value4 = null,
            global::System.Func<global::G.TransferCallNode?, TResult>? value5 = null,
            global::System.Func<global::G.PressDigitNode?, TResult>? value6 = null,
            global::System.Func<global::G.BranchNode?, TResult>? value7 = null,
            global::System.Func<global::G.SmsNode?, TResult>? value8 = null,
            global::System.Func<global::G.ExtractDynamicVariablesNode?, TResult>? value9 = null,
            global::System.Func<global::G.AgentSwapNode?, TResult>? value10 = null,
            global::System.Func<global::G.MCPNode?, TResult>? value11 = null,
            global::System.Func<global::G.ComponentNode?, TResult>? value12 = null,
            global::System.Func<global::G.BridgeTransferNode?, TResult>? value13 = null,
            global::System.Func<global::G.CancelTransferNode?, TResult>? value14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationNode?>? value1 = null,
            global::System.Action<global::G.EndNode?>? value2 = null,
            global::System.Action<global::G.FunctionNode?>? value3 = null,
            global::System.Action<global::G.CodeNode?>? value4 = null,
            global::System.Action<global::G.TransferCallNode?>? value5 = null,
            global::System.Action<global::G.PressDigitNode?>? value6 = null,
            global::System.Action<global::G.BranchNode?>? value7 = null,
            global::System.Action<global::G.SmsNode?>? value8 = null,
            global::System.Action<global::G.ExtractDynamicVariablesNode?>? value9 = null,
            global::System.Action<global::G.AgentSwapNode?>? value10 = null,
            global::System.Action<global::G.MCPNode?>? value11 = null,
            global::System.Action<global::G.ComponentNode?>? value12 = null,
            global::System.Action<global::G.BridgeTransferNode?>? value13 = null,
            global::System.Action<global::G.CancelTransferNode?>? value14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.ConversationNode),
                Value2,
                typeof(global::G.EndNode),
                Value3,
                typeof(global::G.FunctionNode),
                Value4,
                typeof(global::G.CodeNode),
                Value5,
                typeof(global::G.TransferCallNode),
                Value6,
                typeof(global::G.PressDigitNode),
                Value7,
                typeof(global::G.BranchNode),
                Value8,
                typeof(global::G.SmsNode),
                Value9,
                typeof(global::G.ExtractDynamicVariablesNode),
                Value10,
                typeof(global::G.AgentSwapNode),
                Value11,
                typeof(global::G.MCPNode),
                Value12,
                typeof(global::G.ComponentNode),
                Value13,
                typeof(global::G.BridgeTransferNode),
                Value14,
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
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationNode?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EndNode?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionNode?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeNode?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferCallNode?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PressDigitNode?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BranchNode?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsNode?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExtractDynamicVariablesNode?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentSwapNode?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPNode?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComponentNode?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BridgeTransferNode?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CancelTransferNode?>.Default.Equals(Value14, other.Value14) 
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
