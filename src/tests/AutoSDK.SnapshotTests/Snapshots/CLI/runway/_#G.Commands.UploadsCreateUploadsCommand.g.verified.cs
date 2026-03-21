//HintName: G.Commands.UploadsCreateUploadsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UploadsCreateUploadsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string xRunwayVersion,
            string filename,
            global::G.CreateUploadsRequestType type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateUploadsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).",
        };

        private global::System.CommandLine.Option<global::G.CreateUploadsRequestType> Type { get; } = new(
            name: "type")
        {
            Description = @"The type of upload to create",
        };


        public UploadsCreateUploadsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Uploads a temporary media file that can be referenced in API generation requests. The uploaded files will be automatically expired and deleted after a period of time. It is strongly recommended to use our SDKs for this which have a simplified interface that directly accepts file objects.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(XRunwayVersion);
            Arguments.Add(Filename);
            Options.Add(Type);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
            var filename = parseResult.GetRequiredValue(Filename);
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                xRunwayVersion: xRunwayVersion,
                filename: filename,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Uploads.CreateUploadsAsync(
                xRunwayVersion: xRunwayVersion,
                filename: filename,
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}