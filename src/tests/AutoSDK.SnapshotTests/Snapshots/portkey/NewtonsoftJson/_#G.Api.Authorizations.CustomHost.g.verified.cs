//HintName: G.Api.Authorizations.CustomHost.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc/>
        public void AuthorizeUsingCustomHost(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-portkey-custom-host")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "CustomHost",
                Location = "Header",
                Name = "x-portkey-custom-host",
                Value = apiKey,
            });
        }
    }
}