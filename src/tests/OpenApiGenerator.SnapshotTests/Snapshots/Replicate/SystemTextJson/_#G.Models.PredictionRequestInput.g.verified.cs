//HintName: G.Models.PredictionRequestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model's input as a JSON object. The input schema depends on what model you are running. To see the available inputs, click the "API" tab on the model you are running or [get the model version](#models.versions.get) and look at its `openapi_schema` property. For example, [stability-ai/sdxl](https://replicate.com/stability-ai/sdxl) takes `prompt` as an input.
    /// Files should be passed as HTTP URLs or data URLs.
    /// Use an HTTP URL when:
    /// - you have a large file &gt; 256kb
    /// - you want to be able to use the file multiple times
    /// - you want your prediction metadata to be associable with your input files
    /// Use a data URL when:
    /// - you have a small file &lt;= 256kb
    /// - you don't want to upload and host the file somewhere
    /// - you don't need to use the file again (Replicate will not store it)
    /// </summary>
    public sealed partial class PredictionRequestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}