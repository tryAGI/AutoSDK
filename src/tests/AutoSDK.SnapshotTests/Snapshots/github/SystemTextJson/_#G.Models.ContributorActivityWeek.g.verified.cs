//HintName: G.Models.ContributorActivityWeek.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContributorActivityWeek
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("w")]
        public int? W { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("a")]
        public int? A { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("d")]
        public int? D { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c")]
        public int? C { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContributorActivityWeek" /> class.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <param name="c"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContributorActivityWeek(
            int? w,
            int? a,
            int? d,
            int? c)
        {
            this.W = w;
            this.A = a;
            this.D = d;
            this.C = c;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContributorActivityWeek" /> class.
        /// </summary>
        public ContributorActivityWeek()
        {
        }
    }
}