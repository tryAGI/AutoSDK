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
        [global::Newtonsoft.Json.JsonProperty("Ankle_girth")]
        public double? AnkleGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Armscye_girth")]
        public double? ArmscyeGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Back_shoulder_width")]
        public double? BackShoulderWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Bust_girth")]
        public double? BustGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Foot_length")]
        public double? FootLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Height")]
        public double? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Inside_leg_height")]
        public double? InsideLegHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Lower_arm_length")]
        public double? LowerArmLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Neck_base_girth")]
        public double? NeckBaseGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Shoulder_length")]
        public double? ShoulderLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Thigh_girth")]
        public double? ThighGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Top_hip_girth")]
        public double? TopHipGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Upper_arm_length")]
        public double? UpperArmLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Waist_girth")]
        public double? WaistGirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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