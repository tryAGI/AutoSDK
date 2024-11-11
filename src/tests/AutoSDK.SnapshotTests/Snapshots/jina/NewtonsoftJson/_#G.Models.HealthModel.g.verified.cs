//HintName: G.Models.HealthModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pydantic BaseModel for Jina health check, used as the response model in REST app.
    /// </summary>
    public sealed partial class HealthModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthModel" /> class.
        /// </summary>
        public HealthModel(
 )
        {
        }
    }
}