//HintName: G.Models.ToolsItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem2 : global::System.IEquatable<ToolsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAgentInputToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookToolConfigInput? Webhook { get; init; }
#else
        public global::G.WebhookToolConfigInput? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.WebhookToolConfigInput value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookToolConfigInput?(ToolsItem2 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.WebhookToolConfigInput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientToolConfigInput? Client { get; init; }
#else
        public global::G.ClientToolConfigInput? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.ClientToolConfigInput value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientToolConfigInput?(ToolsItem2 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.ClientToolConfigInput? value)
        {
            Client = value;
        }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemToolConfig? System { get; init; }
#else
        public global::G.SystemToolConfig? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.SystemToolConfig value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemToolConfig?(ToolsItem2 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.SystemToolConfig? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(
            global::G.PromptAgentInputToolDiscriminatorType? type,
            global::G.WebhookToolConfigInput? webhook,
            global::G.ClientToolConfigInput? client,
            global::G.SystemToolConfig? system
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            System as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem || !IsWebhook && IsClient && !IsSystem || !IsWebhook && !IsClient && IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookToolConfigInput?, TResult>? webhook = null,
            global::System.Func<global::G.ClientToolConfigInput?, TResult>? client = null,
            global::System.Func<global::G.SystemToolConfig?, TResult>? system = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookToolConfigInput?>? webhook = null,
            global::System.Action<global::G.ClientToolConfigInput?>? client = null,
            global::System.Action<global::G.SystemToolConfig?>? system = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::G.WebhookToolConfigInput),
                Client,
                typeof(global::G.ClientToolConfigInput),
                System,
                typeof(global::G.SystemToolConfig),
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
        public bool Equals(ToolsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookToolConfigInput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClientToolConfigInput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemToolConfig?>.Default.Equals(System, other.System) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem2 obj1, ToolsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem2 obj1, ToolsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem2 o && Equals(o);
        }
    }
}
