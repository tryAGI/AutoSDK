//HintName: G.IEditClient.Probe.g.cs
#nullable enable

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Inspect Media<br/>
        /// Inspects any media asset (image, video, audio) on the internet using a hosted version<br/>
        /// of [FFprobe](https://ffmpeg.org/ffprobe.html). The probe endpoint returns useful information<br/>
        /// about an asset such as width, height, duration, rotation, framerate, etc...<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProbeResponse> ProbeAsync(
            string url,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}