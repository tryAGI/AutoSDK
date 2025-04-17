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
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loss_function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FTClassifierLossFunction LossFunction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetOut" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="lossFunction"></param>
        /// <param name="name"></param>
        /// <param name="weight"></param>
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