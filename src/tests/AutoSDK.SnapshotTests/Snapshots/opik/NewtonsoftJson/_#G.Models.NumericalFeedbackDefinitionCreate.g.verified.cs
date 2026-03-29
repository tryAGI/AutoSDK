//HintName: G.Models.NumericalFeedbackDefinitionCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericalFeedbackDefinitionCreate : global::G.FeedbackCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.NumericalFeedbackDetailCreate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDefinitionCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="details"></param>
        public NumericalFeedbackDefinitionCreate(
            string name,
            global::G.NumericalFeedbackDetailCreate? details)
        {
            this.Details = details;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDefinitionCreate" /> class.
        /// </summary>
        public NumericalFeedbackDefinitionCreate()
        {
        }
    }
}