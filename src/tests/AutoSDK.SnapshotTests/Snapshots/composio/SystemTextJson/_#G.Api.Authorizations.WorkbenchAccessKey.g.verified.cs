//HintName: G.Api.Authorizations.WorkbenchAccessKey.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc/>
        public void AuthorizeUsingWorkbenchAccessKey(
 )
        {

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "",
                SchemeId = "WorkbenchAccessKey",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}