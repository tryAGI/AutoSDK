//HintName: G.Models.UserMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
    /// **Example**:<br/>
    /// ```JSON<br/>
    /// "user_metadata": {<br/>
    ///   "category": "recentlyAdded",<br/>
    ///   "batchNumber": 5,<br/>
    ///   "rating": 9.3,<br/>
    ///   "needsReview": true<br/>
    /// }<br/>
    /// ```<br/>
    /// &lt;Note title="Notes"&gt;<br/>
    /// -  If you want to store other types of data such as objects or arrays,  you must convert your data into string values.<br/>
    /// - You cannot override the following system-generated metadata fields:<br/>
    ///   - `duration`<br/>
    ///   - `filename`<br/>
    ///   - `fps`<br/>
    ///   - `height`<br/>
    ///   - `model_names`<br/>
    ///   - `size`<br/>
    ///   - `video_title`<br/>
    ///   - `width`<br/>
    /// &lt;/Note&gt;
    /// </summary>
    public sealed partial class UserMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}