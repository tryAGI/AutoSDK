//HintName: G.ModerationClient.UpdateAutomodSettings.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Updates the broadcaster’s AutoMod settings.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateAutoModSettingsResponse> UpdateAutomodSettingsAsync(
            string broadcasterId,
            string moderatorId,
            UpdateAutoModSettingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/automod/settings?broadcaster_id={broadcasterId}&moderator_id={moderatorId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateAutoModSettingsResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Updates the broadcaster’s AutoMod settings.
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
        public async global::System.Threading.Tasks.Task<UpdateAutoModSettingsResponse> UpdateAutomodSettingsAsync(
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
            var request = new UpdateAutoModSettingsBody
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