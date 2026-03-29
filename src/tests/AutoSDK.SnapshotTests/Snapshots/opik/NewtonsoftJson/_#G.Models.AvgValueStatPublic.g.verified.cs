//HintName: G.Models.AvgValueStatPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvgValueStatPublic : global::G.ProjectStatItemObjectPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AvgValueStatPublic" /> class.
        /// </summary>
        /// <param name="value"></param>
        public AvgValueStatPublic(
            double? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvgValueStatPublic" /> class.
        /// </summary>
        public AvgValueStatPublic()
        {
        }
    }
}