//HintName: G.Models.ToolMockConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMockConfig
    {
        /// <summary>
        /// Default Value: Tool Called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_return_value")]
        public string? DefaultReturnValue { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_is_error")]
        public bool? DefaultIsError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockConfig" /> class.
        /// </summary>
        /// <param name="defaultReturnValue">
        /// Default Value: Tool Called.
        /// </param>
        /// <param name="defaultIsError">
        /// Default Value: false
        /// </param>
        public ToolMockConfig(
            string? defaultReturnValue,
            bool? defaultIsError)
        {
            this.DefaultReturnValue = defaultReturnValue;
            this.DefaultIsError = defaultIsError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockConfig" /> class.
        /// </summary>
        public ToolMockConfig()
        {
        }
    }
}