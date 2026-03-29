//HintName: G.Models.LlamaParseJobFailureConditionsFailOnImageExtractionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fail the entire job if any embedded image cannot be extracted. By default, image extraction errors are logged but don't fail the job
    /// </summary>
    public sealed partial class LlamaParseJobFailureConditionsFailOnImageExtractionError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}