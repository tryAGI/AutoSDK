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
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::G.PercentageValuesPublic? Value { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublic" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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