//HintName: G.Models.PictureClassificationClass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PictureClassificationData.
    /// </summary>
    public sealed partial class PictureClassificationClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClassName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationClass" /> class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="confidence"></param>
        public PictureClassificationClass(
            string className,
            double confidence)
        {
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationClass" /> class.
        /// </summary>
        public PictureClassificationClass()
        {
        }
    }
}