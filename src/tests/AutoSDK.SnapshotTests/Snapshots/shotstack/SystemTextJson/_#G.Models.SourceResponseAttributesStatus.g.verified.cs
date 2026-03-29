//HintName: G.Models.SourceResponseAttributesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the source file ingestion task. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`queued` - ingestion task is queued waiting to be fetched&lt;/li&gt;<br/>
    ///   &lt;li&gt;`importing` - the source file is being downloaded&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ready` - the source file has been ingested and stored&lt;/li&gt;<br/>
    ///   &lt;li&gt;`failed` - there was an error ingesting the source file&lt;/li&gt;<br/>
    ///   &lt;li&gt;`deleted` - the source file has been deleted&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: ready
    /// </summary>
    public enum SourceResponseAttributesStatus
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
    public static class SourceResponseAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceResponseAttributesStatus value)
        {
            return value switch
            {
                SourceResponseAttributesStatus.Deleted => "deleted",
                SourceResponseAttributesStatus.Failed => "failed",
                SourceResponseAttributesStatus.Importing => "importing",
                SourceResponseAttributesStatus.Overwritten => "overwritten",
                SourceResponseAttributesStatus.Queued => "queued",
                SourceResponseAttributesStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceResponseAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => SourceResponseAttributesStatus.Deleted,
                "failed" => SourceResponseAttributesStatus.Failed,
                "importing" => SourceResponseAttributesStatus.Importing,
                "overwritten" => SourceResponseAttributesStatus.Overwritten,
                "queued" => SourceResponseAttributesStatus.Queued,
                "ready" => SourceResponseAttributesStatus.Ready,
                _ => null,
            };
        }
    }
}