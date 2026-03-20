//HintName: G.IUploadsClient.CreateUploads.g.cs
#nullable enable

namespace G
{
    public partial interface IUploadsClient
    {

        /// <summary>
        /// Upload a file<br/>
        /// Uploads a temporary media file that can be referenced in API generation requests. The uploaded files will be automatically expired and deleted after a period of time. It is strongly recommended to use our SDKs for this which have a simplified interface that directly accepts file objects.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>

        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// import fs from 'node:fs';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// filename = './funny-cats.mp4';<br/>
        /// const uploadUri = await client.uploads.createEphemeral(<br/>
        ///   fs.createReadStream(filename),<br/>
        /// );<br/>
        /// // Use the runwayUri in generation requests<br/>
        /// const task = await client.videoToVideo<br/>
        ///   .create({<br/>
        ///     model: 'gen4_aleph',<br/>
        ///     videoUri: uploadUri,<br/>
        ///     promptText: 'Add the easter elements to the cat video',<br/>
        ///     references: [<br/>
        ///       {<br/>
        ///         type: 'image',<br/>
        ///         uri: 'https://example.com/easter-scene.jpg',<br/>
        ///       },<br/>
        ///     ],<br/>
        ///     ratio: '1280:720',<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Response25> CreateUploadsAsync(

            global::G.Request12 request,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Uploads a temporary media file that can be referenced in API generation requests. The uploaded files will be automatically expired and deleted after a period of time. It is strongly recommended to use our SDKs for this which have a simplified interface that directly accepts file objects.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="filename">
        /// The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).
        /// </param>
        /// <param name="type">
        /// The type of upload to create
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response25> CreateUploadsAsync(
            string filename,
            string xRunwayVersion = "2024-11-06",
            global::G.RequestType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}