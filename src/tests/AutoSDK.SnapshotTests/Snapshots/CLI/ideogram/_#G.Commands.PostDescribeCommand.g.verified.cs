//HintName: G.Commands.PostDescribeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PostDescribeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DescribeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> ImageFile { get; } = new(
            name: "imageFile")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ImageFilename { get; } = new(
            name: "imageFilename")
        {
            Description = @"",
        };

        public PostDescribeCommand(G.IApi client) : base(
            name: "post",
            description: @"")
        {
            _client = client;

            Arguments.Add(ImageFile);
            Arguments.Add(ImageFilename);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var imageFile = parseResult.GetRequiredValue(ImageFile);
            var imageFilename = parseResult.GetRequiredValue(ImageFilename);

            Validate(
                parseResult: parseResult,
                imageFile: imageFile,
                imageFilename: imageFilename,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Vision.PostDescribeAsync(
                imageFile: imageFile,
                imageFilename: imageFilename,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}