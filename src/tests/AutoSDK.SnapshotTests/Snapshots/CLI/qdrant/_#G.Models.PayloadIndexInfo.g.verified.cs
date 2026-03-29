//HintName: G.Models.PayloadIndexInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Display payload field type &amp; index information
    /// </summary>
    public sealed partial class PayloadIndexInfo
    {
        /// <summary>
        /// All possible names of payload types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PayloadSchemaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PayloadSchemaType DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::G.PayloadSchemaParams? Params { get; set; }

        /// <summary>
        /// Number of points indexed with this index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadIndexInfo" /> class.
        /// </summary>
        /// <param name="dataType">
        /// All possible names of payload types
        /// </param>
        /// <param name="points">
        /// Number of points indexed with this index
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayloadIndexInfo(
            global::G.PayloadSchemaType dataType,
            int points,
            global::G.PayloadSchemaParams? @params)
        {
            this.DataType = dataType;
            this.Params = @params;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadIndexInfo" /> class.
        /// </summary>
        public PayloadIndexInfo()
        {
        }
    }
}