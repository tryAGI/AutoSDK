//HintName: G.Models.Edit.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
    /// </summary>
    public sealed partial class Edit
    {
        /// <summary>
        /// A timeline represents the contents of a video edit over time, an audio edit over time, in seconds, or an image layout. A timeline consists of layers called tracks. Tracks are composed of titles, images, audio, html or video segments referred to as clips which are placed along the track at specific starting point and lasting for a specific amount of time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeline", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Timeline Timeline { get; set; } = default!;

        /// <summary>
        /// The output format, render range and type of media to generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Output Output { get; set; } = default!;

        /// <summary>
        /// An array of key/value pairs that provides an easy way to create templates with placeholders. The placeholders can be used to find and replace keys with values. For example you can search for the placeholder `{{NAME}}` and replace it with the value `Jane`. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge")]
        public global::System.Collections.Generic.IList<global::G.MergeField>? Merge { get; set; }

        /// <summary>
        /// An optional webhook callback URL used to receive status notifications when a render completes or fails. Notifications are also sent when a rendered video is sent to an output  [destination](https://shotstack.io/docs/guide/serving-assets/destinations/).<br/>
        /// See [webhooks](https://shotstack.io/docs/guide/architecting-an-application/webhooks/) for more details.<br/>
        /// Example: https://my-server.com/callback.php
        /// </summary>
        /// <example>https://my-server.com/callback.php</example>
        [global::Newtonsoft.Json.JsonProperty("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// **Notice: This option is now deprecated and will be removed. Disk types are handled automatically. Setting a disk type has no effect.**<br/>
        /// The disk type to use for storing footage and assets for each render. See [disk types](https://shotstack.io/docs/guide/architecting-an-application/disk-types/) for more details.<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;`local` - optimized for high speed rendering with up to 512MB storage&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mount` - optimized for larger file sizes and longer videos with 5GB for source footage and 512MB for output render&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disk")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.EditDisk? Disk { get; set; }

        /// <summary>
        /// The render instance type to use for processing the edit. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`s1` - standard instance (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`s2` - standard instance with more resources&lt;/li&gt;<br/>
        ///   &lt;li&gt;`a1` - accelerated instance for faster rendering&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: s1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instance")]
        public global::G.EditInstance? Instance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit" /> class.
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
        public Edit(
            global::G.Timeline timeline,
            global::G.Output output,
            global::System.Collections.Generic.IList<global::G.MergeField>? merge,
            string? callback,
            global::G.EditInstance? instance)
        {
            this.Timeline = timeline ?? throw new global::System.ArgumentNullException(nameof(timeline));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Merge = merge;
            this.Callback = callback;
            this.Instance = instance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit" /> class.
        /// </summary>
        public Edit()
        {
        }
    }
}