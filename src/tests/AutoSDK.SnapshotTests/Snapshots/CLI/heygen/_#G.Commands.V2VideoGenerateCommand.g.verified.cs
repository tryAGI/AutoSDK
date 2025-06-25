//HintName: G.Commands.V2VideoGenerateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V2VideoGenerateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            object? aspectRatio,
            object? callbackId,
            global::G.V2VideoGenerateRequestDimension? dimension,
            bool? test,
            string? title,
            global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? videoInputs,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<object?> AspectRatio { get; } = new(
            name: "aspectRatio")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> CallbackId { get; } = new(
            name: "callbackId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.V2VideoGenerateRequestDimension?> Dimension { get; } = new(
            name: "dimension")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Test { get; } = new(
            name: "test")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>?> VideoInputs { get; } = new(
            name: "videoInputs")
        {
            Description = @"",
        };
        public V2VideoGenerateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "v2video",
            description: @"Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)

<img src=""https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif"" alt="""">")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(AspectRatio);
            Options.Add(CallbackId);
            Options.Add(Dimension);
            Options.Add(Test);
            Options.Add(Title);
            Options.Add(VideoInputs);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var aspectRatio = parseResult.GetRequiredValue(AspectRatio);
            var callbackId = parseResult.GetRequiredValue(CallbackId);
            var dimension = parseResult.GetRequiredValue(Dimension);
            var test = parseResult.GetRequiredValue(Test);
            var title = parseResult.GetRequiredValue(Title);
            var videoInputs = parseResult.GetRequiredValue(VideoInputs);

            Validate(
                parseResult: parseResult,
                aspectRatio: aspectRatio,
                callbackId: callbackId,
                dimension: dimension,
                test: test,
                title: title,
                videoInputs: videoInputs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CreateVideoAPI.V2VideoGenerateAsync(
                aspectRatio: aspectRatio,
                callbackId: callbackId,
                dimension: dimension,
                test: test,
                title: title,
                videoInputs: videoInputs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}