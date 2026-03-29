//HintName: G.IIcModelDetailsClient.IcModelAll.g.cs
#nullable enable

namespace G
{
    public partial interface IIcModelDetailsClient
    {
        /// <summary>
        /// Get All Model Details<br/>
        /// Get information of all models in an account, irrespective of the type of model (OCR model or Image Classification model).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/ImageCategorization/Models/");<br/>
        /// var request = new RestRequest(Method.GET);<br/>
        /// request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> IcModelAllAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}