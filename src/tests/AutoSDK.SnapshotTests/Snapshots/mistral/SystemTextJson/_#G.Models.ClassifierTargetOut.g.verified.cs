//HintName: G.Models.ClassifierTargetOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierTargetOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_function")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FTClassifierLossFunctionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FTClassifierLossFunction LossFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetOut" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="lossFunction"></param>
        /// <param name="name"></param>
        /// <param name="weight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierTargetOut(
            global::System.Collections.Generic.IList<string> labels,
            global::G.FTClassifierLossFunction lossFunction,
            string name,
            double weight)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.LossFunction = lossFunction;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetOut" /> class.
        /// </summary>
        public ClassifierTargetOut()
        {
        }
    }
}