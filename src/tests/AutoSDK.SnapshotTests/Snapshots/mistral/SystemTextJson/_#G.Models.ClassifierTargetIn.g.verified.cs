//HintName: G.Models.ClassifierTargetIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierTargetIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_function")]
        public global::G.FTClassifierLossFunction? LossFunction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetIn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="labels"></param>
        /// <param name="weight">
        /// Default Value: 1
        /// </param>
        /// <param name="lossFunction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierTargetIn(
            string name,
            global::System.Collections.Generic.IList<string> labels,
            double? weight,
            global::G.FTClassifierLossFunction? lossFunction)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Weight = weight;
            this.LossFunction = lossFunction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetIn" /> class.
        /// </summary>
        public ClassifierTargetIn()
        {
        }
    }
}