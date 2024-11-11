//HintName: G.Models.ErrPipelineValidation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ErrPipelineValidation contains information about a failed pipeline<br/>
    /// validation.
    /// </summary>
    public sealed partial class ErrPipelineValidation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrPipelineValidation" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="error"></param>
        public ErrPipelineValidation(
            string? location,
            string? error)
        {
            this.Location = location;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrPipelineValidation" /> class.
        /// </summary>
        public ErrPipelineValidation()
        {
        }
    }
}