//HintName: G.Commands.GetSharedVoicesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetSharedVoicesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            global::G.GetVoicesV1SharedVoicesGetCategory? category,
            string? gender,
            string? age,
            string? accent,
            string? language,
            string? locale,
            string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            bool? featured,
            int? minNoticePeriodDays,
            bool? includeCustomRates,
            bool? includeLiveModerated,
            bool? readerAppEnabled,
            string? ownerId,
            string? sort,
            int? page,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetLibraryVoicesResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetVoicesV1SharedVoicesGetCategory?> Category { get; } = new(
            name: "category")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Gender { get; } = new(
            name: "gender")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Age { get; } = new(
            name: "age")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Accent { get; } = new(
            name: "accent")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Locale { get; } = new(
            name: "locale")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UseCases { get; } = new(
            name: "useCases")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Descriptives { get; } = new(
            name: "descriptives")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Featured { get; } = new(
            name: "featured")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MinNoticePeriodDays { get; } = new(
            name: "minNoticePeriodDays")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IncludeCustomRates { get; } = new(
            name: "includeCustomRates")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IncludeLiveModerated { get; } = new(
            name: "includeLiveModerated")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ReaderAppEnabled { get; } = new(
            name: "readerAppEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> OwnerId { get; } = new(
            name: "ownerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetSharedVoicesCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieves a list of shared voices.")
        {
            _client = client;

            Options.Add(PageSize);
            Options.Add(Category);
            Options.Add(Gender);
            Options.Add(Age);
            Options.Add(Accent);
            Options.Add(Language);
            Options.Add(Locale);
            Options.Add(Search);
            Options.Add(UseCases);
            Options.Add(Descriptives);
            Options.Add(Featured);
            Options.Add(MinNoticePeriodDays);
            Options.Add(IncludeCustomRates);
            Options.Add(IncludeLiveModerated);
            Options.Add(ReaderAppEnabled);
            Options.Add(OwnerId);
            Options.Add(Sort);
            Options.Add(Page);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var category = parseResult.GetRequiredValue(Category);
            var gender = parseResult.GetRequiredValue(Gender);
            var age = parseResult.GetRequiredValue(Age);
            var accent = parseResult.GetRequiredValue(Accent);
            var language = parseResult.GetRequiredValue(Language);
            var locale = parseResult.GetRequiredValue(Locale);
            var search = parseResult.GetRequiredValue(Search);
            var useCases = parseResult.GetRequiredValue(UseCases);
            var descriptives = parseResult.GetRequiredValue(Descriptives);
            var featured = parseResult.GetRequiredValue(Featured);
            var minNoticePeriodDays = parseResult.GetRequiredValue(MinNoticePeriodDays);
            var includeCustomRates = parseResult.GetRequiredValue(IncludeCustomRates);
            var includeLiveModerated = parseResult.GetRequiredValue(IncludeLiveModerated);
            var readerAppEnabled = parseResult.GetRequiredValue(ReaderAppEnabled);
            var ownerId = parseResult.GetRequiredValue(OwnerId);
            var sort = parseResult.GetRequiredValue(Sort);
            var page = parseResult.GetRequiredValue(Page);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                category: category,
                gender: gender,
                age: age,
                accent: accent,
                language: language,
                locale: locale,
                search: search,
                useCases: useCases,
                descriptives: descriptives,
                featured: featured,
                minNoticePeriodDays: minNoticePeriodDays,
                includeCustomRates: includeCustomRates,
                includeLiveModerated: includeLiveModerated,
                readerAppEnabled: readerAppEnabled,
                ownerId: ownerId,
                sort: sort,
                page: page,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.GetSharedVoicesAsync(
                pageSize: pageSize,
                category: category,
                gender: gender,
                age: age,
                accent: accent,
                language: language,
                locale: locale,
                search: search,
                useCases: useCases,
                descriptives: descriptives,
                featured: featured,
                minNoticePeriodDays: minNoticePeriodDays,
                includeCustomRates: includeCustomRates,
                includeLiveModerated: includeLiveModerated,
                readerAppEnabled: readerAppEnabled,
                ownerId: ownerId,
                sort: sort,
                page: page,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}