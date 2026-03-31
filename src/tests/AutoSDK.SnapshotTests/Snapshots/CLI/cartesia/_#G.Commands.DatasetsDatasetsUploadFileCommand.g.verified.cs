//HintName: G.Commands.DatasetsDatasetsUploadFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsDatasetsUploadFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DatasetsUploadFileCartesiaVersion cartesiaVersion,
            string id,
            byte[]? file,
            string? filename,
            string? purpose,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.DatasetsUploadFileCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"ID of the dataset to upload to",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Purpose { get; } = new(
            name: "purpose")
        {
            Description = @"Purpose of the file (e.g., fine_tune)",
        };


        public DatasetsDatasetsUploadFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "datasets",
            description: @"Upload a new file to a dataset")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Id);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(Purpose);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var id = parseResult.GetRequiredValue(Id);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var purpose = parseResult.GetRequiredValue(Purpose);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                id: id,
                file: file,
                filename: filename,
                purpose: purpose,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.DatasetsUploadFileAsync(
                cartesiaVersion: cartesiaVersion,
                id: id,
                file: file,
                filename: filename,
                purpose: purpose,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}