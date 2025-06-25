//HintName: G.Commands.AccountsMeUsageCallsRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AccountsMeUsageCallsRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? durationMax,
            string? durationMin,
            global::System.DateTime? fromDate,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? search,
            global::System.DateTime? toDate,
            global::System.Guid? voiceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CallUsage response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> DurationMax { get; } = new(
            name: "durationMax")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DurationMin { get; } = new(
            name: "durationMin")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromDate { get; } = new(
            name: "fromDate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToDate { get; } = new(
            name: "toDate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Guid?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };
        public AccountsMeUsageCallsRetrieveCommand(G.IApi client) : base(
            name: "accounts",
            description: @"Gets aggregated call usage.")
        {
            _client = client;

            Options.Add(DurationMax);
            Options.Add(DurationMin);
            Options.Add(FromDate);
            Options.Add(Metadata);
            Options.Add(Search);
            Options.Add(ToDate);
            Options.Add(VoiceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var durationMax = parseResult.GetRequiredValue(DurationMax);
            var durationMin = parseResult.GetRequiredValue(DurationMin);
            var fromDate = parseResult.GetRequiredValue(FromDate);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var search = parseResult.GetRequiredValue(Search);
            var toDate = parseResult.GetRequiredValue(ToDate);
            var voiceId = parseResult.GetRequiredValue(VoiceId);

            Validate(
                parseResult: parseResult,
                durationMax: durationMax,
                durationMin: durationMin,
                fromDate: fromDate,
                metadata: metadata,
                search: search,
                toDate: toDate,
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Accounts.AccountsMeUsageCallsRetrieveAsync(
                durationMax: durationMax,
                durationMin: durationMin,
                fromDate: fromDate,
                metadata: metadata,
                search: search,
                toDate: toDate,
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}