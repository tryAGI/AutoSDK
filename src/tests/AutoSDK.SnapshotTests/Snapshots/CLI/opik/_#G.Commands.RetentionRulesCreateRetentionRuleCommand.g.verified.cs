//HintName: G.Commands.RetentionRulesCreateRetentionRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetentionRulesCreateRetentionRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            bool organizationLevel,
            global::G.RetentionRuleWriteRetention retention,
            bool? applyToPast,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RetentionRulePublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<bool> OrganizationLevel { get; } = new(
            name: "organizationLevel")
        {
            Description = @"Set to true to create an organization-level rule",
        };

        private global::System.CommandLine.Argument<global::G.RetentionRuleWriteRetention> Retention { get; } = new(
            name: "retention")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ApplyToPast { get; } = new(
            name: "applyToPast")
        {
            Description = @"",
        };


        public RetentionRulesCreateRetentionRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new retention rule. Auto-deactivates any existing active rule for the same scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(OrganizationLevel);
            Arguments.Add(Retention);
            Options.Add(ProjectId);
            Options.Add(ApplyToPast);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var organizationLevel = parseResult.GetRequiredValue(OrganizationLevel);
            var retention = parseResult.GetRequiredValue(Retention);
            var applyToPast = parseResult.GetRequiredValue(ApplyToPast);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                organizationLevel: organizationLevel,
                retention: retention,
                applyToPast: applyToPast,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RetentionRules.CreateRetentionRuleAsync(
                projectId: projectId,
                organizationLevel: organizationLevel,
                retention: retention,
                applyToPast: applyToPast,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}