//HintName: G.Models.RenditionResponseAttributesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the rendition transformation task. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`waiting` - rendition task is waiting for source file to become available&lt;/li&gt;<br/>
    ///   &lt;li&gt;`queued` - rendition task is queued waiting to be processed&lt;/li&gt;<br/>
    ///   &lt;li&gt;`processing` - the rendition is being processed&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ready` - the rendition is ready to be downloaded&lt;/li&gt;<br/>
    ///   &lt;li&gt;`failed` - there was an error creating the rendition&lt;/li&gt;<br/>
    ///   &lt;li&gt;`deleted` - the rendition has been deleted&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: ready
    /// </summary>
    public enum RenditionResponseAttributesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Importing,
        /// <summary>
        /// 
        /// </summary>
        Overwritten,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenditionResponseAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenditionResponseAttributesStatus value)
        {
            return value switch
            {
                RenditionResponseAttributesStatus.Deleted => "deleted",
                RenditionResponseAttributesStatus.Failed => "failed",
                RenditionResponseAttributesStatus.Importing => "importing",
                RenditionResponseAttributesStatus.Overwritten => "overwritten",
                RenditionResponseAttributesStatus.Queued => "queued",
                RenditionResponseAttributesStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenditionResponseAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => RenditionResponseAttributesStatus.Deleted,
                "failed" => RenditionResponseAttributesStatus.Failed,
                "importing" => RenditionResponseAttributesStatus.Importing,
                "overwritten" => RenditionResponseAttributesStatus.Overwritten,
                "queued" => RenditionResponseAttributesStatus.Queued,
                "ready" => RenditionResponseAttributesStatus.Ready,
                _ => null,
            };
        }
    }
}