//HintName: G.Models.MistralModerationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MistralModerationParameters
    {
        /// <summary>
        /// Categories that should NOT be allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MistralModerationParametersCategorie> Categories { get; set; } = default!;

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MistralModerationParameters" /> class.
        /// </summary>
        /// <param name="categories">
        /// Categories that should NOT be allowed
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
        public MistralModerationParameters(
            global::System.Collections.Generic.IList<global::G.MistralModerationParametersCategorie> categories,
            double? timeout)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MistralModerationParameters" /> class.
        /// </summary>
        public MistralModerationParameters()
        {
        }
    }
}