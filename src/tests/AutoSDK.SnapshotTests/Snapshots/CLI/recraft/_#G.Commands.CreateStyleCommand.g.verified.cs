//HintName: G.Commands.CreateStyleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateStyleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<byte[]> images,
            global::G.ImageStyle style,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateStyleResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<byte[]>> Images { get; } = new(
            name: "images")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.ImageStyle> Style { get; } = new(
            name: "style")
        {
            Description = @"",
        };

        public CreateStyleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Images);
            Arguments.Add(Style);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var images = parseResult.GetRequiredValue(Images);
            var style = parseResult.GetRequiredValue(Style);

            Validate(
                parseResult: parseResult,
                images: images,
                style: style,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Style.CreateStyleAsync(
                images: images,
                style: style,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}