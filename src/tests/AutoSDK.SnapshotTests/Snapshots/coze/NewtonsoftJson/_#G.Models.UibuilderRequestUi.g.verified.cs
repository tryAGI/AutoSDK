//HintName: G.Models.UibuilderRequestUi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UibuilderRequestUi
    {
        /// <summary>
        /// Example: my-client
        /// </summary>
        /// <example>my-client</example>
        [global::Newtonsoft.Json.JsonProperty("className")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UibuilderRequestUi" /> class.
        /// </summary>
        /// <param name="className">
        /// Example: my-client
        /// </param>
        public UibuilderRequestUi(
            string? className)
        {
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UibuilderRequestUi" /> class.
        /// </summary>
        public UibuilderRequestUi()
        {
        }
    }
}