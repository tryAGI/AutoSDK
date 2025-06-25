//HintName: G.Commands.GetConvaiKnowledgeBaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiKnowledgeBaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? cursor,
            int? pageSize,
            string? search,
            bool? showOnlyOwnedDocuments,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseDocumentType>? types,
            bool? useTypesense,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetKnowledgeBaseListResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
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

        private global::System.CommandLine.Option<bool?> ShowOnlyOwnedDocuments { get; } = new(
            name: "showOnlyOwnedDocuments")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.KnowledgeBaseDocumentType>?> Types { get; } = new(
            name: "types")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> UseTypesense { get; } = new(
            name: "useTypesense")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiKnowledgeBaseCommand(G.IApi client) : base(
            name: "get",
            description: @"Get a list of available knowledge base documents")
        {
            _client = client;

            Options.Add(Cursor);
            Options.Add(PageSize);
            Options.Add(Search);
            Options.Add(ShowOnlyOwnedDocuments);
            Options.Add(Types);
            Options.Add(UseTypesense);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var search = parseResult.GetRequiredValue(Search);
            var showOnlyOwnedDocuments = parseResult.GetRequiredValue(ShowOnlyOwnedDocuments);
            var types = parseResult.GetRequiredValue(Types);
            var useTypesense = parseResult.GetRequiredValue(UseTypesense);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                cursor: cursor,
                pageSize: pageSize,
                search: search,
                showOnlyOwnedDocuments: showOnlyOwnedDocuments,
                types: types,
                useTypesense: useTypesense,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiKnowledgeBaseAsync(
                cursor: cursor,
                pageSize: pageSize,
                search: search,
                showOnlyOwnedDocuments: showOnlyOwnedDocuments,
                types: types,
                useTypesense: useTypesense,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}