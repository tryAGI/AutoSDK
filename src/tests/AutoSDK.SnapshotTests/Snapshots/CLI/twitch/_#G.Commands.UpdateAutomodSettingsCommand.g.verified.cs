//HintName: G.Commands.UpdateAutomodSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateAutomodSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            int? aggression,
            int? bullying,
            int? disability,
            int? misogyny,
            int? overallLevel,
            int? raceEthnicityOrReligion,
            int? sexBasedTerms,
            int? sexualitySexOrGender,
            int? swearing,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateAutoModSettingsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Aggression { get; } = new(
            name: "aggression")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Bullying { get; } = new(
            name: "bullying")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Disability { get; } = new(
            name: "disability")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Misogyny { get; } = new(
            name: "misogyny")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> OverallLevel { get; } = new(
            name: "overallLevel")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> RaceEthnicityOrReligion { get; } = new(
            name: "raceEthnicityOrReligion")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> SexBasedTerms { get; } = new(
            name: "sexBasedTerms")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> SexualitySexOrGender { get; } = new(
            name: "sexualitySexOrGender")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Swearing { get; } = new(
            name: "swearing")
        {
            Description = @"",
        };
        public UpdateAutomodSettingsCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates the broadcaster’s AutoMod settings. The settings are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:automod\_settings** scope.

__Request Body:__

Because PUT is an overwrite operation, you must include all the fields that you want set after the operation completes. Typically, you’ll send a GET request, update the fields you want to change, and pass that object in the PUT request.

You may set either `overall_level` or the individual settings like `aggression`, but not both.

Setting `overall_level` applies default values to the individual settings. However, setting `overall_level` to 4 does not necessarily mean that it applies 4 to all the individual settings. Instead, it applies a set of recommended defaults to the rest of the settings. For example, if you set `overall_level` to 2, Twitch provides some filtering on discrimination and sexual content, but more filtering on hostility (see the first example response).

If `overall_level` is currently set and you update `swearing` to 3, `overall_level` will be set to **null** and all settings other than `swearing` will be set to 0\. The same is true if individual settings are set and you update `overall_level` to 3 — all the individual settings are updated to reflect the default level.

Note that if you set all the individual settings to values that match what `overall_level` would have set them to, Twitch changes AutoMod to use the default AutoMod level instead of using the individual settings.

Valid values for all levels are from 0 (no filtering) through 4 (most aggressive filtering). These levels affect how aggressively AutoMod holds back messages for moderators to review before they appear in chat or are denied (not shown).")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Options.Add(Aggression);
            Options.Add(Bullying);
            Options.Add(Disability);
            Options.Add(Misogyny);
            Options.Add(OverallLevel);
            Options.Add(RaceEthnicityOrReligion);
            Options.Add(SexBasedTerms);
            Options.Add(SexualitySexOrGender);
            Options.Add(Swearing);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var aggression = parseResult.GetRequiredValue(Aggression);
            var bullying = parseResult.GetRequiredValue(Bullying);
            var disability = parseResult.GetRequiredValue(Disability);
            var misogyny = parseResult.GetRequiredValue(Misogyny);
            var overallLevel = parseResult.GetRequiredValue(OverallLevel);
            var raceEthnicityOrReligion = parseResult.GetRequiredValue(RaceEthnicityOrReligion);
            var sexBasedTerms = parseResult.GetRequiredValue(SexBasedTerms);
            var sexualitySexOrGender = parseResult.GetRequiredValue(SexualitySexOrGender);
            var swearing = parseResult.GetRequiredValue(Swearing);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                aggression: aggression,
                bullying: bullying,
                disability: disability,
                misogyny: misogyny,
                overallLevel: overallLevel,
                raceEthnicityOrReligion: raceEthnicityOrReligion,
                sexBasedTerms: sexBasedTerms,
                sexualitySexOrGender: sexualitySexOrGender,
                swearing: swearing,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.UpdateAutomodSettingsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                aggression: aggression,
                bullying: bullying,
                disability: disability,
                misogyny: misogyny,
                overallLevel: overallLevel,
                raceEthnicityOrReligion: raceEthnicityOrReligion,
                sexBasedTerms: sexBasedTerms,
                sexualitySexOrGender: sexualitySexOrGender,
                swearing: swearing,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}