//HintName: G.Models.ToolsItem3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem3 : global::System.IEquatable<ToolsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAgentAPIModelOutputToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server<br/>
        /// Example: {"response_timeout_secs":20,"type":"webhook"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookToolConfigOutput? Webhook { get; init; }
#else
        public global::G.WebhookToolConfigOutput? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side<br/>
        /// Example: {"expects_response":false,"type":"client"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientToolConfigOutput? Client { get; init; }
#else
        public global::G.ClientToolConfigOutput? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemToolConfigOutput? System { get; init; }
#else
        public global::G.SystemToolConfigOutput? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// An MCP tool configuration that can be used to call MCP servers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolConfigOutput? Mcp { get; init; }
#else
        public global::G.MCPToolConfigOutput? Mcp { get; }
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
        public global::G.ApiIntegrationWebhookToolConfigOutput? ApiIntegrationWebhook { get; init; }
#else
        public global::G.ApiIntegrationWebhookToolConfigOutput? ApiIntegrationWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiIntegrationWebhook))]
#endif
        public bool IsApiIntegrationWebhook => ApiIntegrationWebhook != null;

        /// <summary>
        /// SMB tool configuration that wraps SMB tool parameters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SMBToolConfig? Smb { get; init; }
#else
        public global::G.SMBToolConfig? Smb { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Smb))]
#endif
        public bool IsSmb => Smb != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.WebhookToolConfigOutput value) => new ToolsItem3((global::G.WebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookToolConfigOutput?(ToolsItem3 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.WebhookToolConfigOutput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.ClientToolConfigOutput value) => new ToolsItem3((global::G.ClientToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientToolConfigOutput?(ToolsItem3 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.ClientToolConfigOutput? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.SystemToolConfigOutput value) => new ToolsItem3((global::G.SystemToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemToolConfigOutput?(ToolsItem3 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.SystemToolConfigOutput? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.MCPToolConfigOutput value) => new ToolsItem3((global::G.MCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolConfigOutput?(ToolsItem3 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.MCPToolConfigOutput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.ApiIntegrationWebhookToolConfigOutput value) => new ToolsItem3((global::G.ApiIntegrationWebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApiIntegrationWebhookToolConfigOutput?(ToolsItem3 @this) => @this.ApiIntegrationWebhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.ApiIntegrationWebhookToolConfigOutput? value)
        {
            ApiIntegrationWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.SMBToolConfig value) => new ToolsItem3((global::G.SMBToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SMBToolConfig?(ToolsItem3 @this) => @this.Smb;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.SMBToolConfig? value)
        {
            Smb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(
            global::G.PromptAgentAPIModelOutputToolDiscriminatorType? type,
            global::G.WebhookToolConfigOutput? webhook,
            global::G.ClientToolConfigOutput? client,
            global::G.SystemToolConfigOutput? system,
            global::G.MCPToolConfigOutput? mcp,
            global::G.ApiIntegrationWebhookToolConfigOutput? apiIntegrationWebhook,
            global::G.SMBToolConfig? smb
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
            Mcp = mcp;
            ApiIntegrationWebhook = apiIntegrationWebhook;
            Smb = smb;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Smb as object ??
            ApiIntegrationWebhook as object ??
            Mcp as object ??
            System as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString() ??
            System?.ToString() ??
            Mcp?.ToString() ??
            ApiIntegrationWebhook?.ToString() ??
            Smb?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem && !IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && IsClient && !IsSystem && !IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && IsSystem && !IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && !IsSystem && IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && !IsSystem && !IsMcp && IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && !IsSystem && !IsMcp && !IsApiIntegrationWebhook && IsSmb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookToolConfigOutput?, TResult>? webhook = null,
            global::System.Func<global::G.ClientToolConfigOutput?, TResult>? client = null,
            global::System.Func<global::G.SystemToolConfigOutput?, TResult>? system = null,
            global::System.Func<global::G.MCPToolConfigOutput?, TResult>? mcp = null,
            global::System.Func<global::G.ApiIntegrationWebhookToolConfigOutput?, TResult>? apiIntegrationWebhook = null,
            global::System.Func<global::G.SMBToolConfig?, TResult>? smb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsClient && client != null)
            {
                return client(Client!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsApiIntegrationWebhook && apiIntegrationWebhook != null)
            {
                return apiIntegrationWebhook(ApiIntegrationWebhook!);
            }
            else if (IsSmb && smb != null)
            {
                return smb(Smb!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookToolConfigOutput?>? webhook = null,
            global::System.Action<global::G.ClientToolConfigOutput?>? client = null,
            global::System.Action<global::G.SystemToolConfigOutput?>? system = null,
            global::System.Action<global::G.MCPToolConfigOutput?>? mcp = null,
            global::System.Action<global::G.ApiIntegrationWebhookToolConfigOutput?>? apiIntegrationWebhook = null,
            global::System.Action<global::G.SMBToolConfig?>? smb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsApiIntegrationWebhook)
            {
                apiIntegrationWebhook?.Invoke(ApiIntegrationWebhook!);
            }
            else if (IsSmb)
            {
                smb?.Invoke(Smb!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::G.WebhookToolConfigOutput),
                Client,
                typeof(global::G.ClientToolConfigOutput),
                System,
                typeof(global::G.SystemToolConfigOutput),
                Mcp,
                typeof(global::G.MCPToolConfigOutput),
                ApiIntegrationWebhook,
                typeof(global::G.ApiIntegrationWebhookToolConfigOutput),
                Smb,
                typeof(global::G.SMBToolConfig),
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
        public bool Equals(ToolsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookToolConfigOutput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClientToolConfigOutput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemToolConfigOutput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolConfigOutput?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApiIntegrationWebhookToolConfigOutput?>.Default.Equals(ApiIntegrationWebhook, other.ApiIntegrationWebhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SMBToolConfig?>.Default.Equals(Smb, other.Smb) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem3 obj1, ToolsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem3 obj1, ToolsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem3 o && Equals(o);
        }
    }
}
