//HintName: G.Models.PercentageValueStatPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PercentageValueStatPublic : global::G.ProjectStatItemObjectPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.PercentageValuesPublic? Value { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublic" /> class.
        /// </summary>
        /// <param name="value"></param>
        public PercentageValueStatPublic(
            global::G.PercentageValuesPublic? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublic" /> class.
        /// </summary>
        public PercentageValueStatPublic()
        {
        }
    }
}