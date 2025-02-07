//HintName: G.Models.UpdateDataSetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDataSetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DataSetVO DataSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDataSetRequest" /> class.
        /// </summary>
        /// <param name="dataSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDataSetRequest(
            global::G.DataSetVO dataSet)
        {
            this.DataSet = dataSet ?? throw new global::System.ArgumentNullException(nameof(dataSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDataSetRequest" /> class.
        /// </summary>
        public UpdateDataSetRequest()
        {
        }
    }
}