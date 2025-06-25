//HintName: G.Commands.AccountUpdateDetailsV1MePatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AccountUpdateDetailsV1MePatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string? name,
            string? email,
            bool? isBusinessAccount,
            string? company,
            string? website,
            string? displayName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Personal name",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsBusinessAccount { get; } = new(
            name: "isBusinessAccount")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Company { get; } = new(
            name: "company")
        {
            Description = @"Company name",
        };

        private global::System.CommandLine.Option<string?> Website { get; } = new(
            name: "website")
        {
            Description = @"Company website address",
        };

        private global::System.CommandLine.Option<string?> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = @"String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.",
        };
        public AccountUpdateDetailsV1MePatchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "account",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(XiApiKey);
            Options.Add(Name);
            Options.Add(Email);
            Options.Add(IsBusinessAccount);
            Options.Add(Company);
            Options.Add(Website);
            Options.Add(DisplayName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var email = parseResult.GetRequiredValue(Email);
            var isBusinessAccount = parseResult.GetRequiredValue(IsBusinessAccount);
            var company = parseResult.GetRequiredValue(Company);
            var website = parseResult.GetRequiredValue(Website);
            var displayName = parseResult.GetRequiredValue(DisplayName);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                email: email,
                isBusinessAccount: isBusinessAccount,
                company: company,
                website: website,
                displayName: displayName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AccountUpdateDetailsV1MePatchAsync(
                xiApiKey: xiApiKey,
                name: name,
                email: email,
                isBusinessAccount: isBusinessAccount,
                company: company,
                website: website,
                displayName: displayName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}