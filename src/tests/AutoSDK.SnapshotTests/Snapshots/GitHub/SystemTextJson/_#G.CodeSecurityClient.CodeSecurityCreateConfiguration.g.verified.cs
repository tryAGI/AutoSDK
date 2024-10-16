﻿//HintName: G.CodeSecurityClient.CodeSecurityCreateConfiguration.g.cs

#nullable enable

namespace G
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityCreateConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.CodeSecurityCreateConfigurationRequest request);
        partial void PrepareCodeSecurityCreateConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.CodeSecurityCreateConfigurationRequest request);
        partial void ProcessCodeSecurityCreateConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeSecurityCreateConfigurationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityCreateConfigurationAsync(
            string org,
            global::G.CodeSecurityCreateConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodeSecurityCreateConfigurationArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-security/configurations",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeSecurityCreateConfigurationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodeSecurityCreateConfigurationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeSecurityCreateConfigurationResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.CodeSecurityConfiguration.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityCreateConfigurationAsync(
            string org,
            string name,
            string description,
            global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity? advancedSecurity = global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? dependencyGraph = global::G.CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts? dependabotAlerts = global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanning? secretScanning = global::G.CodeSecurityCreateConfigurationRequestSecretScanning.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestEnforcement? enforcement = global::G.CodeSecurityCreateConfigurationRequestEnforcement.Enforced,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodeSecurityCreateConfigurationRequest
            {
                Name = name,
                Description = description,
                AdvancedSecurity = advancedSecurity,
                DependencyGraph = dependencyGraph,
                DependencyGraphAutosubmitAction = dependencyGraphAutosubmitAction,
                DependencyGraphAutosubmitActionOptions = dependencyGraphAutosubmitActionOptions,
                DependabotAlerts = dependabotAlerts,
                DependabotSecurityUpdates = dependabotSecurityUpdates,
                CodeScanningDefaultSetup = codeScanningDefaultSetup,
                SecretScanning = secretScanning,
                SecretScanningPushProtection = secretScanningPushProtection,
                SecretScanningValidityChecks = secretScanningValidityChecks,
                SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns,
                PrivateVulnerabilityReporting = privateVulnerabilityReporting,
                Enforcement = enforcement,
            };

            return await CodeSecurityCreateConfigurationAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}