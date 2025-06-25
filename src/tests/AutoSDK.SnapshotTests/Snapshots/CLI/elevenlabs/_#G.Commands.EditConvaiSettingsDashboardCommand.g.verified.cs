//HintName: G.Commands.EditConvaiSettingsDashboardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiSettingsDashboardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::System.Collections.Generic.IList<global::G.ChartsItem2>? charts,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetConvAIDashboardSettingsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChartsItem2>?> Charts { get; } = new(
            name: "charts")
        {
            Description = "",
        };
        public EditConvaiSettingsDashboardCommand(G.IApi client) : base(
            name: "edit",
            description: @"Update Convai dashboard settings for the workspace")
        {
            _client = client;

            Options.Add(XiApiKey);
            Options.Add(Charts);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var charts = parseResult.GetRequiredValue(Charts);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                charts: charts,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiSettingsDashboardAsync(
                xiApiKey: xiApiKey,
                charts: charts,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}