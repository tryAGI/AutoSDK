//HintName: G.Commands.PersonalizedVideoAddContactCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PersonalizedVideoAddContactCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? projectId,
            global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>? variablesList,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>?> VariablesList { get; } = new(
            name: "variablesList")
        {
            Description = @"",
        };
        public PersonalizedVideoAddContactCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "personalized",
            description: @"personalized_video/add_contact")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectId);
            Options.Add(VariablesList);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var variablesList = parseResult.GetRequiredValue(VariablesList);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                variablesList: variablesList,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.PersonalizedVideo.PersonalizedVideoAddContactAsync(
                projectId: projectId,
                variablesList: variablesList,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}