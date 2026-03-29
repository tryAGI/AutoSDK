//HintName: G.IOrganizationsClient.Update3.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Update organization member/role<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update organization membership or role for a specific user ID.<br/>
        /// **User Rotation Best Practices for API Usage**<br/>
        /// To maintain compliance with our licensing terms and ensure optimal performance of HumanSignal's APIs, please consider the following guidelines when managing user assignments:<br/>
        /// * **Maintain a 7-Day Minimum Assignment**: Once a licensed seat is assigned to a user, maintain that assignment for at least seven consecutive days before rotating it to another user.<br/>
        /// * **Automate, Monitor, and Log Rotations**: Implement automated scheduling and logging mechanisms to track the timing of user rotations. This helps ensure that rotations adhere to the seven-day minimum period.<br/>
        /// * **Adhere to API Update Frequency and Wait Periods**: When updating user assignments via our APIs, follow the recommended frequency and wait period guidelines provided in the HumanSignal API documentation. Avoid sending rapid, successive requests that might overload the endpoint. Instead, incorporate appropriate delays between calls as specified in the documentation.<br/>
        /// * **Avoid Overloading the API Endpoint**: Design your integration to batch or schedule updates where possible, and implement backoff strategies if the API indicates rate limiting. This helps prevent service disruptions and ensures a smooth operation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseOrganizationMemberList> Update3Async(
            int id,

            global::G.PatchedOrganizationMemberCreateUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update organization member/role<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update organization membership or role for a specific user ID.<br/>
        /// **User Rotation Best Practices for API Usage**<br/>
        /// To maintain compliance with our licensing terms and ensure optimal performance of HumanSignal's APIs, please consider the following guidelines when managing user assignments:<br/>
        /// * **Maintain a 7-Day Minimum Assignment**: Once a licensed seat is assigned to a user, maintain that assignment for at least seven consecutive days before rotating it to another user.<br/>
        /// * **Automate, Monitor, and Log Rotations**: Implement automated scheduling and logging mechanisms to track the timing of user rotations. This helps ensure that rotations adhere to the seven-day minimum period.<br/>
        /// * **Adhere to API Update Frequency and Wait Periods**: When updating user assignments via our APIs, follow the recommended frequency and wait period guidelines provided in the HumanSignal API documentation. Avoid sending rapid, successive requests that might overload the endpoint. Instead, incorporate appropriate delays between calls as specified in the documentation.<br/>
        /// * **Avoid Overloading the API Endpoint**: Design your integration to batch or schedule updates where possible, and implement backoff strategies if the API indicates rate limiting. This helps prevent service disruptions and ensures a smooth operation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role">
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="userId">
        /// Member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseOrganizationMemberList> Update3Async(
            int id,
            global::G.Role9e7Enum? role = default,
            int? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}