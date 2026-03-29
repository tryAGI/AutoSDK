//HintName: G.Models.ModelDeleteRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelDeleteRes
    {
        /// <summary>
        /// Number of model versions deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumDeleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeleteRes" /> class.
        /// </summary>
        /// <param name="numDeleted">
        /// Number of model versions deleted
        /// </param>
        public ModelDeleteRes(
            int numDeleted)
        {
            this.NumDeleted = numDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeleteRes" /> class.
        /// </summary>
        public ModelDeleteRes()
        {
        }
    }
}