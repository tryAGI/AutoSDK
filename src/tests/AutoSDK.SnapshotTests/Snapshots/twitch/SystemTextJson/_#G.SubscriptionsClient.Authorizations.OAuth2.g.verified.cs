//HintName: G.SubscriptionsClient.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    using OAuth2DeviceAuthorizationResponse = global::G.Api.OAuth2DeviceAuthorizationResponse;
    using OAuth2Token = global::G.Api.OAuth2Token;
    using IOAuth2TokenStore = global::G.Api.IOAuth2TokenStore;
    using AutoSDKOAuth2Helpers = global::G.Api.AutoSDKOAuth2Helpers;

    public sealed partial class SubscriptionsClient
    {
        /// <summary>
        /// Known OAuth2 scopes.
        /// </summary>
        public enum OAuth2Scope
        {
            /// <summary>
            /// OAuth2 scope <c>analytics:read:extensions</c>.
            /// </summary>
            Analytics_read_extensions,            /// <summary>
            /// OAuth2 scope <c>analytics:read:games</c>.
            /// </summary>
            Analytics_read_games,            /// <summary>
            /// OAuth2 scope <c>bits:read</c>.
            /// </summary>
            Bits_read,            /// <summary>
            /// OAuth2 scope <c>channel:manage:ads</c>.
            /// </summary>
            Channel_manage_ads,            /// <summary>
            /// OAuth2 scope <c>channel:read:ads</c>.
            /// </summary>
            Channel_read_ads,            /// <summary>
            /// OAuth2 scope <c>channel:manage:broadcast</c>.
            /// </summary>
            Channel_manage_broadcast,            /// <summary>
            /// OAuth2 scope <c>channel:read:charity</c>.
            /// </summary>
            Channel_read_charity,            /// <summary>
            /// OAuth2 scope <c>channel:edit:commercial</c>.
            /// </summary>
            Channel_edit_commercial,            /// <summary>
            /// OAuth2 scope <c>channel:read:editors</c>.
            /// </summary>
            Channel_read_editors,            /// <summary>
            /// OAuth2 scope <c>channel:manage:extensions</c>.
            /// </summary>
            Channel_manage_extensions,            /// <summary>
            /// OAuth2 scope <c>channel:read:goals</c>.
            /// </summary>
            Channel_read_goals,            /// <summary>
            /// OAuth2 scope <c>channel:read:guest_star</c>.
            /// </summary>
            Channel_read_guestStar,            /// <summary>
            /// OAuth2 scope <c>channel:manage:guest_star</c>.
            /// </summary>
            Channel_manage_guestStar,            /// <summary>
            /// OAuth2 scope <c>channel:read:hype_train</c>.
            /// </summary>
            Channel_read_hypeTrain,            /// <summary>
            /// OAuth2 scope <c>channel:manage:moderators</c>.
            /// </summary>
            Channel_manage_moderators,            /// <summary>
            /// OAuth2 scope <c>channel:read:polls</c>.
            /// </summary>
            Channel_read_polls,            /// <summary>
            /// OAuth2 scope <c>channel:manage:polls</c>.
            /// </summary>
            Channel_manage_polls,            /// <summary>
            /// OAuth2 scope <c>channel:read:predictions</c>.
            /// </summary>
            Channel_read_predictions,            /// <summary>
            /// OAuth2 scope <c>channel:manage:predictions</c>.
            /// </summary>
            Channel_manage_predictions,            /// <summary>
            /// OAuth2 scope <c>channel:manage:raids</c>.
            /// </summary>
            Channel_manage_raids,            /// <summary>
            /// OAuth2 scope <c>channel:read:redemptions</c>.
            /// </summary>
            Channel_read_redemptions,            /// <summary>
            /// OAuth2 scope <c>channel:manage:redemptions</c>.
            /// </summary>
            Channel_manage_redemptions,            /// <summary>
            /// OAuth2 scope <c>channel:manage:schedule</c>.
            /// </summary>
            Channel_manage_schedule,            /// <summary>
            /// OAuth2 scope <c>channel:read:stream_key</c>.
            /// </summary>
            Channel_read_streamKey,            /// <summary>
            /// OAuth2 scope <c>channel:read:subscriptions</c>.
            /// </summary>
            Channel_read_subscriptions,            /// <summary>
            /// OAuth2 scope <c>channel:manage:videos</c>.
            /// </summary>
            Channel_manage_videos,            /// <summary>
            /// OAuth2 scope <c>channel:read:vips</c>.
            /// </summary>
            Channel_read_vips,            /// <summary>
            /// OAuth2 scope <c>channel:manage:vips</c>.
            /// </summary>
            Channel_manage_vips,            /// <summary>
            /// OAuth2 scope <c>clips:edit</c>.
            /// </summary>
            Clips_edit,            /// <summary>
            /// OAuth2 scope <c>moderation:read</c>.
            /// </summary>
            Moderation_read,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:announcements</c>.
            /// </summary>
            Moderator_manage_announcements,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:automod</c>.
            /// </summary>
            Moderator_manage_automod,            /// <summary>
            /// OAuth2 scope <c>moderator:read:automod_settings</c>.
            /// </summary>
            Moderator_read_automodSettings,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:automod_settings</c>.
            /// </summary>
            Moderator_manage_automodSettings,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:banned_users</c>.
            /// </summary>
            Moderator_manage_bannedUsers,            /// <summary>
            /// OAuth2 scope <c>moderator:read:blocked_terms</c>.
            /// </summary>
            Moderator_read_blockedTerms,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:blocked_terms</c>.
            /// </summary>
            Moderator_manage_blockedTerms,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:chat_messages</c>.
            /// </summary>
            Moderator_manage_chatMessages,            /// <summary>
            /// OAuth2 scope <c>moderator:read:chat_settings</c>.
            /// </summary>
            Moderator_read_chatSettings,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:chat_settings</c>.
            /// </summary>
            Moderator_manage_chatSettings,            /// <summary>
            /// OAuth2 scope <c>moderator:read:chatters</c>.
            /// </summary>
            Moderator_read_chatters,            /// <summary>
            /// OAuth2 scope <c>moderator:read:followers</c>.
            /// </summary>
            Moderator_read_followers,            /// <summary>
            /// OAuth2 scope <c>moderator:read:guest_star</c>.
            /// </summary>
            Moderator_read_guestStar,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:guest_star</c>.
            /// </summary>
            Moderator_manage_guestStar,            /// <summary>
            /// OAuth2 scope <c>moderator:read:shield_mode</c>.
            /// </summary>
            Moderator_read_shieldMode,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:shield_mode</c>.
            /// </summary>
            Moderator_manage_shieldMode,            /// <summary>
            /// OAuth2 scope <c>moderator:read:shoutouts</c>.
            /// </summary>
            Moderator_read_shoutouts,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:shoutouts</c>.
            /// </summary>
            Moderator_manage_shoutouts,            /// <summary>
            /// OAuth2 scope <c>moderator:read:unban_requests</c>.
            /// </summary>
            Moderator_read_unbanRequests,            /// <summary>
            /// OAuth2 scope <c>moderator:manage:unban_requests</c>.
            /// </summary>
            Moderator_manage_unbanRequests,            /// <summary>
            /// OAuth2 scope <c>user:edit</c>.
            /// </summary>
            User_edit,            /// <summary>
            /// OAuth2 scope <c>user:read:blocked_users</c>.
            /// </summary>
            User_read_blockedUsers,            /// <summary>
            /// OAuth2 scope <c>user:manage:blocked_users</c>.
            /// </summary>
            User_manage_blockedUsers,            /// <summary>
            /// OAuth2 scope <c>user:read:broadcast</c>.
            /// </summary>
            User_read_broadcast,            /// <summary>
            /// OAuth2 scope <c>user:manage:chat_color</c>.
            /// </summary>
            User_manage_chatColor,            /// <summary>
            /// OAuth2 scope <c>user:read:email</c>.
            /// </summary>
            User_read_email,            /// <summary>
            /// OAuth2 scope <c>user:read:emotes</c>.
            /// </summary>
            User_read_emotes,            /// <summary>
            /// OAuth2 scope <c>user:read:follows</c>.
            /// </summary>
            User_read_follows,            /// <summary>
            /// OAuth2 scope <c>user:read:moderated_channels</c>.
            /// </summary>
            User_read_moderatedChannels,            /// <summary>
            /// OAuth2 scope <c>user:read:subscriptions</c>.
            /// </summary>
            User_read_subscriptions,            /// <summary>
            /// OAuth2 scope <c>user:manage:whispers</c>.
            /// </summary>
            User_manage_whispers,            /// <summary>
            /// OAuth2 scope <c>channel:bot</c>.
            /// </summary>
            Channel_bot,            /// <summary>
            /// OAuth2 scope <c>channel:moderate</c>.
            /// </summary>
            Channel_moderate,            /// <summary>
            /// OAuth2 scope <c>chat:edit</c>.
            /// </summary>
            Chat_edit,            /// <summary>
            /// OAuth2 scope <c>chat:read</c>.
            /// </summary>
            Chat_read,            /// <summary>
            /// OAuth2 scope <c>user:bot</c>.
            /// </summary>
            User_bot,            /// <summary>
            /// OAuth2 scope <c>user:read:chat</c>.
            /// </summary>
            User_read_chat,            /// <summary>
            /// OAuth2 scope <c>user:write:chat</c>.
            /// </summary>
            User_write_chat,            /// <summary>
            /// OAuth2 scope <c>whispers:read</c>.
            /// </summary>
            Whispers_read,            /// <summary>
            /// OAuth2 scope <c>whispers:edit</c>.
            /// </summary>
            Whispers_edit,
        }
        /// <summary>
        /// Gets the OAuth2 metadata URL declared by the security scheme, if any.
        /// </summary>
        public string? OAuth2MetadataUrl => string.IsNullOrWhiteSpace("")
            ? null
            : "";

        /// <summary>
        /// Gets a value indicating whether the OAuth2 security scheme is deprecated.
        /// </summary>
        public bool IsOAuth2Deprecated => false;
        /// <summary>
        /// Gets or sets the OAuth2 token store.
        /// </summary>
        public IOAuth2TokenStore OAuth2TokenStore
        {
            get => AutoSDKOAuth2State.TokenStore;
            set
            {
                value = value ?? throw new global::System.ArgumentNullException(nameof(value));

                var token = AutoSDKOAuth2State.GetToken();
                AutoSDKOAuth2State.TokenStore = value;
                if (token is not null)
                {
                    AutoSDKOAuth2State.SetToken(token);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
        /// </summary>
        public bool AutoRefreshOAuth2Tokens
        {
            get => AutoSDKOAuth2State.AutoRefreshTokens;
            set => AutoSDKOAuth2State.AutoRefreshTokens = value;
        }

        /// <summary>
        /// Gets or sets the clock skew used when checking OAuth2 token expiration.
        /// </summary>
        public global::System.TimeSpan OAuth2RefreshClockSkew
        {
            get => AutoSDKOAuth2State.RefreshClockSkew;
            set
            {
                if (value < global::System.TimeSpan.Zero)
                {
                    throw new global::System.ArgumentOutOfRangeException(nameof(value));
                }

                AutoSDKOAuth2State.RefreshClockSkew = value;
            }
        }

        /// <summary>
        /// Configures the OAuth2 token refresh callback.
        /// </summary>
        /// <param name="refreshTokenAsync"></param>
        public void ConfigureOAuth2TokenRefresh(
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>> refreshTokenAsync)
        {
            AutoSDKOAuth2State.ConfigureRefresh(refreshTokenAsync);
        }

        /// <summary>
        /// Gets the currently stored OAuth2 token.
        /// </summary>
        /// <returns>The stored OAuth2 token, if present.</returns>
        public OAuth2Token? GetOAuth2Token()
        {
            return AutoSDKOAuth2State.GetToken();
        }

        /// <summary>
        /// Clears the stored OAuth2 token.
        /// </summary>
        public void ClearOAuth2Token()
        {
            AutoSDKOAuth2State.SetToken(null);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, null);
        }

        /// <summary>
        /// Authorize using an OAuth2 access token.
        /// </summary>
        /// <param name="accessToken"></param>

        public void AuthorizeUsingOAuth2(
            string accessToken)
        {
            accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));

            AuthorizeUsingOAuth2(new OAuth2Token
            {
                AccessToken = accessToken,
                TokenType = "Bearer",
            });
        }

        /// <summary>
        /// Authorize using an OAuth2 token.
        /// </summary>
        /// <param name="token"></param>

        public void AuthorizeUsingOAuth2(
            OAuth2Token token)
        {
            token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            if (string.IsNullOrWhiteSpace(token.AccessToken))
            {
                throw new global::System.ArgumentException("Access token cannot be empty.", nameof(token));
            }
            if (string.IsNullOrWhiteSpace(token.TokenType))
            {
                token.TokenType = "Bearer";
            }

            var storedToken = token.Clone();
            AutoSDKOAuth2State.SetToken(storedToken);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, storedToken);
        }


        private async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2TokenAsync(
            global::System.Uri tokenUrl,
            global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> body,
            string? requestedScope = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            tokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            body = body ?? throw new global::System.ArgumentNullException(nameof(body));

            using var response = await HttpClient.PostAsync(
                requestUri: tokenUrl,
                content: new global::System.Net.Http.FormUrlEncodedContent(body),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            using var jsonDocument = global::System.Text.Json.JsonDocument.Parse(json);
            if (!jsonDocument.RootElement.TryGetProperty("access_token", out var accessTokenElement))
            {
                throw new global::System.InvalidOperationException("access_token was not present in the token response.");
            }

            var accessToken = accessTokenElement.GetString();
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new global::System.InvalidOperationException("access_token was empty in the token response.");
            }

            string? tokenType = null;
            if (jsonDocument.RootElement.TryGetProperty("token_type", out var tokenTypeElement))
            {
                tokenType = tokenTypeElement.GetString();
            }

            string? refreshToken = null;
            if (jsonDocument.RootElement.TryGetProperty("refresh_token", out var refreshTokenElement))
            {
                refreshToken = refreshTokenElement.GetString();
            }

            string? scope = null;
            if (jsonDocument.RootElement.TryGetProperty("scope", out var scopeElement))
            {
                scope = scopeElement.GetString();
            }

            long? expiresIn = null;
            if (jsonDocument.RootElement.TryGetProperty("expires_in", out var expiresInElement))
            {
                if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.Number &&
                    expiresInElement.TryGetInt64(out var expiresInValue))
                {
                    expiresIn = expiresInValue;
                }
                else if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.String &&
                         long.TryParse(expiresInElement.GetString(), out expiresInValue))
                {
                    expiresIn = expiresInValue;
                }
            }

            var token = new OAuth2Token
            {
                AccessToken = accessToken,
                TokenType = string.IsNullOrWhiteSpace(tokenType) ? "Bearer" : tokenType,
                RefreshToken = refreshToken,
                Scope = string.IsNullOrWhiteSpace(scope) ? requestedScope : scope,
                ExpiresAt = expiresIn.HasValue
                    ? global::System.DateTimeOffset.UtcNow.AddSeconds(expiresIn.Value)
                    : (global::System.DateTimeOffset?)null,
            };

            return token;
        }
        private static string ToOAuth2ScopeValue(
            OAuth2Scope scope)
        {
            return scope switch
            {
                OAuth2Scope.Analytics_read_extensions => "analytics:read:extensions",                OAuth2Scope.Analytics_read_games => "analytics:read:games",                OAuth2Scope.Bits_read => "bits:read",                OAuth2Scope.Channel_manage_ads => "channel:manage:ads",                OAuth2Scope.Channel_read_ads => "channel:read:ads",                OAuth2Scope.Channel_manage_broadcast => "channel:manage:broadcast",                OAuth2Scope.Channel_read_charity => "channel:read:charity",                OAuth2Scope.Channel_edit_commercial => "channel:edit:commercial",                OAuth2Scope.Channel_read_editors => "channel:read:editors",                OAuth2Scope.Channel_manage_extensions => "channel:manage:extensions",                OAuth2Scope.Channel_read_goals => "channel:read:goals",                OAuth2Scope.Channel_read_guestStar => "channel:read:guest_star",                OAuth2Scope.Channel_manage_guestStar => "channel:manage:guest_star",                OAuth2Scope.Channel_read_hypeTrain => "channel:read:hype_train",                OAuth2Scope.Channel_manage_moderators => "channel:manage:moderators",                OAuth2Scope.Channel_read_polls => "channel:read:polls",                OAuth2Scope.Channel_manage_polls => "channel:manage:polls",                OAuth2Scope.Channel_read_predictions => "channel:read:predictions",                OAuth2Scope.Channel_manage_predictions => "channel:manage:predictions",                OAuth2Scope.Channel_manage_raids => "channel:manage:raids",                OAuth2Scope.Channel_read_redemptions => "channel:read:redemptions",                OAuth2Scope.Channel_manage_redemptions => "channel:manage:redemptions",                OAuth2Scope.Channel_manage_schedule => "channel:manage:schedule",                OAuth2Scope.Channel_read_streamKey => "channel:read:stream_key",                OAuth2Scope.Channel_read_subscriptions => "channel:read:subscriptions",                OAuth2Scope.Channel_manage_videos => "channel:manage:videos",                OAuth2Scope.Channel_read_vips => "channel:read:vips",                OAuth2Scope.Channel_manage_vips => "channel:manage:vips",                OAuth2Scope.Clips_edit => "clips:edit",                OAuth2Scope.Moderation_read => "moderation:read",                OAuth2Scope.Moderator_manage_announcements => "moderator:manage:announcements",                OAuth2Scope.Moderator_manage_automod => "moderator:manage:automod",                OAuth2Scope.Moderator_read_automodSettings => "moderator:read:automod_settings",                OAuth2Scope.Moderator_manage_automodSettings => "moderator:manage:automod_settings",                OAuth2Scope.Moderator_manage_bannedUsers => "moderator:manage:banned_users",                OAuth2Scope.Moderator_read_blockedTerms => "moderator:read:blocked_terms",                OAuth2Scope.Moderator_manage_blockedTerms => "moderator:manage:blocked_terms",                OAuth2Scope.Moderator_manage_chatMessages => "moderator:manage:chat_messages",                OAuth2Scope.Moderator_read_chatSettings => "moderator:read:chat_settings",                OAuth2Scope.Moderator_manage_chatSettings => "moderator:manage:chat_settings",                OAuth2Scope.Moderator_read_chatters => "moderator:read:chatters",                OAuth2Scope.Moderator_read_followers => "moderator:read:followers",                OAuth2Scope.Moderator_read_guestStar => "moderator:read:guest_star",                OAuth2Scope.Moderator_manage_guestStar => "moderator:manage:guest_star",                OAuth2Scope.Moderator_read_shieldMode => "moderator:read:shield_mode",                OAuth2Scope.Moderator_manage_shieldMode => "moderator:manage:shield_mode",                OAuth2Scope.Moderator_read_shoutouts => "moderator:read:shoutouts",                OAuth2Scope.Moderator_manage_shoutouts => "moderator:manage:shoutouts",                OAuth2Scope.Moderator_read_unbanRequests => "moderator:read:unban_requests",                OAuth2Scope.Moderator_manage_unbanRequests => "moderator:manage:unban_requests",                OAuth2Scope.User_edit => "user:edit",                OAuth2Scope.User_read_blockedUsers => "user:read:blocked_users",                OAuth2Scope.User_manage_blockedUsers => "user:manage:blocked_users",                OAuth2Scope.User_read_broadcast => "user:read:broadcast",                OAuth2Scope.User_manage_chatColor => "user:manage:chat_color",                OAuth2Scope.User_read_email => "user:read:email",                OAuth2Scope.User_read_emotes => "user:read:emotes",                OAuth2Scope.User_read_follows => "user:read:follows",                OAuth2Scope.User_read_moderatedChannels => "user:read:moderated_channels",                OAuth2Scope.User_read_subscriptions => "user:read:subscriptions",                OAuth2Scope.User_manage_whispers => "user:manage:whispers",                OAuth2Scope.Channel_bot => "channel:bot",                OAuth2Scope.Channel_moderate => "channel:moderate",                OAuth2Scope.Chat_edit => "chat:edit",                OAuth2Scope.Chat_read => "chat:read",                OAuth2Scope.User_bot => "user:bot",                OAuth2Scope.User_read_chat => "user:read:chat",                OAuth2Scope.User_write_chat => "user:write:chat",                OAuth2Scope.Whispers_read => "whispers:read",                OAuth2Scope.Whispers_edit => "whispers:edit",
                _ => throw new global::System.NotImplementedException("OAuth2 scope not implemented."),
            };
        }

        private static string? JoinOAuth2Scopes(
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes)
        {
            if (scopes is null)
            {
                return null;
            }

            return string.Join(" ", global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)));
        }
    }
}