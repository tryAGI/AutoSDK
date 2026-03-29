//HintName: G.Models.RenderResponseDataStatus.g.cs

#nullable enable

namespace G
{
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
    public enum RenderResponseDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Fetching,
        /// <summary>
        /// 
        /// </summary>
        Preprocessing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Rendering,
        /// <summary>
        /// 
        /// </summary>
        Saving,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderResponseDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderResponseDataStatus value)
        {
            return value switch
            {
                RenderResponseDataStatus.Done => "done",
                RenderResponseDataStatus.Failed => "failed",
                RenderResponseDataStatus.Fetching => "fetching",
                RenderResponseDataStatus.Preprocessing => "preprocessing",
                RenderResponseDataStatus.Queued => "queued",
                RenderResponseDataStatus.Rendering => "rendering",
                RenderResponseDataStatus.Saving => "saving",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderResponseDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => RenderResponseDataStatus.Done,
                "failed" => RenderResponseDataStatus.Failed,
                "fetching" => RenderResponseDataStatus.Fetching,
                "preprocessing" => RenderResponseDataStatus.Preprocessing,
                "queued" => RenderResponseDataStatus.Queued,
                "rendering" => RenderResponseDataStatus.Rendering,
                "saving" => RenderResponseDataStatus.Saving,
                _ => null,
            };
        }
    }
}