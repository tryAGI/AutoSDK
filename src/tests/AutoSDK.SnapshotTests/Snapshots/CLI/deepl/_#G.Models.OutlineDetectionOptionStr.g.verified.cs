//HintName: G.Models.OutlineDetectionOptionStr.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The automatic detection of the XML structure won't yield best results in all XML files. You can disable this automatic mechanism altogether by setting the `outline_detection` parameter to `0` and selecting the tags that should be considered structure tags. This will split sentences using the `splitting_tags` parameter.<br/>
    /// In the example below, we achieve the same results as the automatic engine by disabling automatic detection with `outline_detection=0` and setting the parameters manually to `tag_handling=xml`, `split_sentences=nonewlines`,  and `splitting_tags=par,title`.<br/>
    ///  * Example request:<br/>
    ///    ```<br/>
    ///    &lt;document&gt;<br/>
    ///      &lt;meta&gt;<br/>
    ///        &lt;title&gt;A document's title&lt;/title&gt;<br/>
    ///      &lt;/meta&gt;<br/>
    ///      &lt;content&gt;<br/>
    ///        &lt;par&gt;This is the first sentence. Followed by a second one.&lt;/par&gt;<br/>
    ///        &lt;par&gt;This is the third sentence.&lt;/par&gt;<br/>
    ///      &lt;/content&gt;<br/>
    ///    &lt;/document&gt;<br/>
    ///    ```<br/>
    ///  * Example response:<br/>
    ///    ```<br/>
    ///    &lt;document&gt;<br/>
    ///      &lt;meta&gt;<br/>
    ///        &lt;title&gt;Der Titel eines Dokuments&lt;/title&gt;<br/>
    ///      &lt;/meta&gt;<br/>
    ///      &lt;content&gt;<br/>
    ///        &lt;par&gt;Das ist der erste Satz. Gefolgt von einem zweiten.&lt;/par&gt;<br/>
    ///        &lt;par&gt;Dies ist der dritte Satz.&lt;/par&gt;<br/>
    ///      &lt;/content&gt;<br/>
    ///    &lt;/document&gt;<br/>
    ///    ```<br/>
    /// While this approach is slightly more complicated, it allows for greater control over the structure of the translation output.
    /// </summary>
    public enum OutlineDetectionOptionStr
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutlineDetectionOptionStrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutlineDetectionOptionStr value)
        {
            return value switch
            {
                OutlineDetectionOptionStr.x0 => "0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutlineDetectionOptionStr? ToEnum(string value)
        {
            return value switch
            {
                "0" => OutlineDetectionOptionStr.x0,
                _ => null,
            };
        }
    }
}