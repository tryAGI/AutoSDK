//HintName: G.Models.RemoveBackgroundResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveBackgroundResponse3
    {
        /// <summary>
        /// The details of the error<br/>
        /// Example: Please provide an image.
        /// </summary>
        /// <example>Please provide an image.</example>
        [global::Newtonsoft.Json.JsonProperty("detail", Required = global::Newtonsoft.Json.Required.Always)]
        public string Detail { get; set; } = default!;

        /// <summary>
        /// The status code of the error<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public double StatusCode { get; set; } = default!;

        /// <summary>
        /// The type of the error<br/>
        /// Example: missing_image
        /// </summary>
        /// <example>missing_image</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundResponse3" /> class.
        /// </summary>
        /// <param name="detail">
        /// The details of the error<br/>
        /// Example: Please provide an image.
        /// </param>
        /// <param name="statusCode">
        /// The status code of the error<br/>
        /// Example: 400
        /// </param>
        /// <param name="type">
        /// The type of the error<br/>
        /// Example: missing_image
        /// </param>
        public RemoveBackgroundResponse3(
            string detail,
            double statusCode,
            string type)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.StatusCode = statusCode;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundResponse3" /> class.
        /// </summary>
        public RemoveBackgroundResponse3()
        {
        }
    }
}