//HintName: G.Commands.UpdateFinetunedModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateFinetunedModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            string? xClientName,
            string name,
            global::G.Settings settings,
            global::G.Status? status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateFinetunedModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.Settings> Settings { get; } = new(
            name: "settings")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.Status?> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };
        public UpdateFinetunedModelCommand(G.IApi client) : base(
            name: "update",
            description: @"")
        {
            _client = client;

            Arguments.Add(Id);
            Arguments.Add(Name);
            Arguments.Add(Settings);
            Options.Add(XClientName);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var name = parseResult.GetRequiredValue(Name);
            var settings = parseResult.GetRequiredValue(Settings);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                id: id,
                xClientName: xClientName,
                name: name,
                settings: settings,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Finetuning.UpdateFinetunedModelAsync(
                id: id,
                xClientName: xClientName,
                name: name,
                settings: settings,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}