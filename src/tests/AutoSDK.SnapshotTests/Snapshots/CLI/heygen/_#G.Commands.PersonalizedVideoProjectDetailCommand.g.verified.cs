//HintName: G.Commands.PersonalizedVideoProjectDetailCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PersonalizedVideoProjectDetailCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };
        public PersonalizedVideoProjectDetailCommand(G.IApi client) : base(
            name: "personalized",
            description: @"personalized_video/project/detail")
        {
            _client = client;

            Options.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.PersonalizedVideo.PersonalizedVideoProjectDetailAsync(
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}