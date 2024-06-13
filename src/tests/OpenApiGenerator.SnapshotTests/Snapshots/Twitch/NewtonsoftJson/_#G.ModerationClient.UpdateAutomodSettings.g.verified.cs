//HintName: G.ModerationClient.UpdateAutomodSettings.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Updates the broadcaster’s AutoMod settings.<br/>
        /// Updates the broadcaster’s AutoMod settings. The settings are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:automod\_settings** scope.<br/>
        /// __Request Body:__<br/>
        /// Because PUT is an overwrite operation, you must include all the fields that you want set after the operation completes. Typically, you’ll send a GET request, update the fields you want to change, and pass that object in the PUT request.<br/>
        /// You may set either `overall_level` or the individual settings like `aggression`, but not both.<br/>
        /// Setting `overall_level` applies default values to the individual settings. However, setting `overall_level` to 4 does not necessarily mean that it applies 4 to all the individual settings. Instead, it applies a set of recommended defaults to the rest of the settings. For example, if you set `overall_level` to 2, Twitch provides some filtering on discrimination and sexual content, but more filtering on hostility (see the first example response).<br/>
        /// If `overall_level` is currently set and you update `swearing` to 3, `overall_level` will be set to **null** and all settings other than `swearing` will be set to 0\. The same is true if individual settings are set and you update `overall_level` to 3 — all the individual settings are updated to reflect the default level.<br/>
        /// Note that if you set all the individual settings to values that match what `overall_level` would have set them to, Twitch changes AutoMod to use the default AutoMod level instead of using the individual settings.<br/>
        /// Valid values for all levels are from 0 (no filtering) through 4 (most aggressive filtering). These levels affect how aggressively AutoMod holds back messages for moderators to review before they appear in chat or are denied (not shown).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateAutoModSettingsResponse> UpdateAutomodSettingsAsync(
            string broadcasterId,
            string moderatorId,
            global::G.UpdateAutoModSettingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/automod/settings?broadcaster_id={broadcasterId}&moderator_id={moderatorId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateAutoModSettingsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates the broadcaster’s AutoMod settings.<br/>
        /// Updates the broadcaster’s AutoMod settings. The settings are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:automod\_settings** scope.<br/>
        /// __Request Body:__<br/>
        /// Because PUT is an overwrite operation, you must include all the fields that you want set after the operation completes. Typically, you’ll send a GET request, update the fields you want to change, and pass that object in the PUT request.<br/>
        /// You may set either `overall_level` or the individual settings like `aggression`, but not both.<br/>
        /// Setting `overall_level` applies default values to the individual settings. However, setting `overall_level` to 4 does not necessarily mean that it applies 4 to all the individual settings. Instead, it applies a set of recommended defaults to the rest of the settings. For example, if you set `overall_level` to 2, Twitch provides some filtering on discrimination and sexual content, but more filtering on hostility (see the first example response).<br/>
        /// If `overall_level` is currently set and you update `swearing` to 3, `overall_level` will be set to **null** and all settings other than `swearing` will be set to 0\. The same is true if individual settings are set and you update `overall_level` to 3 — all the individual settings are updated to reflect the default level.<br/>
        /// Note that if you set all the individual settings to values that match what `overall_level` would have set them to, Twitch changes AutoMod to use the default AutoMod level instead of using the individual settings.<br/>
        /// Valid values for all levels are from 0 (no filtering) through 4 (most aggressive filtering). These levels affect how aggressively AutoMod holds back messages for moderators to review before they appear in chat or are denied (not shown).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="aggression"></param>
        /// <param name="bullying"></param>
        /// <param name="disability"></param>
        /// <param name="misogyny"></param>
        /// <param name="overallLevel"></param>
        /// <param name="raceEthnicityOrReligion"></param>
        /// <param name="sexBasedTerms"></param>
        /// <param name="sexualitySexOrGender"></param>
        /// <param name="swearing"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateAutoModSettingsResponse> UpdateAutomodSettingsAsync(
            string broadcasterId,
            string moderatorId,
            int aggression = default,
            int bullying = default,
            int disability = default,
            int misogyny = default,
            int overallLevel = default,
            int raceEthnicityOrReligion = default,
            int sexBasedTerms = default,
            int sexualitySexOrGender = default,
            int swearing = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateAutoModSettingsBody
            {
                Aggression = aggression,
                Bullying = bullying,
                Disability = disability,
                Misogyny = misogyny,
                OverallLevel = overallLevel,
                RaceEthnicityOrReligion = raceEthnicityOrReligion,
                SexBasedTerms = sexBasedTerms,
                SexualitySexOrGender = sexualitySexOrGender,
                Swearing = swearing,
            };

            return await UpdateAutomodSettingsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}