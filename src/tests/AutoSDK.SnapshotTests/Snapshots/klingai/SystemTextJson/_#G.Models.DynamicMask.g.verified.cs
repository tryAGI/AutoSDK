//HintName: G.Models.DynamicMask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicMask
    {
        /// <summary>
        /// Mask image as Base64 string or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// Array of [x, y] coordinate pairs defining motion trajectory. 2-77 points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trajectories")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Trajectories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicMask" /> class.
        /// </summary>
        /// <param name="mask">
        /// Mask image as Base64 string or URL.
        /// </param>
        /// <param name="trajectories">
        /// Array of [x, y] coordinate pairs defining motion trajectory. 2-77 points.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicMask(
            string? mask,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? trajectories)
        {
            this.Mask = mask;
            this.Trajectories = trajectories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicMask" /> class.
        /// </summary>
        public DynamicMask()
        {
        }
    }
}