//HintName: G.IAgentsClient.AgentsPhoneNumbers.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Phone Numbers<br/>
        /// List the phone numbers associated with an agent. Currently, you can only have one phone number per agent and these are provisioned by Cartesia.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PhoneNumber>> AgentsPhoneNumbersAsync(
            global::G.AgentsPhoneNumbersCartesiaVersion cartesiaVersion,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}