//HintName: G.Models.ConvertDocumentsRequestOptionsPictureDescriptionLocal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: Options for running a local vision-language model in the picture description. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with picture_description_api. Please migrate to picture_description_preset or picture_description_custom_config.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ConvertDocumentsRequestOptionsPictureDescriptionLocal
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}