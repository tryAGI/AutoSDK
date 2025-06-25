//HintName: G.Commands.ShowPetByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ShowPetByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string petId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Pet response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PetId { get; } = new(
            name: "petId")
        {
            Description = "",
        };

        public ShowPetByIdCommand(G.IApi client) : base(
            name: "show",
            description: @"")
        {
            _client = client;

            Arguments.Add(PetId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var petId = parseResult.GetRequiredValue(PetId);

            Validate(
                parseResult: parseResult,
                petId: petId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pets.ShowPetByIdAsync(
                petId: petId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}