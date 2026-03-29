//HintName: G.Models.InferenceRequestImageValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image data corresponding to the image type, if type = 'url' then value is a string containing the url of an image, else if type = 'base64' then value is a string containing base64 encoded image data, else if type = 'numpy' then value is binary numpy data serialized using pickle.dumps(); array should 3 dimensions, channels last, with values in the range [0,255].
    /// </summary>
    public sealed partial class InferenceRequestImageValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}