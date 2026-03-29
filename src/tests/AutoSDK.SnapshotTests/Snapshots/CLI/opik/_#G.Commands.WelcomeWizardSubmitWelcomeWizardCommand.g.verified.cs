//HintName: G.Commands.WelcomeWizardSubmitWelcomeWizardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WelcomeWizardSubmitWelcomeWizardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? role,
            global::System.Collections.Generic.IList<string>? integrations,
            string? email,
            bool? joinBetaProgram,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Role { get; } = new(
            name: "role")
        {
            Description = @"Optional user role",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Integrations { get; } = new(
            name: "integrations")
        {
            Description = @"List of integrations the user selected",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = @"Optional user email",
        };

        private global::System.CommandLine.Option<bool?> JoinBetaProgram { get; } = new(
            name: "joinBetaProgram")
        {
            Description = @"Whether user wants to join beta programs",
        };


        public WelcomeWizardSubmitWelcomeWizardCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "submit",
            description: @"Submit welcome wizard with user information")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Role);
            Options.Add(Integrations);
            Options.Add(Email);
            Options.Add(JoinBetaProgram);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var role = parseResult.GetRequiredValue(Role);
            var integrations = parseResult.GetRequiredValue(Integrations);
            var email = parseResult.GetRequiredValue(Email);
            var joinBetaProgram = parseResult.GetRequiredValue(JoinBetaProgram);

            Validate(
                parseResult: parseResult,
                role: role,
                integrations: integrations,
                email: email,
                joinBetaProgram: joinBetaProgram,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.WelcomeWizard.SubmitWelcomeWizardAsync(
                role: role,
                integrations: integrations,
                email: email,
                joinBetaProgram: joinBetaProgram,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}