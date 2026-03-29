//HintName: G.IEditClient.PostRender.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Render Asset<br/>
        /// Queue and render the contents of an [Edit](#tocs_edit) as a video, image or audio file.<br/>
        /// **Rendering Process:**<br/>
        /// 1. **Validation**: The edit JSON is validated<br/>
        /// 2. **Download**: All assets are downloaded and cached  <br/>
        /// 3. **Preprocessing**: Video assets are automatically processed to fix compatibility issues<br/>
        /// 4. **Rendering**: The timeline is rendered using the processed assets<br/>
        /// 5. **Output**: The final media file is generated and stored<br/>
        /// **Video Preprocessing:**<br/>
        /// Video assets undergo automatic preprocessing to ensure compatibility. You can force <br/>
        /// preprocessing by setting `"transcode": true` on video assets. See [Preprocessing](#preprocessing) <br/>
        /// for more details.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueuedResponse> PostRenderAsync(

            global::G.Edit request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Render Asset<br/>
        /// Queue and render the contents of an [Edit](#tocs_edit) as a video, image or audio file.<br/>
        /// **Rendering Process:**<br/>
        /// 1. **Validation**: The edit JSON is validated<br/>
        /// 2. **Download**: All assets are downloaded and cached  <br/>
        /// 3. **Preprocessing**: Video assets are automatically processed to fix compatibility issues<br/>
        /// 4. **Rendering**: The timeline is rendered using the processed assets<br/>
        /// 5. **Output**: The final media file is generated and stored<br/>
        /// **Video Preprocessing:**<br/>
        /// Video assets undergo automatic preprocessing to ensure compatibility. You can force <br/>
        /// preprocessing by setting `"transcode": true` on video assets. See [Preprocessing](#preprocessing) <br/>
        /// for more details.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="timeline">
        /// A timeline represents the contents of a video edit over time, an audio edit over time, in seconds, or an image layout. A timeline consists of layers called tracks. Tracks are composed of titles, images, audio, html or video segments referred to as clips which are placed along the track at specific starting point and lasting for a specific amount of time.
        /// </param>
        /// <param name="output">
        /// The output format, render range and type of media to generate.
        /// </param>
        /// <param name="merge">
        /// An array of key/value pairs that provides an easy way to create templates with placeholders. The placeholders can be used to find and replace keys with values. For example you can search for the placeholder `{{NAME}}` and replace it with the value `Jane`. 
        /// </param>
        /// <param name="callback">
        /// An optional webhook callback URL used to receive status notifications when a render completes or fails. Notifications are also sent when a rendered video is sent to an output  [destination](https://shotstack.io/docs/guide/serving-assets/destinations/).<br/>
        /// See [webhooks](https://shotstack.io/docs/guide/architecting-an-application/webhooks/) for more details.<br/>
        /// Example: https://my-server.com/callback.php
        /// </param>
        /// <param name="instance">
        /// The render instance type to use for processing the edit. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`s1` - standard instance (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`s2` - standard instance with more resources&lt;/li&gt;<br/>
        ///   &lt;li&gt;`a1` - accelerated instance for faster rendering&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: s1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueuedResponse> PostRenderAsync(
            global::G.Timeline timeline,
            global::G.Output output,
            global::System.Collections.Generic.IList<global::G.MergeField>? merge = default,
            string? callback = default,
            global::G.EditInstance? instance = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}