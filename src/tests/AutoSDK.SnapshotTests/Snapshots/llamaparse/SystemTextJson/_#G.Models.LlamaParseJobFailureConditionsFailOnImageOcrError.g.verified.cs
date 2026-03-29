//HintName: G.Models.LlamaParseJobFailureConditionsFailOnImageOcrError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fail the entire job if OCR fails on any image. By default, OCR errors result in empty text for that image
    /// </summary>
    public sealed partial class LlamaParseJobFailureConditionsFailOnImageOcrError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}