//HintName: G.Commands.DeepstartApplyPaymentDeepstartApplicationPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeepstartApplyPaymentDeepstartApplicationPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? session,
            string? id,
            string? uid,
            string company,
            string ceo,
            string funding,
            string foundedOn,
            string website,
            int? createdAt,
            string? status,
            string? deal,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeepStartApplicationOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Company { get; } = new(
            name: "company")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Ceo { get; } = new(
            name: "ceo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Funding { get; } = new(
            name: "funding")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> FoundedOn { get; } = new(
            name: "foundedOn")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Website { get; } = new(
            name: "website")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Session { get; } = new(
            name: "session")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Uid { get; } = new(
            name: "uid")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> CreatedAt { get; } = new(
            name: "createdAt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Deal { get; } = new(
            name: "deal")
        {
            Description = @"",
        };
        public DeepstartApplyPaymentDeepstartApplicationPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deepstart",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Company);
            Arguments.Add(Ceo);
            Arguments.Add(Funding);
            Arguments.Add(FoundedOn);
            Arguments.Add(Website);
            Options.Add(Session);
            Options.Add(Id);
            Options.Add(Uid);
            Options.Add(CreatedAt);
            Options.Add(Status);
            Options.Add(Deal);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var session = parseResult.GetRequiredValue(Session);
            var id = parseResult.GetRequiredValue(Id);
            var uid = parseResult.GetRequiredValue(Uid);
            var company = parseResult.GetRequiredValue(Company);
            var ceo = parseResult.GetRequiredValue(Ceo);
            var funding = parseResult.GetRequiredValue(Funding);
            var foundedOn = parseResult.GetRequiredValue(FoundedOn);
            var website = parseResult.GetRequiredValue(Website);
            var createdAt = parseResult.GetRequiredValue(CreatedAt);
            var status = parseResult.GetRequiredValue(Status);
            var deal = parseResult.GetRequiredValue(Deal);

            Validate(
                parseResult: parseResult,
                session: session,
                id: id,
                uid: uid,
                company: company,
                ceo: ceo,
                funding: funding,
                foundedOn: foundedOn,
                website: website,
                createdAt: createdAt,
                status: status,
                deal: deal,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeepstartApplyPaymentDeepstartApplicationPostAsync(
                session: session,
                id: id,
                uid: uid,
                company: company,
                ceo: ceo,
                funding: funding,
                foundedOn: foundedOn,
                website: website,
                createdAt: createdAt,
                status: status,
                deal: deal,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}