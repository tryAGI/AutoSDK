//HintName: G.Models.ValidationErrorError.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public string? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.OneOf<string, int?, global::System.Collections.Generic.IList<string>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorError" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="field"></param>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public ValidationErrorError(
            string code,
            string? resource,
            string? field,
            string? message,
            int? index,
            global::G.OneOf<string, int?, global::System.Collections.Generic.IList<string>>? value)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Resource = resource;
            this.Field = field;
            this.Message = message;
            this.Index = index;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorError" /> class.
        /// </summary>
        public ValidationErrorError()
        {
        }
    }
}