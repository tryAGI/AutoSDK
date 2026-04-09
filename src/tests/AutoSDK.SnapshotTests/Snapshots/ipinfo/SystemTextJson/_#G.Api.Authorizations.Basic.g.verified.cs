//HintName: G.Api.Authorizations.Basic.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc/>
        public void AuthorizeUsingBasic(
            string username,
            string password)
        {
            username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            password = password ?? throw new global::System.ArgumentNullException(nameof(password));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "Http" &&
                    __authorization.Name == "Basic")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "Http",
                SchemeId = "BasicAuth",
                Location = "Header",
                Name = "Basic",
                Value = global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($"{username}:{password}")),
            });
        }
    }
}