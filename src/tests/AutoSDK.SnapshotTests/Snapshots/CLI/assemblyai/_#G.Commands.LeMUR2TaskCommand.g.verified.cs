//HintName: G.Commands.LeMUR2TaskCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LeMUR2TaskCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.LemurTaskResponse response,
            global::System.Threading.CancellationToken cancellationToken);




        public LeMUR2TaskCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "task",
            description: @"Use the LeMUR task endpoint to input your own LLM prompt.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.LeMUR2.TaskAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}