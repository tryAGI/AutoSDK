//HintName: G.Commands.GetV2VoicesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetV2VoicesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? nextPageToken,
            int? pageSize,
            string? search,
            string? sort,
            string? sortDirection,
            string? voiceType,
            string? category,
            string? fineTuningState,
            string? collectionId,
            bool? includeTotalCount,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetVoicesV2ResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> NextPageToken { get; } = new(
            name: "nextPageToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SortDirection { get; } = new(
            name: "sortDirection")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VoiceType { get; } = new(
            name: "voiceType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Category { get; } = new(
            name: "category")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FineTuningState { get; } = new(
            name: "fineTuningState")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CollectionId { get; } = new(
            name: "collectionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IncludeTotalCount { get; } = new(
            name: "includeTotalCount")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetV2VoicesCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets a list of all available voices for a user with search, filtering and pagination.")
        {
            _client = client;

            Options.Add(NextPageToken);
            Options.Add(PageSize);
            Options.Add(Search);
            Options.Add(Sort);
            Options.Add(SortDirection);
            Options.Add(VoiceType);
            Options.Add(Category);
            Options.Add(FineTuningState);
            Options.Add(CollectionId);
            Options.Add(IncludeTotalCount);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var nextPageToken = parseResult.GetRequiredValue(NextPageToken);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var search = parseResult.GetRequiredValue(Search);
            var sort = parseResult.GetRequiredValue(Sort);
            var sortDirection = parseResult.GetRequiredValue(SortDirection);
            var voiceType = parseResult.GetRequiredValue(VoiceType);
            var category = parseResult.GetRequiredValue(Category);
            var fineTuningState = parseResult.GetRequiredValue(FineTuningState);
            var collectionId = parseResult.GetRequiredValue(CollectionId);
            var includeTotalCount = parseResult.GetRequiredValue(IncludeTotalCount);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                nextPageToken: nextPageToken,
                pageSize: pageSize,
                search: search,
                sort: sort,
                sortDirection: sortDirection,
                voiceType: voiceType,
                category: category,
                fineTuningState: fineTuningState,
                collectionId: collectionId,
                includeTotalCount: includeTotalCount,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.GetV2VoicesAsync(
                nextPageToken: nextPageToken,
                pageSize: pageSize,
                search: search,
                sort: sort,
                sortDirection: sortDirection,
                voiceType: voiceType,
                category: category,
                fineTuningState: fineTuningState,
                collectionId: collectionId,
                includeTotalCount: includeTotalCount,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}