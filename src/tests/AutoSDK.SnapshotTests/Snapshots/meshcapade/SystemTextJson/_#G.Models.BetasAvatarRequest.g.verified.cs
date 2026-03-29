//HintName: G.Models.BetasAvatarRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetasAvatarRequest
    {
        /// <summary>
        /// SMPL shape parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betas")]
        public global::System.Collections.Generic.IList<double>? Betas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenderJsonConverter))]
        public global::G.Gender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::G.ImageTagLinks? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_measurements")]
        public global::System.Collections.Generic.Dictionary<string, double>? InputMeasurements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelVersionJsonConverter))]
        public global::G.ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poseName")]
        public string? PoseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poses")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Poses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predicted_measurements")]
        public global::System.Collections.Generic.Dictionary<string, double>? PredictedMeasurements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetasAvatarRequest" /> class.
        /// </summary>
        /// <param name="betas">
        /// SMPL shape parameters
        /// </param>
        /// <param name="fps"></param>
        /// <param name="gender"></param>
        /// <param name="images"></param>
        /// <param name="inputMeasurements"></param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
        /// <param name="poseName"></param>
        /// <param name="poses"></param>
        /// <param name="predictedMeasurements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetasAvatarRequest(
            global::System.Collections.Generic.IList<double>? betas,
            double? fps,
            global::G.Gender? gender,
            global::G.ImageTagLinks? images,
            global::System.Collections.Generic.Dictionary<string, double>? inputMeasurements,
            global::G.ModelVersion? modelVersion,
            string? name,
            string? poseName,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? poses,
            global::System.Collections.Generic.Dictionary<string, double>? predictedMeasurements)
        {
            this.Betas = betas;
            this.Fps = fps;
            this.Gender = gender;
            this.Images = images;
            this.InputMeasurements = inputMeasurements;
            this.ModelVersion = modelVersion;
            this.Name = name;
            this.PoseName = poseName;
            this.Poses = poses;
            this.PredictedMeasurements = predictedMeasurements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetasAvatarRequest" /> class.
        /// </summary>
        public BetasAvatarRequest()
        {
        }
    }
}