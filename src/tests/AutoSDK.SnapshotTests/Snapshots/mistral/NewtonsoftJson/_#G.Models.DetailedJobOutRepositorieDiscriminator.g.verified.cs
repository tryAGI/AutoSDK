//HintName: G.Models.DetailedJobOutRepositorieDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedJobOutRepositorieDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DetailedJobOutRepositorieDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedJobOutRepositorieDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public DetailedJobOutRepositorieDiscriminator(
            global::G.DetailedJobOutRepositorieDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedJobOutRepositorieDiscriminator" /> class.
        /// </summary>
        public DetailedJobOutRepositorieDiscriminator()
        {
        }
    }
}