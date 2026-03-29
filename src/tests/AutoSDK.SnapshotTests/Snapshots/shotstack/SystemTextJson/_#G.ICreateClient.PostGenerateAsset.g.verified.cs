//HintName: G.ICreateClient.PostGenerateAsset.g.cs
#nullable enable

namespace G
{
    public partial interface ICreateClient
    {
        /// <summary>
        /// Generate Asset<br/>
        /// Generate an asset using a Shotstack or third party provider. Chose the provider, type of asset and provide prompts,<br/>
        /// inputs and options to generate the asset. Once generated the asset can be used with the [Edit](#tocs_edit) API or<br/>
        /// downloaded.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/create/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GeneratedAssetResponse> PostGenerateAssetAsync(

            global::G.GeneratedAsset request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Asset<br/>
        /// Generate an asset using a Shotstack or third party provider. Chose the provider, type of asset and provide prompts,<br/>
        /// inputs and options to generate the asset. Once generated the asset can be used with the [Edit](#tocs_edit) API or<br/>
        /// downloaded.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/create/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GeneratedAssetResponse> PostGenerateAssetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}