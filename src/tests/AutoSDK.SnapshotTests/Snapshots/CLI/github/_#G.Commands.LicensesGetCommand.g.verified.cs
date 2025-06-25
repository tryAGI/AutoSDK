//HintName: G.Commands.LicensesGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LicensesGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string license,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.License response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> License { get; } = new(
            name: "license")
        {
            Description = "",
        };

        public LicensesGetCommand(G.IApi client) : base(
            name: "licenses",
            description: @"Gets information about a specific license. For more information, see ""[Licensing a repository ](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).""")
        {
            _client = client;

            Arguments.Add(License);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var license = parseResult.GetRequiredValue(License);

            Validate(
                parseResult: parseResult,
                license: license,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Licenses.LicensesGetAsync(
                license: license,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}