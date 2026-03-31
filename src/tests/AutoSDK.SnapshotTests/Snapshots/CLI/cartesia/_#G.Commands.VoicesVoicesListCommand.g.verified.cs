//HintName: G.Commands.VoicesVoicesListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesVoicesListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoicesListCartesiaVersion cartesiaVersion,
            int? limit,
            string? startingAfter,
            string? endingBefore,
            string? q,
            bool? isOwner,
            global::G.GenderPresentation? gender,
            global::System.Collections.Generic.IList<global::G.VoiceExpandOptions>? expand,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetVoicesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.VoicesListCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The number of Voices to return per page, ranging between 1 and 100.",
        };

        private global::System.CommandLine.Option<string?> StartingAfter { get; } = new(
            name: "startingAfter")
        {
            Description = @"A cursor to use in pagination. `starting_after` is a Voice ID that defines your
place in the list. For example, if you make a /voices request and receive 100
objects, ending with `voice_abc123`, your subsequent call can include
`starting_after=voice_abc123` to fetch the next page of the list.",
        };

        private global::System.CommandLine.Option<string?> EndingBefore { get; } = new(
            name: "endingBefore")
        {
            Description = @"A cursor to use in pagination. `ending_before` is a Voice ID that defines your
place in the list. For example, if you make a /voices request and receive 100
objects, starting with `voice_abc123`, your subsequent call can include
`ending_before=voice_abc123` to fetch the previous page of the list.",
        };

        private global::System.CommandLine.Option<string?> Q { get; } = new(
            name: "q")
        {
            Description = @"Query string to search for voices by name, description, or Voice ID.",
        };

        private global::System.CommandLine.Option<bool?> IsOwner { get; } = new(
            name: "isOwner")
        {
            Description = @"Whether to only return voices owned your organization.",
        };

        private global::System.CommandLine.Option<global::G.GenderPresentation?> Gender { get; } = new(
            name: "gender")
        {
            Description = @"The gender presentation of the voices to return.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.VoiceExpandOptions>?> Expand { get; } = new(
            name: "expand")
        {
            Description = @"Additional fields to include in the response.",
        };


        public VoicesVoicesListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voices",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(Limit);
            Options.Add(StartingAfter);
            Options.Add(EndingBefore);
            Options.Add(Q);
            Options.Add(IsOwner);
            Options.Add(Gender);
            Options.Add(Expand);

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
            var q = parseResult.GetRequiredValue(Q);
            var isOwner = parseResult.GetRequiredValue(IsOwner);
            var gender = parseResult.GetRequiredValue(Gender);
            var expand = parseResult.GetRequiredValue(Expand);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                limit: limit,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                q: q,
                isOwner: isOwner,
                gender: gender,
                expand: expand,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.VoicesListAsync(
                cartesiaVersion: cartesiaVersion,
                limit: limit,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                q: q,
                isOwner: isOwner,
                gender: gender,
                expand: expand,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}