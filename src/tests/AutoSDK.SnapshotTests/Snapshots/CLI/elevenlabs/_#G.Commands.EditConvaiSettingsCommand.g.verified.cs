//HintName: G.Commands.EditConvaiSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::G.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook,
            global::G.ConvAIWebhooks? webhooks,
            bool? canUseMcpServers,
            int? ragRetentionPeriodDays,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetConvAISettingsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ConversationInitiationClientDataWebhook?> ConversationInitiationClientDataWebhook { get; } = new(
            name: "conversationInitiationClientDataWebhook")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ConvAIWebhooks?> Webhooks { get; } = new(
            name: "webhooks")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> CanUseMcpServers { get; } = new(
            name: "canUseMcpServers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> RagRetentionPeriodDays { get; } = new(
            name: "ragRetentionPeriodDays")
        {
            Description = "",
        };
        public EditConvaiSettingsCommand(G.IApi client) : base(
            name: "edit",
            description: @"Update Convai settings for the workspace")
        {
            _client = client;

            Options.Add(XiApiKey);
            Options.Add(ConversationInitiationClientDataWebhook);
            Options.Add(Webhooks);
            Options.Add(CanUseMcpServers);
            Options.Add(RagRetentionPeriodDays);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var conversationInitiationClientDataWebhook = parseResult.GetRequiredValue(ConversationInitiationClientDataWebhook);
            var webhooks = parseResult.GetRequiredValue(Webhooks);
            var canUseMcpServers = parseResult.GetRequiredValue(CanUseMcpServers);
            var ragRetentionPeriodDays = parseResult.GetRequiredValue(RagRetentionPeriodDays);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                conversationInitiationClientDataWebhook: conversationInitiationClientDataWebhook,
                webhooks: webhooks,
                canUseMcpServers: canUseMcpServers,
                ragRetentionPeriodDays: ragRetentionPeriodDays,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiSettingsAsync(
                xiApiKey: xiApiKey,
                conversationInitiationClientDataWebhook: conversationInitiationClientDataWebhook,
                webhooks: webhooks,
                canUseMcpServers: canUseMcpServers,
                ragRetentionPeriodDays: ragRetentionPeriodDays,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}