//HintName: G.Commands.GenerateCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            string prompt,
            string? suffix,
            global::System.Collections.Generic.IList<string>? images,
            string? system,
            string? template,
            global::System.Collections.Generic.IList<long>? context,
            global::G.RequestOptions? options,
            global::G.ResponseFormat? format,
            bool? raw,
            bool? stream,
            int? keepAlive,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Suffix { get; } = new(
            name: "suffix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Images { get; } = new(
            name: "images")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> System { get; } = new(
            name: "system")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Template { get; } = new(
            name: "template")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<long>?> Context { get; } = new(
            name: "context")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RequestOptions?> Options { get; } = new(
            name: "options")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> Format { get; } = new(
            name: "format")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Raw { get; } = new(
            name: "raw")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> KeepAlive { get; } = new(
            name: "keepAlive")
        {
            Description = "",
        };
        public GenerateCompletionCommand(G.IApi client) : base(
            name: "generate",
            description: @"The final response object will include statistics and additional data from the request.")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Prompt);
            Options.Add(Suffix);
            Options.Add(Images);
            Options.Add(System);
            Options.Add(Template);
            Options.Add(Context);
            Options.Add(Options);
            Options.Add(Format);
            Options.Add(Raw);
            Options.Add(Stream);
            Options.Add(KeepAlive);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var suffix = parseResult.GetRequiredValue(Suffix);
            var images = parseResult.GetRequiredValue(Images);
            var system = parseResult.GetRequiredValue(System);
            var template = parseResult.GetRequiredValue(Template);
            var context = parseResult.GetRequiredValue(Context);
            var options = parseResult.GetRequiredValue(Options);
            var format = parseResult.GetRequiredValue(Format);
            var raw = parseResult.GetRequiredValue(Raw);
            var stream = parseResult.GetRequiredValue(Stream);
            var keepAlive = parseResult.GetRequiredValue(KeepAlive);

            Validate(
                parseResult: parseResult,
                model: model,
                prompt: prompt,
                suffix: suffix,
                images: images,
                system: system,
                template: template,
                context: context,
                options: options,
                format: format,
                raw: raw,
                stream: stream,
                keepAlive: keepAlive,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Completions.GenerateCompletionAsync(
                model: model,
                prompt: prompt,
                suffix: suffix,
                images: images,
                system: system,
                template: template,
                context: context,
                options: options,
                format: format,
                raw: raw,
                stream: stream,
                keepAlive: keepAlive,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}