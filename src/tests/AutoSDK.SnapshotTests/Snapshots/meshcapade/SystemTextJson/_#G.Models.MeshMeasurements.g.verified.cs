//HintName: G.Models.MeshMeasurements.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeshMeasurements
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Ankle_girth")]
        public double? AnkleGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Armscye_girth")]
        public double? ArmscyeGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Back_shoulder_width")]
        public double? BackShoulderWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Bust_girth")]
        public double? BustGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Foot_length")]
        public double? FootLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Height")]
        public double? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Inside_leg_height")]
        public double? InsideLegHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Lower_arm_length")]
        public double? LowerArmLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Neck_base_girth")]
        public double? NeckBaseGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Shoulder_length")]
        public double? ShoulderLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Thigh_girth")]
        public double? ThighGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Top_hip_girth")]
        public double? TopHipGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Upper_arm_length")]
        public double? UpperArmLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Waist_girth")]
        public double? WaistGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshMeasurements" /> class.
        /// </summary>
        /// <param name="ankleGirth"></param>
        /// <param name="armscyeGirth"></param>
        /// <param name="backShoulderWidth"></param>
        /// <param name="bustGirth"></param>
        /// <param name="footLength"></param>
        /// <param name="height"></param>
        /// <param name="insideLegHeight"></param>
        /// <param name="lowerArmLength"></param>
        /// <param name="neckBaseGirth"></param>
        /// <param name="shoulderLength"></param>
        /// <param name="thighGirth"></param>
        /// <param name="topHipGirth"></param>
        /// <param name="upperArmLength"></param>
        /// <param name="waistGirth"></param>
        /// <param name="weight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeshMeasurements(
            double? ankleGirth,
            double? armscyeGirth,
            double? backShoulderWidth,
            double? bustGirth,
            double? footLength,
            double? height,
            double? insideLegHeight,
            double? lowerArmLength,
            double? neckBaseGirth,
            double? shoulderLength,
            double? thighGirth,
            double? topHipGirth,
            double? upperArmLength,
            double? waistGirth,
            double? weight)
        {
            this.AnkleGirth = ankleGirth;
            this.ArmscyeGirth = armscyeGirth;
            this.BackShoulderWidth = backShoulderWidth;
            this.BustGirth = bustGirth;
            this.FootLength = footLength;
            this.Height = height;
            this.InsideLegHeight = insideLegHeight;
            this.LowerArmLength = lowerArmLength;
            this.NeckBaseGirth = neckBaseGirth;
            this.ShoulderLength = shoulderLength;
            this.ThighGirth = thighGirth;
            this.TopHipGirth = topHipGirth;
            this.UpperArmLength = upperArmLength;
            this.WaistGirth = waistGirth;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshMeasurements" /> class.
        /// </summary>
        public MeshMeasurements()
        {
        }
    }
}