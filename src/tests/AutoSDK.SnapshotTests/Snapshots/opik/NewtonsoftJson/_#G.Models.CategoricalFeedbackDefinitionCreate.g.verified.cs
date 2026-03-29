//HintName: G.Models.CategoricalFeedbackDefinitionCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionCreate : global::G.FeedbackCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.CategoricalFeedbackDetailCreate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="details"></param>
        public CategoricalFeedbackDefinitionCreate(
            string name,
            global::G.CategoricalFeedbackDetailCreate? details)
        {
            this.Details = details;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionCreate" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionCreate()
        {
        }
    }
}