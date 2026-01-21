//HintName: G.Models.ToolDetailsVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolDetailsVariant1 : global::System.IEquatable<ToolDetailsVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTranscriptToolCallWebhookDetails? Webhook { get; init; }
#else
        public global::G.ConversationHistoryTranscriptToolCallWebhookDetails? Webhook { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTranscriptToolCallClientDetails? Client { get; init; }
#else
        public global::G.ConversationHistoryTranscriptToolCallClientDetails? Client { get; }
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
        public static implicit operator ToolDetailsVariant1(global::G.ConversationHistoryTranscriptToolCallWebhookDetails value) => new ToolDetailsVariant1((global::G.ConversationHistoryTranscriptToolCallWebhookDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTranscriptToolCallWebhookDetails?(ToolDetailsVariant1 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant1(global::G.ConversationHistoryTranscriptToolCallWebhookDetails? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetailsVariant1(global::G.ConversationHistoryTranscriptToolCallClientDetails value) => new ToolDetailsVariant1((global::G.ConversationHistoryTranscriptToolCallClientDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTranscriptToolCallClientDetails?(ToolDetailsVariant1 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant1(global::G.ConversationHistoryTranscriptToolCallClientDetails? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant1(
            global::G.ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorType? type,
            global::G.ConversationHistoryTranscriptToolCallWebhookDetails? webhook,
            global::G.ConversationHistoryTranscriptToolCallClientDetails? client
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient || !IsWebhook && IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?, TResult>? webhook = null,
            global::System.Func<global::G.ConversationHistoryTranscriptToolCallClientDetails?, TResult>? client = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?>? webhook = null,
            global::System.Action<global::G.ConversationHistoryTranscriptToolCallClientDetails?>? client = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails),
                Client,
                typeof(global::G.ConversationHistoryTranscriptToolCallClientDetails),
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
        public bool Equals(ToolDetailsVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTranscriptToolCallClientDetails?>.Default.Equals(Client, other.Client) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolDetailsVariant1 obj1, ToolDetailsVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolDetailsVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolDetailsVariant1 obj1, ToolDetailsVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolDetailsVariant1 o && Equals(o);
        }
    }
}
