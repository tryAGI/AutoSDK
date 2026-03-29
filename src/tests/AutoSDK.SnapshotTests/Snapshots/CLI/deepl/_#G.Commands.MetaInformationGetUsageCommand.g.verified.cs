//HintName: G.Commands.MetaInformationGetUsageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaInformationGetUsageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.UsageResponse response,
            global::System.Threading.CancellationToken cancellationToken);




        public MetaInformationGetUsageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve usage information within the current billing period together with the corresponding account limits. Usage is returned for:
- translated characters
- translated documents
- translated documents, team totals (for team accounts only)

Character usage includes both text and document translations, and is measured by the source text length in Unicode code points,
so for example ""A"", ""Δ"", ""あ"", and ""深"" are each counted as a single character.

Document usage only includes document translations, and is measured in individual documents.

Depending on the user account type, some usage types will be omitted.
Character usage is only included for developer accounts.
Document usage is only included for non-developer accounts, and team-combined document usage is only included for non-developer team accounts.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


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
            var response = await _client.MetaInformation.GetUsageAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}