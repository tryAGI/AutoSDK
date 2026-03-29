//HintName: G.IWelcomeWizardClient.GetWelcomeWizardStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IWelcomeWizardClient
    {
        /// <summary>
        /// Get welcome wizard tracking status<br/>
        /// Get welcome wizard tracking status for the current workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WelcomeWizardTracking> GetWelcomeWizardStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}