//HintName: G.Commands.CodesOfConductGetAllCodesOfConductCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodesOfConductGetAllCodesOfConductCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CodeOfConduct> response,
            global::System.Threading.CancellationToken cancellationToken);


        public CodesOfConductGetAllCodesOfConductCommand(G.IApi client) : base(
            name: "codes",
            description: @"Returns array of all GitHub's codes of conduct.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodesOfConduct.CodesOfConductGetAllCodesOfConductAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}