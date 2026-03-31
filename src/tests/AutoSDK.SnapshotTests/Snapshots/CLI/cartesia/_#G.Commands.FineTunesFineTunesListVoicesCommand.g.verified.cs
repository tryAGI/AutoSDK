//HintName: G.Commands.FineTunesFineTunesListVoicesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTunesFineTunesListVoicesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FineTunesListVoicesCartesiaVersion cartesiaVersion,
            string id,
            int? limit,
            string? startingAfter,
            string? endingBefore,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PaginatedVoices response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.FineTunesListVoicesCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"ID of the fine-tune to list voices from",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The number of voices to return per page, ranging between 1 and 100.",
        };

        private global::System.CommandLine.Option<string?> StartingAfter { get; } = new(
            name: "startingAfter")
        {
            Description = @"A cursor to use in pagination. `starting_after` is a voice ID that defines your
place in the list. For example, if you make a fine-tune voices request and receive 20
objects, ending with `voice_abc123`, your subsequent call can include
`starting_after=voice_abc123` to fetch the next page of the list.",
        };

        private global::System.CommandLine.Option<string?> EndingBefore { get; } = new(
            name: "endingBefore")
        {
            Description = @"A cursor to use in pagination. `ending_before` is a voice ID that defines your
place in the list. For example, if you make a fine-tune voices request and receive 20
objects, starting with `voice_abc123`, your subsequent call can include
`ending_before=voice_abc123` to fetch the previous page of the list.",
        };


        public FineTunesFineTunesListVoicesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "fine",
            description: @"List all voices created from a fine-tune")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Id);
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
            var id = parseResult.GetRequiredValue(Id);
            var limit = parseResult.GetRequiredValue(Limit);
            var startingAfter = parseResult.GetRequiredValue(StartingAfter);
            var endingBefore = parseResult.GetRequiredValue(EndingBefore);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                id: id,
                limit: limit,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTunes.FineTunesListVoicesAsync(
                cartesiaVersion: cartesiaVersion,
                id: id,
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