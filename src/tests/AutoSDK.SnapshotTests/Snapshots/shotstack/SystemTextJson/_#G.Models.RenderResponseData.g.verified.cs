//HintName: G.Models.RenderResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response data returned with the [RenderResponse](#tocs_renderresponse) including status and URL.
    /// </summary>
    public sealed partial class RenderResponseData
    {
        /// <summary>
        /// The id of the render task in UUID format.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </summary>
        /// <example>2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The owner id of the render task.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// The customer subscription plan.<br/>
        /// Example: basic
        /// </summary>
        /// <example>basic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// The status of the render task. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`queued` - render is queued waiting to be rendered&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fetching` - assets are being fetched&lt;/li&gt;<br/>
        ///   &lt;li&gt;`preprocessing` - video assets are being processed for compatibility&lt;/li&gt;<br/>
        ///   &lt;li&gt;`rendering` - the asset is being rendered&lt;/li&gt;<br/>
        ///   &lt;li&gt;`saving` - the final asset is being saved to storage&lt;/li&gt;<br/>
        ///   &lt;li&gt;`done` - the asset is ready to be downloaded&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - there was an error rendering the asset&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: done
        /// </summary>
        /// <example>done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RenderResponseDataStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RenderResponseDataStatus Status { get; set; }

        /// <summary>
        /// An error message, only displayed if an error occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The output video or audio length in seconds.<br/>
        /// Example: 8.5F
        /// </summary>
        /// <example>8.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The time taken to render the asset in milliseconds.<br/>
        /// Example: 9433.44F
        /// </summary>
        /// <example>9433.44F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("renderTime")]
        public double? RenderTime { get; set; }

        /// <summary>
        /// The URL of the final asset. This will only be available if status is done. This is a temporary URL and will be deleted after 24 hours. By default all assets are copied to the Shotstack hosting and CDN destination.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4
        /// </summary>
        /// <example>https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The URL of the poster image if requested. This will only be available if status is done.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7-poster.jpg
        /// </summary>
        /// <example>https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7-poster.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("poster")]
        public string? Poster { get; set; }

        /// <summary>
        /// The URL of the thumbnail image if requested. This will only be available if status is done.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7-thumb.jpg
        /// </summary>
        /// <example>https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7-thumb.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        /// <summary>
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.Edit? Data { get; set; }

        /// <summary>
        /// The time the render task was initially queued.<br/>
        /// Example: 2020-10-30T09:42:29.446Z
        /// </summary>
        /// <example>2020-10-30T09:42:29.446Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// The time the render status was last updated.<br/>
        /// Example: 2020-10-30T09:42:39.168Z
        /// </summary>
        /// <example>2020-10-30T09:42:39.168Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderResponseData" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the render task in UUID format.<br/>
        /// Example: 2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7
        /// </param>
        /// <param name="owner">
        /// The owner id of the render task.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="status">
        /// The status of the render task. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`queued` - render is queued waiting to be rendered&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fetching` - assets are being fetched&lt;/li&gt;<br/>
        ///   &lt;li&gt;`preprocessing` - video assets are being processed for compatibility&lt;/li&gt;<br/>
        ///   &lt;li&gt;`rendering` - the asset is being rendered&lt;/li&gt;<br/>
        ///   &lt;li&gt;`saving` - the final asset is being saved to storage&lt;/li&gt;<br/>
        ///   &lt;li&gt;`done` - the asset is ready to be downloaded&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - there was an error rendering the asset&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: done
        /// </param>
        /// <param name="plan">
        /// The customer subscription plan.<br/>
        /// Example: basic
        /// </param>
        /// <param name="error">
        /// An error message, only displayed if an error occurred.
        /// </param>
        /// <param name="duration">
        /// The output video or audio length in seconds.<br/>
        /// Example: 8.5F
        /// </param>
        /// <param name="renderTime">
        /// The time taken to render the asset in milliseconds.<br/>
        /// Example: 9433.44F
        /// </param>
        /// <param name="url">
        /// The URL of the final asset. This will only be available if status is done. This is a temporary URL and will be deleted after 24 hours. By default all assets are copied to the Shotstack hosting and CDN destination.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7.mp4
        /// </param>
        /// <param name="poster">
        /// The URL of the poster image if requested. This will only be available if status is done.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7-poster.jpg
        /// </param>
        /// <param name="thumbnail">
        /// The URL of the thumbnail image if requested. This will only be available if status is done.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/5ca6hu7s9k/2abd5c11-0f3d-4c6d-ba20-235fc9b8e8b7-thumb.jpg
        /// </param>
        /// <param name="data">
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </param>
        /// <param name="created">
        /// The time the render task was initially queued.<br/>
        /// Example: 2020-10-30T09:42:29.446Z
        /// </param>
        /// <param name="updated">
        /// The time the render status was last updated.<br/>
        /// Example: 2020-10-30T09:42:39.168Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderResponseData(
            string id,
            string owner,
            global::G.RenderResponseDataStatus status,
            string? plan,
            string? error,
            double? duration,
            double? renderTime,
            string? url,
            string? poster,
            string? thumbnail,
            global::G.Edit? data,
            string? created,
            string? updated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Plan = plan;
            this.Status = status;
            this.Error = error;
            this.Duration = duration;
            this.RenderTime = renderTime;
            this.Url = url;
            this.Poster = poster;
            this.Thumbnail = thumbnail;
            this.Data = data;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderResponseData" /> class.
        /// </summary>
        public RenderResponseData()
        {
        }
    }
}