//HintName: G.Models.ToolsItem4.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem4 : global::System.IEquatable<ToolsItem4>
    {
        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server<br/>
        /// Example: {"response_timeout_secs":20,"type":"webhook"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookToolConfigInput? WebhookToolConfigInput { get; init; }
#else
        public global::G.WebhookToolConfigInput? WebhookToolConfigInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookToolConfigInput))]
#endif
        public bool IsWebhookToolConfigInput => WebhookToolConfigInput != null;

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side<br/>
        /// Example: {"expects_response":false,"type":"client"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientToolConfigInput? ClientToolConfigInput { get; init; }
#else
        public global::G.ClientToolConfigInput? ClientToolConfigInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolConfigInput))]
#endif
        public bool IsClientToolConfigInput => ClientToolConfigInput != null;

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server<br/>
        /// Example: {"type":"system"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemToolConfigInput? SystemToolConfigInput { get; init; }
#else
        public global::G.SystemToolConfigInput? SystemToolConfigInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemToolConfigInput))]
#endif
        public bool IsSystemToolConfigInput => SystemToolConfigInput != null;

        /// <summary>
        /// An MCP tool configuration that can be used to call MCP servers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolConfigInput? MCPToolConfigInput { get; init; }
#else
        public global::G.MCPToolConfigInput? MCPToolConfigInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPToolConfigInput))]
#endif
        public bool IsMCPToolConfigInput => MCPToolConfigInput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::G.WebhookToolConfigInput value) => new ToolsItem4((global::G.WebhookToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookToolConfigInput?(ToolsItem4 @this) => @this.WebhookToolConfigInput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::G.WebhookToolConfigInput? value)
        {
            WebhookToolConfigInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::G.ClientToolConfigInput value) => new ToolsItem4((global::G.ClientToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientToolConfigInput?(ToolsItem4 @this) => @this.ClientToolConfigInput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::G.ClientToolConfigInput? value)
        {
            ClientToolConfigInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::G.SystemToolConfigInput value) => new ToolsItem4((global::G.SystemToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemToolConfigInput?(ToolsItem4 @this) => @this.SystemToolConfigInput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::G.SystemToolConfigInput? value)
        {
            SystemToolConfigInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::G.MCPToolConfigInput value) => new ToolsItem4((global::G.MCPToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolConfigInput?(ToolsItem4 @this) => @this.MCPToolConfigInput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::G.MCPToolConfigInput? value)
        {
            MCPToolConfigInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(
            global::G.WebhookToolConfigInput? webhookToolConfigInput,
            global::G.ClientToolConfigInput? clientToolConfigInput,
            global::G.SystemToolConfigInput? systemToolConfigInput,
            global::G.MCPToolConfigInput? mCPToolConfigInput
            )
        {
            WebhookToolConfigInput = webhookToolConfigInput;
            ClientToolConfigInput = clientToolConfigInput;
            SystemToolConfigInput = systemToolConfigInput;
            MCPToolConfigInput = mCPToolConfigInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPToolConfigInput as object ??
            SystemToolConfigInput as object ??
            ClientToolConfigInput as object ??
            WebhookToolConfigInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebhookToolConfigInput?.ToString() ??
            ClientToolConfigInput?.ToString() ??
            SystemToolConfigInput?.ToString() ??
            MCPToolConfigInput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhookToolConfigInput && !IsClientToolConfigInput && !IsSystemToolConfigInput && !IsMCPToolConfigInput || !IsWebhookToolConfigInput && IsClientToolConfigInput && !IsSystemToolConfigInput && !IsMCPToolConfigInput || !IsWebhookToolConfigInput && !IsClientToolConfigInput && IsSystemToolConfigInput && !IsMCPToolConfigInput || !IsWebhookToolConfigInput && !IsClientToolConfigInput && !IsSystemToolConfigInput && IsMCPToolConfigInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookToolConfigInput?, TResult>? webhookToolConfigInput = null,
            global::System.Func<global::G.ClientToolConfigInput?, TResult>? clientToolConfigInput = null,
            global::System.Func<global::G.SystemToolConfigInput?, TResult>? systemToolConfigInput = null,
            global::System.Func<global::G.MCPToolConfigInput?, TResult>? mCPToolConfigInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfigInput && webhookToolConfigInput != null)
            {
                return webhookToolConfigInput(WebhookToolConfigInput!);
            }
            else if (IsClientToolConfigInput && clientToolConfigInput != null)
            {
                return clientToolConfigInput(ClientToolConfigInput!);
            }
            else if (IsSystemToolConfigInput && systemToolConfigInput != null)
            {
                return systemToolConfigInput(SystemToolConfigInput!);
            }
            else if (IsMCPToolConfigInput && mCPToolConfigInput != null)
            {
                return mCPToolConfigInput(MCPToolConfigInput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookToolConfigInput?>? webhookToolConfigInput = null,
            global::System.Action<global::G.ClientToolConfigInput?>? clientToolConfigInput = null,
            global::System.Action<global::G.SystemToolConfigInput?>? systemToolConfigInput = null,
            global::System.Action<global::G.MCPToolConfigInput?>? mCPToolConfigInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfigInput)
            {
                webhookToolConfigInput?.Invoke(WebhookToolConfigInput!);
            }
            else if (IsClientToolConfigInput)
            {
                clientToolConfigInput?.Invoke(ClientToolConfigInput!);
            }
            else if (IsSystemToolConfigInput)
            {
                systemToolConfigInput?.Invoke(SystemToolConfigInput!);
            }
            else if (IsMCPToolConfigInput)
            {
                mCPToolConfigInput?.Invoke(MCPToolConfigInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookToolConfigInput,
                typeof(global::G.WebhookToolConfigInput),
                ClientToolConfigInput,
                typeof(global::G.ClientToolConfigInput),
                SystemToolConfigInput,
                typeof(global::G.SystemToolConfigInput),
                MCPToolConfigInput,
                typeof(global::G.MCPToolConfigInput),
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
        public bool Equals(ToolsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookToolConfigInput?>.Default.Equals(WebhookToolConfigInput, other.WebhookToolConfigInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClientToolConfigInput?>.Default.Equals(ClientToolConfigInput, other.ClientToolConfigInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemToolConfigInput?>.Default.Equals(SystemToolConfigInput, other.SystemToolConfigInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolConfigInput?>.Default.Equals(MCPToolConfigInput, other.MCPToolConfigInput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem4 o && Equals(o);
        }
    }
}
