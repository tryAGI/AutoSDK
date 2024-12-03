//HintName: G.IActivityClient.ActivityGetFeeds.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get feeds<br/>
        /// Lists the feeds available to the authenticated user. The response provides a URL for each feed. You can then get a specific feed by sending a request to one of the feed URLs.<br/>
        /// *   **Timeline**: The GitHub global public timeline<br/>
        /// *   **User**: The public timeline for any user, using `uri_template`. For more information, see "[Hypermedia](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#hypermedia)."<br/>
        /// *   **Current user public**: The public timeline for the authenticated user<br/>
        /// *   **Current user**: The private timeline for the authenticated user<br/>
        /// *   **Current user actor**: The private timeline for activity created by the authenticated user<br/>
        /// *   **Current user organizations**: The private timeline for the organizations the authenticated user is a member of.<br/>
        /// *   **Security advisories**: A collection of public announcements that provide information about security-related vulnerabilities in software on GitHub.<br/>
        /// By default, timeline resources are returned in JSON. You can specify the `application/atom+xml` type in the `Accept` header to return timeline resources in Atom format. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Private feeds are only returned when [authenticating via Basic Auth](https://docs.github.com/rest/authentication/authenticating-to-the-rest-api#using-basic-authentication) since current feed URIs use the older, non revocable auth tokens.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Feed> ActivityGetFeedsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}