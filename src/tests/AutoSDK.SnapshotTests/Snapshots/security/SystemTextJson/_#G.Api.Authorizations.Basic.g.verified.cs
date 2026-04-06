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

            Authorizations.Clear();
            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Basic",
                Value = global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($"{username}:{password}")),
            });
        }
    }
}