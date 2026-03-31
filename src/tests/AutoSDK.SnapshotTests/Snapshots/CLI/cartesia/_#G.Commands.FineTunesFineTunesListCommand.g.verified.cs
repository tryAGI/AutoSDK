//HintName: G.Commands.FineTunesFineTunesListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTunesFineTunesListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FineTunesListCartesiaVersion cartesiaVersion,
            int? limit,
            string? startingAfter,
            string? endingBefore,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PaginatedFineTunes response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.FineTunesListCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The number of fine-tunes to return per page, ranging between 1 and 100.",
        };

        private global::System.CommandLine.Option<string?> StartingAfter { get; } = new(
            name: "startingAfter")
        {
            Description = @"A cursor to use in pagination. `starting_after` is a fine-tune ID that defines your
place in the list. For example, if you make a /fine-tunes request and receive 20
objects, ending with `fine_tune_abc123`, your subsequent call can include
`starting_after=fine_tune_abc123` to fetch the next page of the list.",
        };

        private global::System.CommandLine.Option<string?> EndingBefore { get; } = new(
            name: "endingBefore")
        {
            Description = @"A cursor to use in pagination. `ending_before` is a fine-tune ID that defines your
place in the list. For example, if you make a /fine-tunes request and receive 20
objects, starting with `fine_tune_abc123`, your subsequent call can include
`ending_before=fine_tune_abc123` to fetch the previous page of the list.",
        };


        public FineTunesFineTunesListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "fine",
            description: @"Paginated list of all fine-tunes for the authenticated user")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(Limit);
            Options.Add(StartingAfter);
            Options.Add(EndingBefore);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var limit = parseResult.GetRequiredValue(Limit);
            var startingAfter = parseResult.GetRequiredValue(StartingAfter);
            var endingBefore = parseResult.GetRequiredValue(EndingBefore);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                limit: limit,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTunes.FineTunesListAsync(
                cartesiaVersion: cartesiaVersion,
                limit: limit,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}