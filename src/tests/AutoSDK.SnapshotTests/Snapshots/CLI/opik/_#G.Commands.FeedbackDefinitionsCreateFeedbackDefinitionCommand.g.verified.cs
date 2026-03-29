//HintName: G.Commands.FeedbackDefinitionsCreateFeedbackDefinitionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FeedbackDefinitionsCreateFeedbackDefinitionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"Optional description for the feedback definition",
        };


        public FeedbackDefinitionsCreateFeedbackDefinitionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Get feedback definition")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.FeedbackDefinitions.CreateFeedbackDefinitionAsync(
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}